using AppData.Model;
using APPMVC.IService;
using Microsoft.AspNetCore.Mvc;

namespace APPMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class KhachHangController : Controller
    {
        private readonly IKhachHangService _service;
        public KhachHangController(IKhachHangService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
           var getAll = await _service.GetAllKhachHang();
            return View(getAll);
        }
        public IActionResult Create()
        {
            var kh = new KhachHang()
            {
                IdKhachHang = Guid.NewGuid(),
                AuthProvider = "tạm trống",
                NgayTao = DateTime.Now,
                NgayCapNhat = DateTime.Now,
                NguoiTao = "Tự tạo",
                NguoiCapNhat = "Trôngs",
                KichHoat = 1
            };
            return View(kh);
        }
        [HttpPost]
        public async Task<IActionResult> Create(KhachHang kh)
        {
            if (ModelState.IsValid)
            {
                await _service.AddKhachHang(kh);
                return RedirectToAction("Index");
            }
            return View(kh);
        }
    }
}
