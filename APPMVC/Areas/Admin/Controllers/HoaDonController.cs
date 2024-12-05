using AppData.Model;
using AppData.ViewModel;
using APPMVC.IService;
using APPMVC.Service;
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
        private readonly ILichSuThanhToanService _lichSuThanhToanService;

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
            IHinhAnhService hinhAnhService,
            ILichSuThanhToanService lichSuThanhToanService)
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
            _lichSuThanhToanService = lichSuThanhToanService;
        }
        [HttpGet]
        public async Task<ActionResult> Index(int page = 1, string status = null)
        {
            page = page < 1 ? 1 : page; // Ensure that the page number is at least 1
            const int pageSize = 5;

            // Fetch all invoices
            var hoaDons = await _hoaDonService.GetAllAsync() ?? new List<HoaDon>();

            // Filter out unnecessary statuses
            var filteredHoaDons = hoaDons
                .Where(h => h.TrangThai != "Tạo đơn hàng")
                .ToList();

            // Apply status filtering if provided
            if (!string.IsNullOrEmpty(status))
            {
                filteredHoaDons = filteredHoaDons.Where(h => h.TrangThai == status).ToList();
            }

            // Fetch distinct statuses for the status filter dropdown
            var distinctStatuses = hoaDons
                .Select(h => h.TrangThai)
                .Where(s => s != "Tạo đơn hàng")
                .Distinct()
                .ToList();

            var hoaDonViewModels = new List<AppData.ViewModel.HoaDonViewModell>();

            // Populate view models and calculate total quantities
            foreach (var hoaDon in filteredHoaDons)
            {
                var hoaDonChiTiets = await _hoaDonChiTietService.GetByIdHoaDonAsync(hoaDon.IdHoaDon);
                var totalQuantity = hoaDonChiTiets.Sum(d => d.SoLuong);

                hoaDonViewModels.Add(new AppData.ViewModel.HoaDonViewModell
                {
                    HoaDon = hoaDon,
                    TotalQuantity = totalQuantity,
                    HoaDonChiTiets = hoaDonChiTiets
                });
            }

            // Sort the view models by NgayTao in descending order
            hoaDonViewModels = hoaDonViewModels
                .OrderByDescending(vm => vm.HoaDon.NgayTao)
                .ToList();

            // Paginate the sorted list
            var pagedHoaDons = hoaDonViewModels.ToPagedList(page, pageSize);

            // Set view bag properties for status filtering and total quantity
            ViewBag.CurrentStatus = status;
            ViewBag.TotalProductQuantity = hoaDonViewModels.Sum(vm => vm.TotalQuantity);
            ViewBag.Statuses = distinctStatuses;

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
            var lichSuThanhToans = await _lichSuThanhToanService.GetByIdHoaDonAsync(id);
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

                    var giaBan = sanPhamCT.Gia;
                    var giaDaGiam = sanPhamCT.GiaGiam;
                    double? phanTramGiam = null;

                    if (giaDaGiam.HasValue && giaDaGiam < giaBan)
                    {
                        phanTramGiam = Math.Round(((giaBan - giaDaGiam.Value) / giaBan) * 100, 2);
                        giaBan = giaDaGiam.Value;
                    }

                    sanPhamChiTiets.Add(new HoaDonChiTietViewModel.SanPhamChiTietViewModel
                    {
                        IdSanPhamChiTiet = sanPhamCT.IdSanPhamChiTiet,
                        Quantity = hoaDonChiTiet.SoLuong,
                        Price = giaBan,
                        ProductName = sanPham.TenSanPham,
                        MauSac = mauSacTenList,
                        KichCo = kichCoTenList,
                        HinhAnhs = hinhAnhs,
                        PhanTramGiam = phanTramGiam
                    });
                }
            }

            var viewModel = new HoaDonChiTietViewModel
            {
                DonGia = hoaDon.TongTienDonHang,
                GiamGia = hoaDon.TienGiam,
                PhiVanChuyen = Convert.ToDouble(hoaDon.TienShip),
                TongTien = hoaDon.TongTienDonHang + Convert.ToDouble(hoaDon.TienShip),

                HoaDon = new HoaDonViewModel
                {
                    IdHoaDon = hoaDon.IdHoaDon,
                    MaDon = hoaDon.MaDon,
                    KhachHang = hoaDon.NguoiNhan,
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
                    IdHoaDon = lichSu.IdHoaDon,
                    GhiChu = lichSu.GhiChu,
                }).ToList(),

                SanPhamChiTiets = sanPhamChiTiets,

                LichSuThanhToans = lichSuThanhToans.Select(payment => new LichSuThanhToanViewModel
                {
                    IdLichSuThanhToan = payment.IdLichSuThanhToan,
                    SoTien = payment.SoTien,
                    NgayThanhToan = payment.NgayTao,
                    LoaiGiaoDich = payment.LoaiGiaoDich,
                    NguoiThaoTac = payment.NguoiThaoTac,
                    HinhThucThanhToan = payment.Pttt,
                    TrangThai = payment.TrangThai,
                    IdHoaDon = payment.IdHoaDon
                }).ToList()
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
        [HttpPost]
        public async Task<IActionResult> UpdateInvoiceStatus(Guid id, string actionType, string reason)
        {
            var hoaDon = await _hoaDonService.GetByIdAsync(id);
            if (hoaDon == null)
            {
                return NotFound($"Hóa đơn với ID {id} không tồn tại.");
            }

            var lichSu = await _lichSuHoaDonService.GetByIdHoaDonAsync(id);
            bool hasPaymentHistory = lichSu.Any();
            string previousState = hoaDon.TrangThai;

            switch (hoaDon.TrangThai)
            {
                case "Chờ Xác Nhận":
                    if (actionType == "huy" && hoaDon.TrangThai != "Đã Hủy")
                    {
                        hoaDon.TrangThai = "Đã Hủy";
                        await UpdateProductQuantities2(hoaDon.IdHoaDon);
                    }
                    else if (hoaDon.TrangThai != "Đã Giao Hàng")
                    {
                        hoaDon.TrangThai = "Chờ Giao Hàng";
                        await UpdateProductQuantities(hoaDon.IdHoaDon);
                    }
                    break;

                case "Chờ Giao Hàng":
                    if (actionType == "huy" && hoaDon.TrangThai != "Đã Hủy")
                    {
                        hoaDon.TrangThai = "Đã Hủy";
                        await UpdateProductQuantities2(hoaDon.IdHoaDon);
                    }
                    else if (actionType == "quayLai")
                    {
                        return await RevertInvoiceStatus(id, reason);
                    }
                    else
                    {
                        hoaDon.TrangThai = "Đang Vận Chuyển";
                    }
                    break;

                case "Đang Vận Chuyển":
                    if (actionType == "quayLai")
                    {
                        return await RevertInvoiceStatus(id, reason);
                    }
                    else
                    {
                        hoaDon.TrangThai = "Đã Giao Hàng";
                    }
                    break;

                case "Đã Giao Hàng":
                    if (actionType == "quayLai")
                    {
                        return await RevertInvoiceStatus(id, reason);
                    }
                    else if (hasPaymentHistory)
                    {
                        hoaDon.TrangThai = "Hoàn Thành";
                    }
                    else
                    {
                        return BadRequest("Cần xác nhận thanh toán trước khi hoàn thành hóa đơn.");
                    }
                    break;

                case "Đã Thanh Toán":
                    if (actionType == "quayLai")
                    {
                        return await RevertInvoiceStatus(id, reason);
                    }
                    else
                    {
                        hoaDon.TrangThai = "Hoàn Thành";
                    }
                    break;

                default:
                    return BadRequest("Trạng thái hóa đơn không hợp lệ.");
            }

            if (hoaDon.TrangThai != previousState)
            {
                await LogHistory(hoaDon, hoaDon.TrangThai, reason);
            }

            await _hoaDonService.UpdateAsync(hoaDon);
            return RedirectToAction("Edit", new { id });
        }

        private async Task<IActionResult> RevertInvoiceStatus(Guid id, string reason)
        {
            var hoaDon = await _hoaDonService.GetByIdAsync(id);
            if (hoaDon == null)
            {
                return NotFound($"Hóa đơn với ID {id} không tồn tại.");
            }

            var lichSu = await _lichSuHoaDonService.GetByIdHoaDonAsync(id);
            if (lichSu == null || lichSu.Count < 2)
            {
                return BadRequest("Không có lịch sử trạng thái trước đó để quay lại.");
            }

            var previousState = lichSu[lichSu.Count - 2].ThaoTac;

            hoaDon.TrangThai = previousState;

            if (previousState == "Chờ Xác Nhận")
            {
                await UpdateProductQuantities2(hoaDon.IdHoaDon);
            }

            await LogHistory(hoaDon, $"{previousState}", reason);

            await _hoaDonService.UpdateAsync(hoaDon);

            return RedirectToAction("Edit", new { id });
        }

        private async Task LogHistory(HoaDon hoaDon, string thaoTac, string reason)
        {
            await _lichSuHoaDonService.AddAsync(new LichSuHoaDon
            {
                IdHoaDon = hoaDon.IdHoaDon,
                ThaoTac = thaoTac,
                NgayTao = DateTime.Now,
                NguoiThaoTac = "Nhân Viên",
                TrangThai = hoaDon.TrangThai,
                GhiChu = reason 
            });
        }
        private async Task UpdateProductQuantities(Guid idHoaDon)
        {
            var hoaDonChiTietList = await _hoaDonChiTietService.GetByIdHoaDonAsync(idHoaDon);
            foreach (var chiTiet in hoaDonChiTietList)
            {
                var sanPhamCT = await _sanPhamCTService.GetSanPhamChiTietById(chiTiet.IdSanPhamChiTiet);
                if (sanPhamCT != null)
                {
                    sanPhamCT.SoLuong -= chiTiet.SoLuong; 
                    await _sanPhamCTService.Update(sanPhamCT); 
                }
            }
        }
        private async Task UpdateProductQuantities2(Guid idHoaDon)
        {
            var hoaDonChiTietList = await _hoaDonChiTietService.GetByIdHoaDonAsync(idHoaDon);
            foreach (var chiTiet in hoaDonChiTietList)
            {
                var sanPhamCT = await _sanPhamCTService.GetSanPhamChiTietById(chiTiet.IdSanPhamChiTiet);
                if (sanPhamCT != null)
                {
                    sanPhamCT.SoLuong += chiTiet.SoLuong;
                    await _sanPhamCTService.Update(sanPhamCT);
                }
            }
        }
        [HttpGet]
        public async Task<IActionResult> CreateLichSuThanhToan(Guid idHoaDon)
        {
            var hoaDon = await _hoaDonService.GetByIdAsync(idHoaDon); 
            var lichSuThanhToanViewModel = new HoaDonChiTietViewModel
            {
                IdHoaDon = idHoaDon,
                TongTien = hoaDon.TongTienDonHang,
            };
            return PartialView("CreateLichSuThanhToan", lichSuThanhToanViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> CreateLichSuThanhToan(LichSuThanhToanViewModel lichSuThanhToan)
        {
            string TenNv = HttpContext.Session.GetString("NhanVienName");
            var NVIdString = HttpContext.Session.GetString("IdNhanVien");

            if (string.IsNullOrEmpty(NVIdString) || !Guid.TryParse(NVIdString, out Guid NVID))
            {
                return Unauthorized(new { message = "Nhân viên không tồn tại trong phiên làm việc." });
            }
            if (ModelState.IsValid)
            {
                var lichSuThanhToanModel = new LichSuThanhToan
                {
                    IdLichSuThanhToan = Guid.NewGuid(),
                    SoTien = lichSuThanhToan.SoTien,
                    TienThua = lichSuThanhToan.TienThua,
                    NgayTao = DateTime.Now,
                    LoaiGiaoDich = "Thanh Toán",
                    Pttt = lichSuThanhToan.HinhThucThanhToan,
                    NguoiThaoTac = TenNv,
                    TrangThai =  "Đã thanh toán",
                    IdHoaDon = lichSuThanhToan.IdHoaDon,
                    IdNhanVien = NVID,
                };
               
                await _lichSuThanhToanService.AddAsync(lichSuThanhToanModel);

                var hoaDon = await _hoaDonService.GetByIdAsync(lichSuThanhToan.IdHoaDon);
                if (hoaDon != null)
                {
                    hoaDon.TrangThai = "Đã Thanh Toán"; 
                    await _hoaDonService.UpdateAsync(hoaDon); 

                    await _lichSuHoaDonService.AddAsync(new LichSuHoaDon
                    {
                        IdHoaDon = hoaDon.IdHoaDon,
                        ThaoTac = hoaDon.TrangThai,
                        NgayTao = DateTime.Now,
                        NguoiThaoTac = TenNv,
                        TrangThai = hoaDon.TrangThai
                    });
                }

                return RedirectToAction("Edit", new { id = lichSuThanhToan.IdHoaDon });
            }

            return PartialView("CreateLichSuThanhToan", lichSuThanhToan);
        }
    }
}
