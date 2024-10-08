using AppData.Model;
using APPMVC.IService;
using Microsoft.AspNetCore.Mvc;

namespace APPMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
	public class ThuongHieuController : Controller
	{
		public IThuongHieuService _service;
        public ThuongHieuController(IThuongHieuService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
		{
			var thuongHieus = await _service.GetAllThuongHieu();
			return View(thuongHieus);
		}
		public async Task<IActionResult> Details (Guid id)
		{
			var thuongHieu = await _service.GetIdThuongHieu(id);
			if(thuongHieu == null)
			{
				return NotFound();
			}
			return View(thuongHieu);
		}
		public IActionResult Create()
		{
			var th = new ThuongHieu()
			{
				IdThuongHieu = Guid.NewGuid(),
				KichHoat = 1, // Giá trị mặc định nếu cần
				NguoiTao = "Long", // Thiết lập người tạo
				NgayTao = DateTime.Now,// Thiết lập ngày tạo
				NgayCapNhat = DateTime.Now
			};
			return View(th);
		}
		[HttpPost]
		public async Task<IActionResult> Create(ThuongHieu th)
		{
			if (ModelState.IsValid)
			{
				await _service.CreateThuongHieu(th);
				return RedirectToAction("Index");
			}
			return View(th);
		}
		public async Task<IActionResult> Edit(Guid id)
		{
			var thuongHieu = await _service.GetIdThuongHieu(id);
			if(thuongHieu == null)
			{
				return NotFound();
			}
			return View(thuongHieu);
		}
        [HttpPost]
        [ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(Guid id, ThuongHieu th)
		{
			if(id != th.IdThuongHieu)
			{
				return BadRequest();
			}
			if(ModelState.IsValid)
			{
				await _service.UpdateThuongHieu(th);
				return RedirectToAction("Index");
			}
			return View(th);

		}
        public async Task<IActionResult> Delete(Guid id)
        {
            var danhmuc = await _service.GetIdThuongHieu(id);
            if (danhmuc == null)
            {
                return NotFound();
            }
            await _service.DeleteThuongHieu(id);
            return RedirectToAction("Index");


        }
    }
}
