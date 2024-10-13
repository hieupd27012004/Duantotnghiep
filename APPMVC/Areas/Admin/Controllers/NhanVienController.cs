using AppData.Model;
using APPMVC.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace APPMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class NhanVienController : Controller
    {
        private readonly INhanVienService _service;
        private readonly IChucVuService chucVuService;
        public NhanVienController(INhanVienService service, IChucVuService _cvser)
        {
            _service = service;
            chucVuService = _cvser;
        }
        // GET: NhanVienController
        public async Task<IActionResult> Index()
        {
            var nhanVien = await _service.GetAllNhaVien();
            return View(nhanVien);
        }

        // GET: NhanVienController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: NhanVienController/Create
        public async Task<IActionResult> Create()
        {
            var chucVuList = await chucVuService.GetAllChucVu();
            ViewBag.ChucVu = chucVuList;
            NhanVien nv = new NhanVien() 
            { 
                IdNhanVien = Guid.NewGuid(),
                AuthProvider = "Trống",
                NgayCapNhat = DateTime.Now,
                NgayTao = DateTime.Now,
               
            };
            return View(nv);
        }

        // POST: NhanVienController/Create
        [HttpPost]
        //public async Task<IActionResult> Create(NhanVien nhanVien)
        //{

        //    if (!ModelState.IsValid)
        //    {
        //        return View(nhanVien);
        //    }

        //    // Kiểm tra thông tin đầu vào
        //    System.Diagnostics.Debug.WriteLine($"Nhân viên: {nhanVien.TenNhanVien}, Email: {nhanVien.Email}, IdChucVu: {nhanVien.IdchucVu}");

        //    // Lưu thông tin nhân viên
        //    await _service.CreateNV(nhanVien);
        //    return RedirectToAction("Index");
        //}
        public async Task<IActionResult> Create(NhanVien nhanVien, IFormFile imgFile)
        {
            // Kiểm tra xem có file ảnh được tải lên hay không
            if (imgFile != null && imgFile.Length > 0)
            {
                // Kiểm tra loại file (chỉ chấp nhận các định dạng ảnh)
                var permittedExtensions = new[] { ".jpg", ".jpeg", ".png", ".gif" };
                var ext = Path.GetExtension(imgFile.FileName).ToLowerInvariant();

                // Kiểm tra phần mở rộng có hợp lệ không
                if (!permittedExtensions.Contains(ext))
                {
                    ModelState.AddModelError("", "Chỉ chấp nhận các file ảnh với định dạng .jpg, .jpeg, .png, .gif.");
                    return View(nhanVien);
                }

                // Kiểm tra kích thước file (giới hạn 5MB)
                if (imgFile.Length > 5 * 1024 * 1024)
                {
                    ModelState.AddModelError("", "File ảnh phải nhỏ hơn 5MB.");
                    return View(nhanVien);
                }

                // Tạo đường dẫn đến thư mục lưu trữ hình ảnh
                string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Admin", "imgNV", imgFile.FileName);

                // Tạo file stream để lưu file hình ảnh
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    // Sao chép dữ liệu từ imgFile vào stream
                    await imgFile.CopyToAsync(stream);
                }

                // Gán tên file vào thuộc tính AnhNhanVien của đối tượng NhanVien
                nhanVien.AnhNhanVien = imgFile.FileName;
            }
            else
            {
                // Nếu không có file nào được tải lên, thêm lỗi vào ModelState
                ModelState.AddModelError("", "Vui lòng tải lên một file ảnh hợp lệ.");
                return View(nhanVien);
            }

            // Kiểm tra tính hợp lệ của ModelState trước khi lưu dữ liệu vào cơ sở dữ liệu
            if (!ModelState.IsValid)
            {
                // Trả về view hiện tại với model để hiển thị lại thông tin và thông báo lỗi
                return View(nhanVien);
            }

            // Nếu tất cả hợp lệ, lưu thông tin nhân viên
            await _service.CreateNV(nhanVien);
            return RedirectToAction("Index");
            //if (imgFile != null && imgFile.Length > 0)
            //{
            //    using (var memoryStream = new MemoryStream())
            //    {
            //        await imgFile.CopyToAsync(memoryStream);
            //        // Chuyển ảnh sang base64 string
            //        string base64String = Convert.ToBase64String(memoryStream.ToArray());
            //        nhanVien.AnhNhanVien = base64String;
            //    }
            //}

            //if (!ModelState.IsValid)
            //{
            //    return View(nhanVien);
            //}

            //// Lưu thông tin nhân viên
            //await _service.CreateNV(nhanVien);
            //return RedirectToAction("Index");

        }

        // GET: NhanVienController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: NhanVienController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: NhanVienController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: NhanVienController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult DangNhapThanhCong()
        {
            // Lấy dữ liệu từ Session
            var sessionData = HttpContext.Session.GetString("NhanVien");

            // Trả về view với dữ liệu từ Session
            return View((object)sessionData);
        }
        [HttpPost]
        public async Task<IActionResult> Login(NhanVien nv)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    // Thực hiện đăng nhập
                    var kh = await _service.LoginKH(nv.Email, nv.MatKhau);
                    if (kh != null)
                    {
                        // Lưu thông tin khách hàng vào session
                        HttpContext.Session.SetString("NhanVien", JsonConvert.SerializeObject(kh));
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
            return View(nv);
        }
    }
}
