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
        private readonly ISanPhamChiTietService _sanPhamCTService;
        private readonly ISanPhamService _sanPhamService;
        private readonly IChatLieuService _chatLieuService;
        private readonly IDeGiayService _deGiayService;
        private readonly IDanhMucService _danhMucService;
        private readonly IThuongHieuService _thuongHieuService;
        private readonly IKieuDangService _kieuDangService;
        private readonly IMauSacService _mauSacService;
        private readonly IKichCoService _kichCoService;
        private readonly ISanPhamChiTietMauSacService _sanPhamChiTietMauSacService;
        private readonly ISanPhamChiTietKichCoService _sanPhamChiTietKichCoService;

        public SanPhamController(ISanPhamService sanPhamService,
                                 ISanPhamChiTietService sanPhamChiTietService,
                                 IDeGiayService deGiayService,
                                 IDanhMucService danhMucService,
                                 IThuongHieuService thuongHieuService,
                                 IChatLieuService chatLieuService,
                                 IKieuDangService kieuDangService,
                                 IMauSacService mauSacService,
                                 IKichCoService kichCoService,
                                 ISanPhamChiTietMauSacService sanPhamChiTietMauSacService,
                                 ISanPhamChiTietKichCoService sanPhamChiTietKichCoService)
        {
            _sanPhamCTService = sanPhamChiTietService;
            _sanPhamService = sanPhamService;
            _deGiayService = deGiayService;
            _danhMucService = danhMucService;
            _thuongHieuService = thuongHieuService;
            _chatLieuService = chatLieuService;
            _kieuDangService = kieuDangService;
            _mauSacService = mauSacService;
            _kichCoService = kichCoService;
            _sanPhamChiTietMauSacService = sanPhamChiTietMauSacService;
            _sanPhamChiTietKichCoService = sanPhamChiTietKichCoService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll(string? name, int page = 1)
        {
            page = page < 1 ? 1 : page;
            int pageSize = 5;

            // Fetch all products based on the name filter
            var sanPhams = await _sanPhamService.GetSanPhams(name);
            var sanPhamViewModels = new List<SanPhamViewModel>();

            foreach (var sanPham in sanPhams)
            {
                // Fetch product details for the current product
                var sanPhamChiTietList = await _sanPhamCTService.GetSanPhamChiTietBySanPhamId(sanPham.IdSanPham);

                // Calculate total quantity for this specific product
                double totalQuantity = sanPhamChiTietList.Sum(s => s.SoLuong ?? 0); // Assuming SoLuong is the property holding the quantity

                sanPhamViewModels.Add(new SanPhamViewModel
                {
                    SanPham = sanPham,
                    TotalQuantity = totalQuantity, // Set the total quantity
                    SanPhamChiTiet = sanPhamChiTietList // Directly assign the list
                });
            }

            var pagedSanPhamViewModels = sanPhamViewModels.ToPagedList(page, pageSize);
            return View(pagedSanPhamViewModels);
        }
        public async Task<IActionResult> Create()
        {
            await LoadViewBags();
            var sanPham = new SanPham
            {
                IdSanPham = Guid.NewGuid(),
                NgayTao = DateTime.Now,
                NgayCapNhat = DateTime.Now,
                NguoiTao = "Admin",
                NguoiCapNhat = "Admin",
                KichHoat = 1
            };

            var sanPhamChiTiet = new List<SanPhamChiTiet>
            {
            };

            var viewModel = new SanPhamViewModel
            {
                SanPham = sanPham,
                SanPhamChiTiet = sanPhamChiTiet,
                KichCoOptions = await GetKichCoOptions() ?? new List<SelectListItem>(),
                MauSacOptions = await GetMauSacOptions() ?? new List<SelectListItem>()
            };

            return View(viewModel);
        }

        private async Task<List<SelectListItem>> GetKichCoOptions()
        {
            var kichCos = await _kichCoService.GetKichCo(null) ?? new List<KichCo>();
            return kichCos.Select(k => new SelectListItem
            {
                Value = k.IdKichCo.ToString(),
                Text = k.TenKichCo
            }).ToList();
        }

        private async Task<List<SelectListItem>> GetMauSacOptions()
        {
            var mauSacs = await _mauSacService.GetMauSac(null) ?? new List<MauSac>();
            return mauSacs.Select(m => new SelectListItem
            {
                Value = m.IdMauSac.ToString(),
                Text = m.TenMauSac
            }).ToList();
        }

        [HttpPost]
        public async Task<IActionResult> Create(SanPhamViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                await LoadViewBags();
                return View(viewModel);
            }

            try
            {
                // Create the main product
                await _sanPhamService.Create(viewModel.SanPham);
                var idSanPham = viewModel.SanPham.IdSanPham;

                // Create combinations
                foreach (var combination in viewModel.Combinations)
                {
                    combination.Gia = combination.Gia > 0 ? combination.Gia : 100000; // Default price
                    combination.SoLuong = combination.SoLuong > 0 ? combination.SoLuong : 10; // Default quantity
                    combination.XuatXu = string.IsNullOrEmpty(combination.XuatXu) ? "Việt Nam" : combination.XuatXu; // Default origin

                    var sanPhamChiTiet = new SanPhamChiTiet
                    {
                        IdSanPhamChiTiet = Guid.NewGuid(),
                        IdSanPham = idSanPham,
                        Gia = combination.Gia,
                        SoLuong = combination.SoLuong,
                        XuatXu = combination.XuatXu,
                        GioiTinh = "Nam",
                        NgayTao = DateTime.Now,
                        NgayCapNhat = DateTime.Now,
                        NguoiTao = "Admin",
                        NguoiCapNhat = "Admin",
                        KichHoat = 1
                    };

                    // Save the new SanPhamChiTiet to the database
                    await _sanPhamCTService.Create(sanPhamChiTiet);

                    // Create relationships for sizes and colors
                    foreach (var kichCoId in viewModel.SelectedKichCoIds)
                    {
                        await _sanPhamChiTietKichCoService.Create(new SanPhamChiTietKichCo
                        {
                            IdSanPhamChiTiet = sanPhamChiTiet.IdSanPhamChiTiet,
                            IdKichCo = Guid.Parse(kichCoId)
                        });
                    }

                    foreach (var mauSacId in viewModel.SelectedMauSacIds)
                    {
                        await _sanPhamChiTietMauSacService.Create(new SanPhamChiTietMauSac
                        {
                            IdSanPhamChiTiet = sanPhamChiTiet.IdSanPhamChiTiet,
                            IdMauSac = Guid.Parse(mauSacId)
                        });
                    }
                }

                TempData["Success"] = "Thêm mới thành công";
                return RedirectToAction("GetAll");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                TempData["Error"] = "Thêm mới thất bại: " + ex.Message;
            }

            await LoadViewBags();
            return View(viewModel);
        }

        private async Task LoadViewBags()
        {
            var listChatLieu = await _chatLieuService.GetChatLieu(null);
            var listDeGiay = await _deGiayService.GetDeGiay(null);
            var listDanhMuc = await _danhMucService.GetDanhMuc(null);
            var listThuongHieu = await _thuongHieuService.GetThuongHieu(null);
            var listKieuDang = await _kieuDangService.GetKieuDang(null);
            var listMauSac = await _mauSacService.GetMauSac(null);
            var listKichCo = await _kichCoService.GetKichCo(null);

            ViewBag.IdChatLieu = new SelectList(listChatLieu, "IdChatLieu", "TenChatLieu");
            ViewBag.IdDeGiay = new SelectList(listDeGiay, "IdDeGiay", "TenDeGiay");
            ViewBag.IdDanhMuc = new SelectList(listDanhMuc, "IdDanhMuc", "TenDanhMuc");
            ViewBag.IdThuongHieu = new SelectList(listThuongHieu, "IdThuongHieu", "TenThuongHieu");
            ViewBag.IdKieuDang = new SelectList(listKieuDang, "IdKieuDang", "TenKieuDang");
            ViewBag.IdKichCo = new SelectList(listKichCo, "IdKichCo", "TenKichCo");
            ViewBag.IdMauSac = new SelectList(listMauSac, "IdMauSac", "TenMauSac");
        }
    }
}