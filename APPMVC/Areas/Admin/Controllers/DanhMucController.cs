using AppData.Model;
using APPMVC.IService;
using APPMVC.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APPMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DanhMucController : Controller
    {

        public IDanhMucService _service;
        public DanhMucController()
        {
            _service = new DanhMucService();
        }
        // GET: DanhMucController
        public async Task<IActionResult> GetAll()
        {
            List<DanhMuc> danhMuc = await _service.GetAllDanhMuc();
            return View(danhMuc);
        }

        // GET: DanhMucController/Details/5
        public async Task<ActionResult> Details(Guid id)
        {
            var danhMuc = await _service.GetIdDanhMuc(id);
            if(danhMuc == null)
            {
               return NotFound();
            }
            return View(danhMuc);
        }

        // GET: DanhMucController/Create
        public IActionResult Create()
        {
            DanhMuc dm = new DanhMuc() {
                IdDanhMuc = Guid.NewGuid(),
                TenDanhMuc = "HoangLong01",
                NgayCapNhat = DateTime.Now,
                NgayTao = DateTime.Now,              
            };
            return View(dm);
        }

        // POST: DanhMucController/Create
        [HttpPost]
        public async Task<IActionResult> Create(DanhMuc dm)
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values.SelectMany(v => v.Errors);
                foreach (var error in errors)
                {
                    Console.WriteLine(error.ErrorMessage); // Hoặc bạn có thể log lỗi để kiểm tra
                }
            }
            await _service.Create(dm);
            return RedirectToAction("GetAll");
            
            
        }

        // GET: DanhMucController/Edit/5
        public async Task<IActionResult> Edit(Guid id)
        {
            var danhMuc = await _service.GetIdDanhMuc(id);
            if(danhMuc == null)
            {
                return NotFound();
            }
            return View(danhMuc);
        }

        // POST: DanhMucController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, DanhMuc dm)
        {
           if(id != dm.IdDanhMuc)
            {
                return BadRequest();
            }
            if (ModelState.IsValid)
            {
                await _service.UpDate(dm);
                return RedirectToAction("GetAll");
            }
            return View(dm);
        }

        // GET: DanhMucController/Delete/5
        public async Task<IActionResult> Delete(Guid id)
        {
            var danhmuc = await _service.GetIdDanhMuc(id);
            if(danhmuc == null)
            {
                return NotFound();
            }    
            await _service.Delete(id);
            return RedirectToAction("GetAll");
            

        }
    }
}
