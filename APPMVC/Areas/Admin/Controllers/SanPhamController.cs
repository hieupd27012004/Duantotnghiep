using APPMVC.IService;
using Microsoft.AspNetCore.Mvc;
using AppData.Model;
using X.PagedList;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Xml.Linq;
using Microsoft.EntityFrameworkCore;
using AppData.ViewModel;

namespace APPMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SanPhamController : Controller
    {
        private readonly ISanPhamChiTietService _SanphamCTService;
        private readonly ISanPhamService _SanphamService;
        private readonly IChatLieuService _ChatLieuService;
        private readonly IDeGiayService _DeGiayService;
        private readonly IDanhMucService _DanhMucService;
        private readonly IThuongHieuService _IThuongHieuService;
        private readonly IKieuDangService _KieuDangService;
        private readonly IMauSacService _MauSacService;
        private readonly IKichCoService _KichCoService;

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

            // Lấy danh sách sản phẩm dựa theo tên
            List<SanPham> timten = await _SanphamService.GetSanPhams(name);

            if (timten != null)
            {
                // Tạo danh sách view model với thông tin chi tiết của sản phẩm
                var sanPhamViewModels = new List<SanPhamViewModel>();

                foreach (var sanPham in timten)
                {
                    // Lấy SanPhamChiTiet dựa vào IdSanPham
                    var sanPhamChiTiet = await _SanphamCTService.GetSanPhamChiTietBySanPhamId(sanPham.IdSanPham);

                    // Tạo đối tượng SanPhamViewModel
                    var viewModel = new SanPhamViewModel
                    {
                        SanPham = sanPham,
                        SanPhamChiTiet = sanPhamChiTiet ?? new SanPhamChiTiet() // Nếu không tìm thấy, tạo đối tượng trống
                    };

                    sanPhamViewModels.Add(viewModel);
                }

                // Phân trang
                var pagedSanPhamViewModels = sanPhamViewModels.ToPagedList(page, pageSize);
                return View(pagedSanPhamViewModels);
            }
            else
            {
                // Nếu không tìm thấy sản phẩm
                List<SanPham> sanPhams = await _SanphamService.GetSanPhams(name);
                var sanPhamViewModels = sanPhams.Select(sanPham => new SanPhamViewModel
                {
                    SanPham = sanPham,
                    SanPhamChiTiet = new SanPhamChiTiet()
                }).ToList();

                var pagedSanPhamViewModels = sanPhamViewModels.ToPagedList(page, pageSize);
                return View(pagedSanPhamViewModels);
            }
        }


        public async Task<IActionResult> Create()
        {
            await LoadViewBags();

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
                IdSanPhamChiTiet = Guid.NewGuid(),
                Gia = 100000,
                SoLuong = 100,
                NgayCapNhat = DateTime.Now,
                NgayTao = DateTime.Now,
                NguoiCapNhat = "Admin",
                NguoiTao = "Admin",
                GioiTinh = "Nam",
                KichHoat = 1,
            };

            var viewModel = new SanPhamViewModel
            {
                SanPham = sanPham,
                SanPhamChiTiet = sanPhamChiTiet
            };

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(SanPhamViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                // Ghi lại thông tin lỗi ModelState
                foreach (var modelState in ModelState.Values)
                {
                    foreach (var error in modelState.Errors)
                    {
                        Console.WriteLine(error.ErrorMessage);
                    }
                }
                TempData["Error"] = "Dữ liệu không hợp lệ.";
                await LoadViewBags(); // Gọi lại LoadViewBags
                return View(viewModel); // Trả về view với dữ liệu hiện tại
            }

            try
            {
                // Tạo SanPham
                await _SanphamService.Create(viewModel.SanPham);
                var idSanPham = viewModel.SanPham.IdSanPham;
                viewModel.SanPhamChiTiet.IdSanPham = idSanPham;

                // Tạo SanPhamChiTiet
                await _SanphamCTService.Create(viewModel.SanPhamChiTiet);
                TempData["Success"] = "Thêm mới thành công";
                return RedirectToAction("Getall");
            }
            catch (Exception ex)
            {
                // Ghi lại thông báo lỗi
                Console.WriteLine($"Error: {ex.Message}");
                TempData["Error"] = "Thêm mới thất bại: " + ex.Message;
            }


            await LoadViewBags(); // Load view bags again for the view
            return View(viewModel); // Return to the view with the current data
        }

        private async Task LoadViewBags()
        {
            var ListChatLieu = await _ChatLieuService.GetChatLieu(null);
            var ListDeGiay = await _DeGiayService.GetDeGiay(null);
            var ListDanhMuc = await _DanhMucService.GetDanhMuc(null);
            var ListThuongHieu = await _IThuongHieuService.GetThuongHieu(null);
            var ListKieuDang = await _KieuDangService.GetKieuDang(null);
            var ListMauSac = await _MauSacService.GetMauSac(null);
            var ListKichCo = await _KichCoService.GetKichCo(null);

            ViewBag.IdChatLieu = new SelectList(ListChatLieu, "IdChatLieu", "TenChatLieu");
            ViewBag.IdDeGiay = new SelectList(ListDeGiay, "IdDeGiay", "TenDeGiay");
            ViewBag.IdDanhMuc = new SelectList(ListDanhMuc, "IdDanhMuc", "TenDanhMuc");
            ViewBag.IdThuongHieu = new SelectList(ListThuongHieu, "IdThuongHieu", "TenThuongHieu");
            ViewBag.IdKieuDang = new SelectList(ListKieuDang, "IdKieuDang", "TenKieuDang");
            ViewBag.IdKichCo = new SelectList(ListKichCo, "IdKichCo", "TenKichCo");
            ViewBag.IdMauSac = new SelectList(ListMauSac, "IdMauSac", "TenMauSac");
        }
    }
}
