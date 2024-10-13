using APPMVC.IService;
using Microsoft.AspNetCore.Mvc;
using AppData.Model;
using X.PagedList;

namespace APPMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SanPhamController : Controller
    {
        public ISanPhamChiTietService _SanphamCTService;
        public ISanPhamService _SanphamService;
        public SanPhamController(ISanPhamService sanPhamService, ISanPhamChiTietService sanPhamChiTietService)
        {
            _SanphamCTService = sanPhamChiTietService;
            _SanphamService = sanPhamService;
        }
        public async Task<IActionResult> Getall(string? name, int page = 1)
        {
            page = page < 1 ? 1 : page;
            int pageSize = 5;
            List<SanPham> timten = await _SanphamService.GetSanPhams(name);
            if (timten != null)
            {
                var pagedSanPhams = timten.ToPagedList(page, pageSize);
                return View(pagedSanPhams);
            }
            else
            {
                List<SanPham> sanPhams = await _SanphamService.GetSanPhams(name);
                var pagedSanPhams = sanPhams.ToPagedList(page, pageSize);
                return View(pagedSanPhams);
            }
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(SanPham sanPham)
        {
            if (!ModelState.IsValid)
            {
                // Kiểm tra tính hợp lệ của dữ liệu
                if (ModelState.ContainsKey("TenSanPham"))
                {
                    var error = ModelState["TenSanPham"].Errors.FirstOrDefault();
                    if (error != null)
                    {
                        TempData["Error"] = error.ErrorMessage;
                    }
                }
                return RedirectToAction("Getall");
            }
            try
            {
                await _SanphamService.Create(sanPham);
                TempData["Success"] = "Thêm mới thành công";
            }
            catch (Exception)
            {
                TempData["Error"] = "Thêm mới thất bại";
            }
            return RedirectToAction("Getall");
        }

    }
}
