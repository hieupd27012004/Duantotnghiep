using Microsoft.AspNetCore.Mvc;
using APPMVC.IService;
using AppData.Model;
using System;
using System.Threading.Tasks;

namespace APPMVC.Controllers
{
    public class HinhAnhController : Controller
    {
        private readonly IHinhAnhService _hinhAnhService;

        public HinhAnhController(IHinhAnhService hinhAnhService)
        {
            _hinhAnhService = hinhAnhService;
        }

        public async Task<IActionResult> Index()
        {
            var hinhAnhs = await _hinhAnhService.GetHinhAnhsAsync();
            return View(hinhAnhs);
        }

        public IActionResult Upload()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Upload(IFormFile file, Guid idSanPhamChiTiet)
        {
            if (file != null && file.Length > 0)
            {
                using (var memoryStream = new MemoryStream())
                {
                    await file.CopyToAsync(memoryStream);

                    var hinhAnh = new HinhAnh
                    {
                        IdSanPhamChiTiet = idSanPhamChiTiet,
                        LoaiFileHinhAnh = file.ContentType,
                        DataHinhAnh = memoryStream.ToArray()
                    };

                    var result = await _hinhAnhService.UploadAsync(hinhAnh);
                    if (result)
                    {
                        return RedirectToAction(nameof(Index));
                    }
                }
            }
            return View();
        }

        public async Task<IActionResult> Delete(Guid id)
        {
            var hinhAnh = await _hinhAnhService.GetHinhAnhByIdAsync(id);
            if (hinhAnh == null)
            {
                return NotFound();
            }
            return View(hinhAnh);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var result = await _hinhAnhService.DeleteAsync(id);
            if (result)
            {
                return RedirectToAction(nameof(Index));
            }
            return NotFound();
        }
    }
}