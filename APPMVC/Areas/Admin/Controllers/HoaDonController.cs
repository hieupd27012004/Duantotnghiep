using AppData.Model;
using AppData.ViewModel;
using APPMVC.IService;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;
using static AppData.ViewModel.HoaDonChiTietViewModel;

namespace APPMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HoaDonController : Controller
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

        public HoaDonController(ISanPhamChiTietService sanPhamChiTietService, 
            ISanPhamService sanPhamService, 
            IKhachHangService khachHangService, 
            IHoaDonChiTietService hoaDonChiTietService , 
            IHoaDonService hoaDonService , 
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
            _khachHangService = khachHangService ;
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
        public async Task<ActionResult> Index(int page = 1)
        {
            page = page < 1 ? 1 : page;
            int pageSize = 5;

            List<HoaDon> hoaDons = await _hoaDonService.GetAllAsync();

            if (hoaDons == null || !hoaDons.Any())
            {
                return View(new List<HoaDon>());
            }

            var pagedHoaDons = hoaDons.ToPagedList(page, pageSize);

            return View(pagedHoaDons);
        }
        [HttpGet]
        public async Task<ActionResult> Edit(Guid id)
        {
            var hoaDonChiTietList = await _hoaDonChiTietService.GetByIdHoaDonAsync(id);
            if (hoaDonChiTietList == null || !hoaDonChiTietList.Any())
            {
                return NotFound($"Hóa đơn chi tiết với ID {id} không tồn tại.");
            }

            var hoaDon = await _hoaDonService.GetByIdAsync(hoaDonChiTietList.First().IdHoaDon);
            if (hoaDon == null)
            {
                return NotFound($"Hóa đơn với ID {hoaDon.IdHoaDon} không tồn tại.");
            }

            var lichSuHoaDons = await _lichSuHoaDonService.GetByIdHoaDonAsync(id);

            var khachhang = await _khachHangService.GetIdKhachHang(hoaDon.IdKhachHang);

            var sanPhamChiTiets = new List<HoaDonChiTietViewModel.SanPhamChiTietViewModel>();
            foreach (var hoaDonChiTiet in hoaDonChiTietList)
            {
                var sanPhamCT = await _sanPhamCTService.GetSanPhamChiTietById(hoaDonChiTiet.IdSanPhamChiTiet);
                var sanPham = await _sanPhamCTService.GetSanPhamByIdSanPhamChiTietAsync(hoaDonChiTiet.IdSanPhamChiTiet);

                if (sanPhamCT != null)
                {

                    var mauSacList = await _sanPhamChiTietMauSacService.GetMauSacIdsBySanPhamChiTietId(sanPhamCT.IdSanPhamChiTiet);
                    var mauSacTenList = mauSacList.Select(ms => ms.TenMauSac).ToList();

                    var kichCoList = await _sanPhamChiTietKichCoService.GetKichCoIdsBySanPhamChiTietId(sanPhamCT.IdSanPhamChiTiet);
                    var kichCoTenList = kichCoList.Select(kc => kc.TenKichCo).ToList();

                    var hinhAnhs = await _hinhAnhService.GetHinhAnhsBySanPhamChiTietId(sanPhamCT.IdSanPhamChiTiet);


                    sanPhamChiTiets.Add(new HoaDonChiTietViewModel.SanPhamChiTietViewModel
                    {
                        IdSanPhamChiTiet = sanPhamCT.IdSanPhamChiTiet,
                        Quantity = hoaDonChiTiet.SoLuong,
                        Price = sanPhamCT.Gia,
                        ProductName = sanPham.TenSanPham,
                        MauSac = mauSacTenList,
                        KichCo = kichCoTenList,
                        HinhAnhs = hinhAnhs 
                    });
                }
            }

            var viewModel = new HoaDonChiTietViewModel
            {
                DonGia = hoaDon.TongTienDonHang,
                GiamGia = hoaDon.TienGiam,
                TongTien = hoaDon.TongTienHoaDon,

                HoaDon = new HoaDonViewModel
                {
                    MaDon = hoaDon.MaDon,
                    KhachHang = khachhang.HoTen,
                    TrangThai = hoaDon.TrangThai,
                    SoDienThoaiNguoiNhan = hoaDon.SoDienThoaiNguoiNhan,
                    LoaiHoaDon = hoaDon.LoaiHoaDon,
                    DiaChiGiaoHang = hoaDon.DiaChiGiaoHang
                },

                LichSuHoaDons = lichSuHoaDons.Select(lichSu => new HoaDonChiTietViewModel.LichSuHoaDonViewModel
                {
                    IdLichSuHoaDon = lichSu.IdLichSuHoaDon,
                    ThaoTac = lichSu.ThaoTac,
                    NgayTao = lichSu.NgayTao,
                    NguoiThaoTac = lichSu.NguoiThaoTac,
                    TrangThai = lichSu.TrangThai,
                    IdHoaDon = lichSu.IdHoaDon
                }).ToList(),

                SanPhamChiTiets = sanPhamChiTiets // Gán danh sách sản phẩm chi tiết vào view model
            };

            return View(viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(HoaDonChiTietViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var hoaDonChiTiet = new HoaDonChiTiet
                    {
                        IdHoaDonChiTiet = viewModel.IdHoaDonChiTiet,
                        DonGia = viewModel.DonGia,
                        SoLuong = viewModel.SoLuong,
                        TongTien = viewModel.TongTien,
                        KichHoat = viewModel.KichHoat,
                        IdHoaDon = viewModel.IdHoaDon
                    };

                    //await _hoaDonChiTietService.UpdateAsync(hoaDonChiTiet);
                    TempData["Success"] = "Cập nhật thành công!";
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    TempData["Error"] = $"Lỗi: {ex.Message}";
                }
            }

            return View(viewModel);
        }


        //[HttpPost]
        //public async Task<ActionResult> UpdateStatus(Guid id, string newStatus)
        //{
        //    // Validate the incoming new status
        //    if (string.IsNullOrEmpty(newStatus))
        //    {
        //        ModelState.AddModelError("", "Trạng thái không hợp lệ.");
        //        return RedirectToAction("Edit", new { id });
        //    }

        //    // You might want to include logic to handle the changes according to the current status
        //    // For example, prevent changing from "Completed" to "Cancelled"
        //    var currentStatus = await _hoaDonService.GetCurrentStatusAsync(id);

        //    // Implement your business logic here based on the currentStatus
        //    switch (currentStatus)
        //    {
        //        case "Đã Hủy":
        //            // Logic for already cancelled orders
        //            break;
        //        case "Hoàn thành":
        //            // Logic for completed orders
        //            if (newStatus != "Completed") // Prevent reverting back to other states
        //            {
        //                ModelState.AddModelError("", "Không thể thay đổi trạng thái từ 'Hoàn thành'.");
        //                return RedirectToAction("Edit", new { id });
        //            }
        //            break;
        //            // Add other cases as necessary
        //    }

        //    // Update the status in the database
        //    var result = await _hoaDonService.UpdateStatusAsync(id, newStatus);
        //    if (result)
        //    {
        //        // Redirect to the Edit view or another relevant view
        //        return RedirectToAction("Edit", new { id });
        //    }

        //    // Handle error case
        //    ModelState.AddModelError("", "Cập nhật trạng thái không thành công.");
        //    return RedirectToAction("Edit", new { id });
        //}
    }
}
