using AppData.Model;
using APPMVC.IService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using X.PagedList;

namespace APPMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MauSacController : Controller
    {
        public IMauSacService _services;

        public MauSacController(IMauSacService services)
        {
            _services = services;
        }

        [HttpGet]
        public async Task<IActionResult> Getall(string? name, int page = 1)
        {
            page = page < 1 ? 1 : page;
            int pageSize = 5;
            List<MauSac> timten = await _services.GetMauSac(name);
            if (timten != null)
            {
                var pagedMauSacs = timten.ToPagedList(page, pageSize);
                return View(pagedMauSacs);
            }
            else
            {
                List<MauSac> mauSacs = await _services.GetMauSac(name);
                var pagedMauSacs = mauSacs.ToPagedList(page, pageSize);
                return View(pagedMauSacs);
            }
        }

        public IActionResult Create()
        {
            return PartialView("Create");
        }

        [HttpPost]
        public async Task<IActionResult> Create(string TenMauSac)
        {
            try
            {
                // Kiểm tra dữ liệu đầu vào
                if (string.IsNullOrWhiteSpace(TenMauSac))
                {
                    return Json(new { success = false, message = "Tên màu không được để trống" });
                }

                var mauSac = new MauSac
                {
                    IdMauSac = Guid.NewGuid(),
                    TenMauSac = TenMauSac,
                    NgayTao = DateTime.Now,
                    NgayCapNhat = DateTime.Now,
                    NguoiTao = "Admin", // Lấy từ session
                    NguoiCapNhat = "Admin",
                    KichHoat = 1
                };

                await _services.Create(mauSac);

                return Json(new
                {
                    success = true,
                    id = mauSac.IdMauSac,
                    tenMauSac = mauSac.TenMauSac
                });
            }
            catch (Exception ex)
            {
                // Log lỗi nếu có
                return Json(new
                {
                    success = false,
                    message = "Có lỗi xảy ra: " + ex.Message
                });
            }
        }
        public async Task<IActionResult> Edit(Guid id)
        {
            var mauSac = await _services.GetMauSacById(id);
            if (mauSac == null)
            {
                return NotFound();
            }
            return View(mauSac);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(MauSac mauSac)
        {
            if (!ModelState.IsValid)
            {
                // Kiểm tra tính hợp lệ của dữ liệu
                if (ModelState.ContainsKey("TenMauSac"))
                {
                    var error = ModelState["TenMauSac"].Errors.FirstOrDefault();
                    if (error != null)
                    {
                        TempData["Error"] = error.ErrorMessage;
                    }
                }
                return View(mauSac);
            }
            try
            {
                await _services.Update(mauSac);
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
                await _services.Delete(id);
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
            var mauSac = await _services.GetMauSacById(id);
            if (mauSac == null)
            {
                return NotFound();
            }
            return View(mauSac);
        }
    }
}