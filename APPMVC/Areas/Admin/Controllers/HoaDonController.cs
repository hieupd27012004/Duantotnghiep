using AppData.Model;
using APPMVC.IService;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

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

        public HoaDonController(ISanPhamChiTietService sanPhamChiTietService, ISanPhamService sanPhamService, IKhachHangService khachHangService, IHoaDonChiTietService hoaDonChiTietService , IHoaDonService hoaDonService , INhanVienService nhanVienService)
        {
            _sanPhamCTService = sanPhamChiTietService;
            _sanPhamService = sanPhamService;
            _khachHangService = khachHangService ;
            _hoaDonChiTietService = hoaDonChiTietService;
            _hoaDonService = hoaDonService;
            _nhanVienService = nhanVienService;
        }
        public async Task<ActionResult> Index(int page = 1)
        {
            // Đảm bảo page không nhỏ hơn 1
            page = page < 1 ? 1 : page;
            int pageSize = 5;

            // Lấy danh sách hóa đơn từ dịch vụ
            List<HoaDon> hoaDons = await _hoaDonService.GetAllAsync();

            // Kiểm tra nếu hoaDons là null hoặc rỗng
            if (hoaDons == null || !hoaDons.Any())
            {
                // Trả về view với một danh sách rỗng hoặc thông báo
                return View(new List<HoaDon>());
            }

            // Phân trang
            var pagedHoaDons = hoaDons.ToPagedList(page, pageSize);

            return View(pagedHoaDons);
        }
        public async Task<ActionResult> Edit(Guid id)
        {
            var hoaDonChiTiet = await _hoaDonChiTietService.GetByIdAsync(id);
            if (hoaDonChiTiet == null)
            {
                return NotFound($"Hóa đơn chi tiết với ID {id} không tồn tại.");
            }
            return View(hoaDonChiTiet);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(HoaDonChiTiet hoaDonChiTiet)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _hoaDonChiTietService.UpdateAsync(hoaDonChiTiet);
                    TempData["Success"] = "Cập nhật thành công!";
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    TempData["Error"] = $"Lỗi: {ex.Message}";
                }
            }
            return View(hoaDonChiTiet);
        }
    }
}
