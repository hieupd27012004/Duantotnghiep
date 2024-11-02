using AppData.Model;
using APPMVC.IService;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using X.PagedList;

namespace APPMVC.Areas.Client.Controllers
{
    [Area("Client")]
    public class DiaChiController : Controller
    {
        public readonly IDiaChiService _services;
        public DiaChiController(IDiaChiService service)
        {
            _services = service; 
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
        public async Task<IActionResult> EditDiaChi(Guid id)
        {
            var diaChi = await _services.GetDiaChiById(id);
            if (diaChi == null)
            {
                return NotFound();
            }
            return View(diaChi);
        }
        [HttpPost]
        public async Task<IActionResult> EditDiaChi(Guid id,DiaChi diaChi)
        {
            if (!ModelState.IsValid)
            {
                foreach (var modelStateKey in ModelState.Keys)
                {
                    var value = ModelState[modelStateKey];
                    foreach (var error in value.Errors)
                    {
                        Console.WriteLine($"Key: {modelStateKey}, Error: {error.ErrorMessage}");
                    }
                }
                return BadRequest(ModelState);
            }

            var sessionData = HttpContext.Session.GetString("KhachHang");
            if (string.IsNullOrEmpty(sessionData))
            {
                return RedirectToAction("Login");
            }
            var khachHang = JsonConvert.DeserializeObject<KhachHang>(sessionData);

            try
            {
                await _services.UpdateDCbyIdKH(khachHang.IdKhachHang, diaChi);
                return RedirectToAction("DiaChi");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(diaChi);
            }
        }

    }
}
