using AppData.Model;
using APPMVC.Service;
using Microsoft.AspNetCore.Mvc;

namespace APPMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class KieuDangController : Controller
    {
        private readonly IServiceKieuDang _services;

        public KieuDangController(IServiceKieuDang services)
        {
            _services = services;
        }

        [HttpGet]
        public async Task<IActionResult> Getall()
        {
            List<KieuDang> kieuDangs = await _services.GetKieuDang();
            return View(kieuDangs);
        }

        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/KieuDang/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(KieuDang kieuDang)
        {
            if (ModelState.IsValid)
            {
                kieuDang.IdKieuDang = Guid.NewGuid();
                kieuDang.NgayTao = DateTime.Now;
                kieuDang.NgayCapNhat = DateTime.Now;
                await _services.Create(kieuDang);
                TempData["Success"] = "KieuDang created successfully.";
                return RedirectToAction(nameof(Getall));
            }
            return View(kieuDang);
        }

        [HttpGet]
        public async Task<IActionResult> Details(Guid id)
        {
            var kieuDang = await _services.GetKieuDangById(id);
            if (kieuDang == null)
            {
                return NotFound();
            }
            return View(kieuDang);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var kieuDang = await _services.GetKieuDangById(id);
            if (kieuDang == null)
            {
                return NotFound();
            }
            return View(kieuDang);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(KieuDang kieuDang)
        {
            if (!ModelState.IsValid)
            {
                return View(kieuDang);
            }
            try
            {
                var existingKieuDang = await _services.GetKieuDangById(kieuDang.IdKieuDang);
                if (existingKieuDang != null)
                {
                    kieuDang.NgayTao = existingKieuDang.NgayTao;
                    kieuDang.NgayCapNhat = DateTime.Now;
                    await _services.Update(kieuDang);
                    TempData["Success"] = "KieuDang updated successfully.";
                }
                else
                {
                    TempData["Error"] = "KieuDang not found.";
                }
                return RedirectToAction(nameof(Getall));
            }
            catch (Exception ex)
            {
                // Log the exception
                ModelState.AddModelError("", "An error occurred while updating the KieuDang.");
                return View(kieuDang);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(Guid id)
        {
            var kieuDang = await _services.GetKieuDangById(id);
            if (kieuDang != null)
            {
                await _services.Delete(id);
                TempData["Success"] = "KieuDang deleted successfully.";
            }
            else
            {
                TempData["Error"] = "KieuDang not found.";
            }
            return RedirectToAction(nameof(Getall));
        }
    }
}