using AppData.Model;
using APPMVC.Service;
using Microsoft.AspNetCore.Mvc;

namespace APPMVC.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class DayGiayController : Controller
	{
		public IServicegiaygiay _services;

		public DayGiayController(IServicegiaygiay services)
		{
			_services = services;
		}

		public async Task<IActionResult> Getall()
		{
			List<DayGiay> dayGiays = await _services.GetDayGiay();
			return View(dayGiays);
		}
		public IActionResult Create()
		{
			var daygiay = new DayGiay()
			{
				IdDayGiay = Guid.NewGuid(),
				TenDayGiay = "hieudz",
				NgayCapNhat = DateTime.Now,
				NgayTao = DateTime.Now,
				

			};
			return View(daygiay);
		}
		[HttpPost]
		public IActionResult Create(DayGiay dayGiay)
		{
			if (!ModelState.IsValid)
			{
				return View(dayGiay);
			}
			_services.Create(dayGiay);
			return RedirectToAction("Getall");
		}
		[HttpGet]
		public async Task<IActionResult> Details(Guid id)
		{
			var dayGiay = await _services.GetDayGiayById(id);
			return View(dayGiay);
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
		public IActionResult Edit(DayGiay dayGiay)
		{
			if (!ModelState.IsValid)
			{
				return View(dayGiay);
			}
			_services.Update(dayGiay);
			return RedirectToAction("Getall");
		}

		public ActionResult Delete(Guid id)
		{

			_services.Delete(id);
			return RedirectToAction("Getall");
		}
	}

}

