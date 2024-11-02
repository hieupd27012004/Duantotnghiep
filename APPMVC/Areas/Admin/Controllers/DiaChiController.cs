using AppData.Model;
using APPMVC.IService;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using X.PagedList;

namespace APPMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DiaChiController : Controller
    {
        public IDiaChiService _services;
        public IKhachHangService _serviceKH;
        public DiaChiController(IDiaChiService services, IKhachHangService serviceKH)
        {
            _services = services;
            _serviceKH = serviceKH;
        }

        [HttpGet]
        public async Task<IActionResult> Getall(string? name, int page = 1)
        {
            page = page < 1 ? 1 : page;
            int pageSize = 5;
            List<DiaChi> timten = await _services.GetDiaChi(name);

            if (timten != null)
            {
                var pagedDCs = timten.ToPagedList(page, pageSize);
                return View(pagedDCs);
            }
            else
            {
                List<DiaChi> dc = await _services.GetDiaChi(name);
                var pagedDC = dc.ToPagedList(page, pageSize);
                return View(pagedDC);
            }
        }
        public async Task<IActionResult> Create()
        {
            var khachHang = await _serviceKH.GetAllKhachHang();
            ViewBag.KhachHang = khachHang;
            DiaChi nv = new DiaChi()
            {
                IdDiaChi = Guid.NewGuid(),
                NgayCapNhat = DateTime.Now,
                NgayTao = DateTime.Now,

            };
            return View(nv);
        }
        [HttpPost]
        public async Task<IActionResult> Create(DiaChi dc)
        {
            if (ModelState.IsValid)
            {
                await _services.Create(dc);
                return RedirectToAction("Getall");
            }
            return View(dc);    

        }
        public async Task<IActionResult> DiaChi()
        {
            var sessionData = HttpContext.Session.GetString("KhachHang");
            if (string.IsNullOrEmpty(sessionData))
            {
                return RedirectToAction("Login");
            }
            var khachHang = JsonConvert.DeserializeObject<KhachHang>(sessionData);
            var diaChiList = await _services.GetDiaChiByIdKH(khachHang.IdKhachHang);
            return View(diaChiList);
        }
        public async Task<IActionResult> Edit(Guid id)
        {
            var khachHang = await _serviceKH.GetAllKhachHang();
            ViewBag.KhachHang = khachHang;
            var diaChi = await _services.GetDiaChiById(id);
            if (diaChi == null)
            {
                return NotFound();
            }

            return View(diaChi);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(DiaChi dc)
        {
            if (ModelState.IsValid)
            {
                // Gọi service để cập nhật địa chỉ
                await _services.Update(dc);

                return RedirectToAction("Getall");
            }

            // Nếu ModelState không hợp lệ, trả về view với dữ liệu hiện tại
            var khachHang = await _serviceKH.GetAllKhachHang();
            ViewBag.KhachHang = khachHang;

            return View(dc);
        }
        public async Task<IActionResult> Delete(Guid id)
        {
            try
            {
                var diaChi = await _services.GetDiaChiById(id);

                if (diaChi == null)
                {
                    return NotFound($"Địa chỉ với ID {id} không tồn tại.");
                }

                // Thực hiện xóa địa chỉ
                await _services.Delete(id);

                // Sau khi xóa thành công, điều hướng về trang danh sách
                return RedirectToAction("Getall");
            }
            catch (Exception ex)
            {
                // Trả về thông báo lỗi nếu có vấn đề xảy ra trong quá trình xóa
                return StatusCode(500, $"Đã xảy ra lỗi trong quá trình xóa: {ex.Message}");
            }
        }
    }
}
