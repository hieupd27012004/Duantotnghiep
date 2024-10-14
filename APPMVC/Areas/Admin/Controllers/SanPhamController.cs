using APPMVC.IService;
using Microsoft.AspNetCore.Mvc;
using AppData.Model;
using X.PagedList;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Xml.Linq;
using Microsoft.EntityFrameworkCore;

namespace APPMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SanPhamController : Controller
    {
        public ISanPhamChiTietService _SanphamCTService;
        public ISanPhamService _SanphamService;
        public IDeGiayService _DeGiayService;
        public IDanhMucService _DanhMucService;
        public IThuongHieuService _IThuongHieuService;
        public IChatLieuService _ChatLieuService;
        public IKieuDangService _KieuDangService;
        public IMauSacService _MauSacService;
        public IKichCoService _KichCoService;

        public SanPhamController(ISanPhamService sanPhamService, ISanPhamChiTietService sanPhamChiTietService, IDeGiayService deGiayService, IDanhMucService danhMucService, IThuongHieuService thuongHieuService, IChatLieuService chatLieuService, IKieuDangService kieuDangService, IMauSacService mauSacService,
        IKichCoService kichCoService)
        {
            _SanphamCTService = sanPhamChiTietService;
            _SanphamService = sanPhamService;
            _DeGiayService = deGiayService;
            _DanhMucService = danhMucService;
            _IThuongHieuService = thuongHieuService;
            _ChatLieuService = chatLieuService;
            _KieuDangService = kieuDangService;
            _MauSacService = mauSacService;
            _KichCoService = kichCoService;
        }
        [HttpGet]
        public async Task<IActionResult> Getall(string? name, int page = 1)
        {
            page = page < 1 ? 1 : page;
            int pageSize = 5;
            List<SanPham> timten = await _SanphamService.GetSanPhams(name);
            if (timten != null)
            {
                var pagedSanPhams = timten.ToPagedList(page, pageSize);
                return View(pagedSanPhams);
            }
            else
            {
                List<SanPham> sanPhams = await _SanphamService.GetSanPhams(name);
                var pagedSanPhams = sanPhams.ToPagedList(page, pageSize);
                return View(pagedSanPhams);
            }
        }


        public async Task<IActionResult> Create()
        {
            var ListChatLieu = await _ChatLieuService.GetChatLieu(null);
            var ListDeGiay = await _DeGiayService.GetDeGiay(null);
            var ListDanhMuc = await _DanhMucService.GetDanhMuc(null);
            var ListThuongHieu = await _IThuongHieuService.GetThuongHieu(null);
            var ListKieuDang = await _KieuDangService.GetKieuDang(null);
            var ListMauSac = await _MauSacService.GetMauSac(null);
            var ListKichCo = await _KichCoService.GetKichCo(null);

            var sanPham = new SanPham()
            {
                IdSanPham = Guid.NewGuid(),
                NgayTao = DateTime.Now,
                NgayCapNhat = DateTime.Now,
                NguoiTao = "Admin",
                NguoiCapNhat = "Admin",
                KichHoat = 1
            };

            var sanPhamChiTiet = new SanPhamChiTiet()
            {
                IdSanPham = Guid.NewGuid(),
                Gia = 0,
                SoLuong = 0,
                NgayCapNhat = DateTime.Now,
                NgayTao = DateTime.Now,
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                GioiTinh = "adv",
                KichHoat = 1,
            };

            // Tạo danh sách các lựa chọn cho các trường
            ViewBag.IdChatLieu = new SelectList(ListChatLieu, "IdChatLieu", "TenChatLieu");
            ViewBag.IdDeGiay = new SelectList(ListDeGiay, "IdDeGiay", "TenDeGiay");
            ViewBag.IdDanhMuc = new SelectList(ListDanhMuc, "IdDanhMuc", "TenDanhMuc");
            ViewBag.IdThuongHieu = new SelectList(ListThuongHieu, "IdThuongHieu", "TenThuongHieu");
            ViewBag.IdKieuDang = new SelectList(ListKieuDang, "IdKieuDang", "TenKieuDang");
            ViewBag.IdKichCo = new SelectList(ListKichCo, "IdKichCo", "TenKichCo");
            ViewBag.IdMauSac = new SelectList(ListMauSac, "IdMauSac", "TenMauSac");

            return View(new Tuple<SanPham, SanPhamChiTiet>(sanPham, sanPhamChiTiet));
        }

        [HttpPost]
        public async Task<IActionResult> Create(SanPham sanPham, SanPhamChiTiet sanPhamChiTiet)
        {
            if (!ModelState.IsValid)
            {
                // Log validation errors
                foreach (var modelState in ModelState.Values)
                {
                    foreach (var error in modelState.Errors)
                    {
                        // Log error (consider using a logging framework)
                        Console.WriteLine(error.ErrorMessage);
                    }
                }
                TempData["Error"] = "Dữ liệu không hợp lệ.";
                return RedirectToAction("Getall");
            }

            try
            {
                await _SanphamService.Create(sanPham);
                sanPhamChiTiet.IdSanPham = sanPham.IdSanPham;
                await _SanphamCTService.Create(sanPhamChiTiet);
                TempData["Success"] = "Thêm mới thành công";
            }
            catch (Exception ex)
            {
                // Log the exception
                Console.WriteLine($"Error: {ex.Message}");
                TempData["Error"] = "Thêm mới thất bại: " + ex.Message; // Optionally include the error message
            }
            return RedirectToAction("Getall");
        }
    }
}
