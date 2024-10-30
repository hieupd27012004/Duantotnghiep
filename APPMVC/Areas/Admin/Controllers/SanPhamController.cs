using APPMVC.IService;
using Microsoft.AspNetCore.Mvc;
using AppData.Model;
using X.PagedList;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Xml.Linq;
using Microsoft.EntityFrameworkCore;
using AppData.ViewModel;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.AspNetCore.Cors.Infrastructure;

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
        private readonly IHinhAnhService _hinhAnhService;

        public SanPhamController(
            ISanPhamService sanPhamService,
            ISanPhamChiTietService sanPhamChiTietService,
            IDeGiayService deGiayService,
            IDanhMucService danhMucService,
            IThuongHieuService thuongHieuService,
            IChatLieuService chatLieuService,
            IKieuDangService kieuDangService,
            IMauSacService mauSacService,
            IKichCoService kichCoService,
            ISanPhamChiTietMauSacService sanPhamChiTietMauSacService,
            ISanPhamChiTietKichCoService sanPhamChiTietKichCoService,
            IHinhAnhService hinhAnhService)
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
            _hinhAnhService = hinhAnhService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll(string? name, int page = 1)
        {
            page = page < 1 ? 1 : page;
            int pageSize = 5;

            var sanPhams = await _sanPhamService.GetSanPhams(name);
            var sanPhamViewModels = new List<SanPhamViewModel>();

            foreach (var sanPham in sanPhams)
            {
                var sanPhamChiTietList = await _sanPhamCTService.GetSanPhamChiTietBySanPhamId(sanPham.IdSanPham);
                double totalQuantity = sanPhamChiTietList.Sum(s => s.SoLuong ?? 0);

                sanPhamViewModels.Add(new SanPhamViewModel
                {
                    SanPham = sanPham,
                    TotalQuantity = totalQuantity,
                    SanPhamChiTiet = sanPhamChiTietList
                });
            }

            var sortedSanPhamViewModels = sanPhamViewModels.OrderByDescending(s => s.SanPham.NgayTao).ToList();

            var pagedSanPhamViewModels = sortedSanPhamViewModels.ToPagedList(page, pageSize);
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

            var viewModel = new SanPhamViewModel
            {
                SanPham = sanPham,
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
                await _sanPhamService.Create(viewModel.SanPham);
                var idSanPham = viewModel.SanPham.IdSanPham;

                if (viewModel.Combinations == null || !viewModel.Combinations.Any())
                {
                    TempData["Error"] = "Không có tổ hợp nào được chọn.";
                    return View(viewModel);
                }

                foreach (var combination in viewModel.Combinations)
                {
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

                    await _sanPhamCTService.Create(sanPhamChiTiet);

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

                    if (combination.Files != null && combination.Files.Count > 0)
                    {
                        foreach (var file in combination.Files)
                        {
                            if (file.Length > 0)
                            {
                                var imageData = await ConvertFileToByteArray(file);
                                var hinhAnh = new HinhAnh
                                {
                                    IdHinhAnh = Guid.NewGuid(),
                                    LoaiFileHinhAnh = file.ContentType,
                                    DataHinhAnh = imageData,
                                    TrangThai = 1, // Ensure this is set correctly
                                    IdSanPhamChiTiet = sanPhamChiTiet.IdSanPhamChiTiet // Ensure this is not null
                                };

                                await _hinhAnhService.UploadAsync(hinhAnh);
                            }
                        }
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

        private async Task<byte[]> ConvertFileToByteArray(IFormFile file)
        {
            using (var memoryStream = new MemoryStream())
            {
                await file.CopyToAsync(memoryStream);
                return memoryStream.ToArray();
            }
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