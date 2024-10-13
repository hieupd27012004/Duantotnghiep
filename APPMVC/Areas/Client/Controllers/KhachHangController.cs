using AppData.Model;
using APPMVC.IService;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace APPMVC.Areas.Client.Controllers
{
    [Area("Client")]
    public class KhachHangController : Controller
    {
        
        private readonly IKhachHangService _service;
        public KhachHangController(IKhachHangService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {

            return View();
        }
      
        public IActionResult Register()
        {
            
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(KhachHang kh)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _service.AddKhachHang(kh);
                    return RedirectToAction("DangKyThanhCong");
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", ex.Message);
                }
            }
            else
            {
                // Lấy tất cả các lỗi trong ModelState
                var allErrors = ModelState.Values.SelectMany(v => v.Errors).ToList();

                // Ghi lại chi tiết lỗi ra màn hình console hoặc log
                foreach (var error in allErrors)
                {
                    if (!string.IsNullOrEmpty(error.ErrorMessage))
                    {
                        Console.WriteLine($"Error: {error.ErrorMessage}");
                    }

                    if (error.Exception != null)
                    {
                        Console.WriteLine($"Exception: {error.Exception.Message}");
                    }
                }

                // Thêm một thông báo lỗi chung cho người dùng (nếu cần)
                ModelState.AddModelError("", "Có lỗi xảy ra khi điền thông tin, vui lòng kiểm tra lại.");
            }

            return View(kh);
        }
        public IActionResult DangKyThanhCong()
        {
            return Content("OKroi");
        }
        public IActionResult DangNhapThanhCong()
        {
            // Lấy dữ liệu từ Session
            var sessionData = HttpContext.Session.GetString("KhachHang");

            // Trả về view với dữ liệu từ Session
            return View((object)sessionData);
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(KhachHang khach)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    // Thực hiện đăng nhập
                    var kh = await _service.LoginKH(khach.Email, khach.MatKhau);
                    if (kh != null)
                    {
                        // Lưu thông tin khách hàng vào session
                        HttpContext.Session.SetString("KhachHang", JsonConvert.SerializeObject(kh));
                        return RedirectToAction("DangNhapThanhCong");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Đăng nhập thất bại. Kiểm tra lại email hoặc mật khẩu.");
                    }
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", ex.Message);
                }
            }

            // Log các lỗi nếu ModelState.IsValid là false
            var errors = ModelState.Values.SelectMany(v => v.Errors);
            foreach (var error in errors)
            {
                Console.WriteLine(error.ErrorMessage); // Hoặc ghi log vào file
            }

            // Trả về lại view nếu có lỗi
            return View(khach);
        }
    }
}
