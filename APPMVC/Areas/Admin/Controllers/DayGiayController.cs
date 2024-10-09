using AppData.Model;
using APPMVC.IService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace APPMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
	public class DayGiayController : Controller
	{
		public IDayGiayService _services;

		public DayGiayController(IDayGiayService services)
		{
			_services = services;
		}
        [HttpGet]

        public async Task<IActionResult> Getall(string? name )
        {
            List<DayGiay> timten = await _services.GetDayGiay(name);
            List<DayGiay> dayGiays = await _services.GetDayGiay(name);
            if (timten != null)
            {
                return View(timten);
            }
            else
            {
                return View(dayGiays); 
            }
        }
        public IActionResult Create()
        {
            return PartialView("Create");   
        }
        [HttpPost]
        public async Task<IActionResult> Create(DayGiay dayGiay)
        {
            if (!ModelState.IsValid)
            {
                if (!ModelState.IsValid)
                {
                    TempData["Error"] = "Thêm mới thất bại";
                    return RedirectToAction("Getall");
                }
            }
            try
            {
                await _services.Create(dayGiay);
                TempData["Success"] = "Thêm mới thành công";
            }
            catch (Exception)
            {
                TempData["Error"] = "Thêm mới thất bại";
            }
            return RedirectToAction("Getall");
        }
        public async Task<IActionResult> Edit(Guid id)
        {
            var dayGiay = await _services.GetDayGiayById(id);
            if (dayGiay == null)
            {
                return NotFound();
            }
            return View(dayGiay);
        }
        [HttpPost]
        public  async Task<ActionResult> Edit(DayGiay dayGiay)
        {
            if (!ModelState.IsValid)
            {
                return View(dayGiay);
            }
            try
            {
                await _services.Update(dayGiay);
                TempData["Success"] = "Cập nhật thành công";
            }
            catch (Exception)
            {
                TempData["Error"] = "Cập nhật thất bại";
            }
            return RedirectToAction("Getall");
        }

        public async Task<ActionResult> Delete(Guid id)
        {
            try
            {
                await   _services.Delete(id);
                TempData["Success"] = "Xóa thành công";
            }
            catch (Exception)
            {
                TempData["Error"] = "Xóa thất bại";
            }
            return RedirectToAction("Getall");
        }
        public async Task<IActionResult> Details(Guid id)
        {
            var dayGiay = await _services.GetDayGiayById(id);
            if (dayGiay == null)
            {
                return NotFound();
            }
            return View(dayGiay);
        }
    }

}

