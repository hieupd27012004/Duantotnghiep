using AppData.Model;
using APPMVC.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APPMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HinhAnhController : Controller
    {
        private readonly IServiceHinhAnh _services;

        public HinhAnhController(IServiceHinhAnh services)
        {
            _services = services;
        }

        public async Task<IActionResult> GetAll()
        {
            List<HinhAnh> hinhAnhs = await _services.GetHinhAnhs();
            return View(hinhAnhs);
        }

        public IActionResult Create()
        {
            var hinhAnh = new HinhAnh()
            {
                IdHinhAnh = Guid.NewGuid(),
                LoaiFileHinhAnh = "image/jpeg",
                DataHinhAnh = new byte[0],
                IdSanPhamChiTiet = Guid.NewGuid(),
                TrangThai = 1
            };
            return View(hinhAnh);
        }

        [HttpPost]
        public IActionResult Create(HinhAnh hinhAnh, IFormFile file)
        {
            if (file != null)
            {
                using (var ms = new MemoryStream())
                {
                    file.CopyTo(ms);
                    hinhAnh.DataHinhAnh = ms.ToArray();
                    hinhAnh.LoaiFileHinhAnh = file.ContentType;
                }
            }

            if (!ModelState.IsValid)
            {
                return View(hinhAnh);
            }

            _services.Create(hinhAnh);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Details(Guid id)
        {
            var hinhAnh = await _services.GetHinhAnhById(id);
            return View(hinhAnh);
        }

        public async Task<IActionResult> Edit(Guid id)
        {
            var hinhAnh = await _services.GetHinhAnhById(id);
            if (hinhAnh == null)
            {
                return NotFound();
            }
            return View(hinhAnh);
        }

        [HttpPost]
        public IActionResult Edit(HinhAnh hinhAnh)
        {
            if (!ModelState.IsValid)
            {
                return View(hinhAnh);
            }
            _services.Update(hinhAnh);
            return RedirectToAction("GetAll");
        }

        public ActionResult Delete(Guid id)
        {
            _services.Delete(id);
            return RedirectToAction("GetAll");
        }
    }
}
