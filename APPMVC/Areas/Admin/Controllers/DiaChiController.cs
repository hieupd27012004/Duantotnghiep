using AppData.Model;
using AppData.ViewModel;
using APPMVC.IService;
using Castle.Core.Resource;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using X.PagedList;

namespace APPMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DiaChiController : Controller
    {
        public IDiaChiService _services;
        public IKhachHangService _serviceKH;
        public DiaChiController(IDiaChiService services, IKhachHangService serviceKH)
        {
            _services = services;
            _serviceKH = serviceKH;
        }

        [HttpGet]
        public async Task<IActionResult> Getall(string? name, int page = 1)
        {
            page = page < 1 ? 1 : page;
            int pageSize = 5;

            List<DiaChi> diaChis = await _services.GetDiaChi(name);
            List<KhachHang> customers = await _serviceKH.GetAllKhachHang();

            List<DiaChiViewModel> viewModels;

            if (diaChis != null && diaChis.Any())
            {
                viewModels = diaChis.Select(address => new DiaChiViewModel
                {
                    IdDiaChi = address.IdDiaChi, // Assuming this property exists
                    HoTen = address.HoTen, // Assuming this property exists
                    SoDienThoai = address.SoDienThoai, // Assuming this property exists
                    Diachi = address.Diachi, // Assuming this property exists
                    DiaChiMacDinh = address.DiaChiMacDinh, // Assuming this property exists
                    NgayTao = address.NgayTao, // Assuming this property exists
                    NgayCapNhat = address.NgayCapNhat, // Assuming this property exists
                    CustomerName = customers.FirstOrDefault(c => c.IdKhachHang == address.IdKhachHang)?.HoTen
                }).ToList();
            }
            else
            {
                List<DiaChi> allDiaChis = await _services.GetDiaChi(null);
                viewModels = allDiaChis.Select(address => new DiaChiViewModel
                {
                    IdDiaChi = address.IdDiaChi, // Assuming this property exists
                    HoTen = address.HoTen, // Assuming this property exists
                    SoDienThoai = address.SoDienThoai, // Assuming this property exists
                    Diachi = address.Diachi, // Assuming this property exists
                    DiaChiMacDinh = address.DiaChiMacDinh, // Assuming this property exists
                    NgayTao = address.NgayTao, // Assuming this property exists
                    NgayCapNhat = address.NgayCapNhat, // Assuming this property exists
                    CustomerName = customers.FirstOrDefault(c => c.IdKhachHang == address.IdKhachHang)?.HoTen
                }).ToList();
            }

            var pagedDCs = viewModels.ToPagedList(page, pageSize);
            return View(pagedDCs);
        }
        public async Task<IActionResult> Create()
        {
            var khachHang = await _serviceKH.GetAllKhachHang();
            ViewBag.KhachHang = khachHang;
            DiaChi nv = new DiaChi()
            {
                IdDiaChi = Guid.NewGuid(),
                NgayCapNhat = DateTime.Now,
                NgayTao = DateTime.Now,

            };
            return View(nv);
        }
        [HttpPost]
        public async Task<IActionResult> Create(DiaChi dc)
        {
            if (ModelState.IsValid)
            {
                await _services.Create(dc);
                return RedirectToAction("Getall");
            }
            return View(dc);    

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
        public async Task<IActionResult> Edit(Guid id)
        {
            var khachHang = await _serviceKH.GetAllKhachHang();
            ViewBag.KhachHang = khachHang;
            var diaChi = await _services.GetDiaChiById(id);
            if (diaChi == null)
            {
                return NotFound();
            }

            return View(diaChi);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(DiaChi dc)
        {
            if (ModelState.IsValid)
            {
                // Gọi service để cập nhật địa chỉ
                await _services.Update(dc);

                return RedirectToAction("Getall");
            }

            // Nếu ModelState không hợp lệ, trả về view với dữ liệu hiện tại
            var khachHang = await _serviceKH.GetAllKhachHang();
            ViewBag.KhachHang = khachHang;

            return View(dc);
        }
        public async Task<IActionResult> Delete(Guid id)
        {
            try
            {
                var diaChi = await _services.GetDiaChiById(id);

                if (diaChi == null)
                {
                    return NotFound($"Địa chỉ với ID {id} không tồn tại.");
                }

                // Thực hiện xóa địa chỉ
                await _services.Delete(id);

                // Sau khi xóa thành công, điều hướng về trang danh sách
                return RedirectToAction("Getall");
            }
            catch (Exception ex)
            {
                // Trả về thông báo lỗi nếu có vấn đề xảy ra trong quá trình xóa
                return StatusCode(500, $"Đã xảy ra lỗi trong quá trình xóa: {ex.Message}");
            }
        }
    }
}
