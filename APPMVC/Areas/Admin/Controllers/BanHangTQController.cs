using AppData.Model;
using AppData.ViewModel;
using APPMVC.IService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APPMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BanHangTQController : Controller
    {
        private readonly ISanPhamChiTietService _sanPhamCTService;
        private readonly ISanPhamService _sanPhamService;
        private readonly IKhachHangService _khachHangService;
        private readonly IHoaDonChiTietService _hoaDonChiTietService;
        private readonly IHoaDonService _hoaDonService;
        private readonly INhanVienService _nhanVienService;
        private readonly ILichSuHoaDonService _lichSuHoaDonService;
        private readonly IMauSacService _mauSacService;
        private readonly IKichCoService _kichCoService;
        private readonly ISanPhamChiTietMauSacService _sanPhamChiTietMauSacService;
        private readonly ISanPhamChiTietKichCoService _sanPhamChiTietKichCoService;
        private readonly IHinhAnhService _hinhAnhService;

        public BanHangTQController(
            ISanPhamChiTietService sanPhamChiTietService,
            ISanPhamService sanPhamService,
            IKhachHangService khachHangService,
            IHoaDonChiTietService hoaDonChiTietService,
            IHoaDonService hoaDonService,
            INhanVienService nhanVienService,
            ILichSuHoaDonService lichSuHoaDonService,
            IMauSacService mauSacService,
            IKichCoService kichCoService,
            ISanPhamChiTietMauSacService sanPhamChiTietMauSacService,
            ISanPhamChiTietKichCoService sanPhamChiTietKichCoService,
            IHinhAnhService hinhAnhService)
        {
            _sanPhamCTService = sanPhamChiTietService;
            _sanPhamService = sanPhamService;
            _khachHangService = khachHangService;
            _hoaDonChiTietService = hoaDonChiTietService;
            _hoaDonService = hoaDonService;
            _nhanVienService = nhanVienService;
            _lichSuHoaDonService = lichSuHoaDonService;
            _mauSacService = mauSacService;
            _kichCoService = kichCoService;
            _sanPhamChiTietMauSacService = sanPhamChiTietMauSacService;
            _sanPhamChiTietKichCoService = sanPhamChiTietKichCoService;
            _hinhAnhService = hinhAnhService;
        }

        public async Task<ActionResult> Index()
        {
            var hoaDons = await _hoaDonService.GetAllAsync();
            if (hoaDons == null)
            {
                return View(new List<HoaDon>());
            }
            var filteredOrders = hoaDons.Where(hd => hd.TrangThai == "Tạo đơn hàng").ToList();

            return View(filteredOrders);
        }

        [HttpPost]
        public async Task<IActionResult> TaoHD()
        {
            if (!ModelState.IsValid)
            {
                return View("Index");
            }

            var NVIdString = HttpContext.Session.GetString("IdNhanVien");

            if (string.IsNullOrEmpty(NVIdString) || !Guid.TryParse(NVIdString, out Guid NVID))
            {
                return Unauthorized(new { message = "Nhân viên không tồn tại trong phiên làm việc." });
            }

            var currentOrders = await _hoaDonService.GetAllAsync();
            var countPendingOrders = currentOrders.Count(hd => hd.TrangThai == "Tạo đơn hàng");

            if (countPendingOrders >= 5)
            {
                ModelState.AddModelError("", "Không thể tạo thêm đơn hàng. Đã đạt giới hạn tối đa 5 đơn hàng với trạng thái 'Tạo đơn hàng'.");
                return View("Index");
            }

            var order = new HoaDon
            {
                IdHoaDon = Guid.NewGuid(),
                MaDon = await GenerateOrderNumberAsync(),
                NguoiNhan = null,
                SoDienThoaiNguoiNhan = null,
                DiaChiGiaoHang = null,
                LoaiHoaDon = "Tại Quầy",
                TienShip = 1,
                TongTienDonHang = 1,
                TongTienHoaDon = 1,
                NgayTao = DateTime.Now,
                NguoiTao = "Nhân Viên",
                KichHoat = 1,
                TrangThai = "Tạo đơn hàng",
                IdKhachHang = null,
                IdNhanVien = NVID
            };

            try
            {
                await _hoaDonService.AddAsync(order);

                var lichSu = new LichSuHoaDon
                {
                    IdLichSuHoaDon = Guid.NewGuid(),
                    ThaoTac = order.TrangThai,
                    NgayTao = DateTime.Now,
                    NguoiThaoTac = "Nhân Viên",
                    TrangThai = "1",
                    IdHoaDon = order.IdHoaDon,
                };

                await _lichSuHoaDonService.AddAsync(lichSu);

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Đã xảy ra lỗi khi xử lý đơn hàng. Vui lòng thử lại.");
                Console.WriteLine(ex.Message);
            }

            return View("Index");
        }

        private async Task<string> GenerateOrderNumberAsync()
        {
            var lastOrderNumber = await GetLastOrderNumberAsync();
            int newOrderNumber = lastOrderNumber + 1;
            string newOrderNumberString = $"HD{newOrderNumber}";

            while (await IsOrderNumberExists(newOrderNumberString))
            {
                newOrderNumber++;
                newOrderNumberString = $"HD{newOrderNumber}";
            }

            return newOrderNumberString;
        }

        private async Task<int> GetLastOrderNumberAsync()
        {
            var allOrders = await _hoaDonService.GetAllAsync();
            if (allOrders == null || !allOrders.Any())
            {
                return 0;
            }
            return allOrders.Max(order => int.Parse(order.MaDon.Substring(2)));
        }

        private async Task<bool> IsOrderNumberExists(string orderNumber)
        {
            var existingOrder = await _hoaDonService.GetByOrderNumberAsync(orderNumber);
            return existingOrder != null;
        }
    }
}