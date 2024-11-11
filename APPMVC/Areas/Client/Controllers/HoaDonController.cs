using APPMVC.IService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APPMVC.Areas.Client.Controllers
{
    [Area("Client")]
    public class HoaDonController : Controller
    {
        public IHoaDonService _hoaDonService;
        public HoaDonController(IHoaDonService hoaDonService) 
        {
        _hoaDonService = hoaDonService;
        }
        public async Task<IActionResult> Index()
        {
            var hoaDons = await _hoaDonService.GetAllAsync();
            return View(hoaDons);
        }
        public async Task<IActionResult> Details()
        {
            var hoaDons = await _hoaDonService.GetAllAsync();
            return View(hoaDons);
        }
    }
}
