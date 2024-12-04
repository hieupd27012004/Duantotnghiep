using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AppData;
using AppData.Model;
using APPMVC.IService;
using AppData.ViewModel;

namespace APPMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PromotionController : Controller
    {
        private readonly IPromotionService _promotionService;
        private readonly ILogger<PromotionController> _logger;
        private readonly ISanPhamService _sanPhamService;
        private readonly ISanPhamChiTietService _sanPhamChiTietService;
        private readonly IMauSacService _mauSacService;
        private readonly IKichCoService _kichCoService;
        private readonly ISanPhamChiTietMauSacService _sanPhamChiTietMauSacService;
        private readonly ISanPhamChiTietKichCoService _sanPhamChiTietKichCoService;
        private readonly IHinhAnhService _hinhAnhService;
        private readonly IChatLieuService _chatLieuService;
        private readonly IDeGiayService _deGiayService;
        private readonly IDanhMucService _danhMucService;
        private readonly IThuongHieuService _thuongHieuService;
        private readonly IKieuDangService _kieuDangService;

        public PromotionController(IPromotionService promotionService, ILogger<PromotionController> logger, ISanPhamService sanPhamService, ISanPhamChiTietService sanPhamChiTietService, IMauSacService mauSacService,IKichCoService kichCoService,ISanPhamChiTietMauSacService sanPhamChiTietMauSacService,ISanPhamChiTietKichCoService sanPhamChiTietKichCoService,IHinhAnhService hinhAnhService, IDeGiayService deGiayService,
            IDanhMucService danhMucService,
            IThuongHieuService thuongHieuService,
            IChatLieuService chatLieuService,
            IKieuDangService kieuDangService)
        {
            _promotionService = promotionService ?? throw new ArgumentNullException(nameof(promotionService));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _sanPhamService = sanPhamService;
            _sanPhamChiTietService = sanPhamChiTietService;
            _mauSacService = mauSacService;
            _kichCoService = kichCoService;
            _sanPhamChiTietMauSacService = sanPhamChiTietMauSacService;
            _sanPhamChiTietKichCoService = sanPhamChiTietKichCoService;
            _hinhAnhService = hinhAnhService;
            _deGiayService = deGiayService;
            _danhMucService = danhMucService;
            _thuongHieuService = thuongHieuService;
            _chatLieuService = chatLieuService;
            _kieuDangService = kieuDangService;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            try
            {
                List<Promotion> promotions = await _promotionService.GetPromotionsAsync();
                _logger.LogInformation($"Retrieved {promotions.Count} promotions");
                return View(promotions);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching promotion list");
                return View(new List<Promotion>());
            }
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var model = new PromotionViewModel
            {
                Promotion = new Promotion
                {
                    NgayKetThuc = DateTime.Now.AddHours(1)
                },
                SanPhams = await GetProducts(),
                NgayBatDau = DateTime.Now,
                NgayKetThuc = DateTime.Now.AddHours(1),
            };
            return View(model);
        }

        // POST: Admin/Promotion/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PromotionViewModel model)
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values.SelectMany(v => v.Errors);
                foreach (var error in errors)
                {
                    _logger.LogError(error.ErrorMessage);
                }
                model.SanPhams = await GetProducts();
                return View(model);
            }

            try
            {
                var promotion = model.Promotion;
                promotion.NgayBatDau = model.NgayBatDau;
                promotion.NgayKetThuc = model.Promotion.NgayKetThuc; 
                promotion.IdPromotion = Guid.NewGuid();
                promotion.NgayTao = DateTime.Now;

                promotion.PromotionSanPhamChiTiets = new List<PromotionSanPhamChiTiet>();

                foreach (var idSanPhamChiTiet in model.SelectedSanPhamChiTietIds)
                {
                    promotion.PromotionSanPhamChiTiets.Add(new PromotionSanPhamChiTiet
                    {
                        IdPromotion = promotion.IdPromotion,
                        IdSanPhamChiTiet = idSanPhamChiTiet
                    });
                }

                var result = await _promotionService.CreateAsync(promotion);
                if (result)
                {
                    _logger.LogInformation($"Successfully created promotion with Id: {promotion.IdPromotion}");
                    TempData["SuccessMessage"] = "Promotion created successfully.";
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    _logger.LogWarning($"Failed to create promotion with Id: {promotion.IdPromotion}");
                    ModelState.AddModelError("", "Failed to create the promotion. Please check server logs for details.");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Exception occurred during promotion creation");
                ModelState.AddModelError("", $"An error occurred: {ex.Message}");
            }

            model.SanPhams = await GetProducts();
            return View(model);
        }
        [HttpGet]
        private async Task<List<PromotionViewModel.SanPhamViewModel>> GetProducts()
        {
            var sanPhams = await _sanPhamService.GetSanPhams(null);
            var promotionSanPhams = new List<PromotionViewModel.SanPhamViewModel>();

            foreach (var sanPham in sanPhams)
            {
                var thuongHieu = await _thuongHieuService.GetThuongHieuById(sanPham.IdThuongHieu);
                var danhMuc = await _danhMucService.GetDanhMucById(sanPham.IdDanhMuc);
                var chatLieu = await _chatLieuService.GetChatLieuById(sanPham.IdChatLieu);
                var kieuDang = await _kieuDangService.GetKieuDangById(sanPham.IdKieuDang);
                var deGiay = await _deGiayService.GetDeGiayById(sanPham.IdDeGiay);

                var promotionSanPham = new PromotionViewModel.SanPhamViewModel
                {
                    IdSanPham = sanPham.IdSanPham,
                    TenSanPham = sanPham.TenSanPham,
                    ThuongHieu = thuongHieu?.TenThuongHieu,
                    DanhMuc = danhMuc?.TenDanhMuc,
                    ChatLieu = chatLieu?.TenChatLieu,
                    KieuDang = kieuDang?.TenKieuDang,
                    DeGiay = deGiay?.TenDeGiay
                };

                promotionSanPhams.Add(promotionSanPham);
            }

            return promotionSanPhams;
        }

        [HttpGet]
        public async Task<IActionResult> GetProductDetails(string sanPhamIds)
        {
            // Validate the input
            if (string.IsNullOrWhiteSpace(sanPhamIds))
            {
                return BadRequest("Invalid product IDs."); // Return 400 if the IDs are invalid
            }

            // Split the incoming IDs and parse them
            var idList = sanPhamIds.Split(',')
                                    .Select(id => Guid.TryParse(id.Trim(), out var parsedId) ? parsedId : Guid.Empty)
                                    .ToList();

            // Check for any invalid IDs
            if (idList.All(id => id == Guid.Empty))
            {
                return BadRequest("No valid product IDs provided."); // Return 400 if all IDs are invalid
            }

            var sanPhamChiTietViewModels = new List<PromotionViewModel.SanPhamChiTietViewModel>();

            foreach (var sanPhamId in idList)
            {
                if (sanPhamId == Guid.Empty) continue;

                // Fetch the product by ID
                var sanPham = await _sanPhamService.GetSanPhamById(sanPhamId);
                if (sanPham == null) continue;

                var sanPhamChiTietList = await _sanPhamChiTietService.GetSanPhamChiTietBySanPhamId(sanPhamId);

                if (sanPhamChiTietList != null && sanPhamChiTietList.Any())
                {
                    foreach (var chiTiet in sanPhamChiTietList)
                    {
                        if (chiTiet != null)
                        {
                            var mauSacList = await _sanPhamChiTietMauSacService.GetMauSacIdsBySanPhamChiTietId(chiTiet.IdSanPhamChiTiet);
                            var mauSacTenList = mauSacList?.Select(ms => ms?.TenMauSac).ToList() ?? new List<string>();

                            var kichCoList = await _sanPhamChiTietKichCoService.GetKichCoIdsBySanPhamChiTietId(chiTiet.IdSanPhamChiTiet);
                            var kichCoTenList = kichCoList?.Select(kc => kc?.TenKichCo).ToList() ?? new List<string>();

                            var hinhAnhs = await _hinhAnhService.GetHinhAnhsBySanPhamChiTietId(chiTiet.IdSanPhamChiTiet);

                            sanPhamChiTietViewModels.Add(new PromotionViewModel.SanPhamChiTietViewModel
                            {
                                IdSanPhamChiTiet = chiTiet.IdSanPhamChiTiet,
                                ProductName = sanPham.TenSanPham,
                                Quantity = chiTiet.SoLuong,
                                Price = chiTiet.Gia,
                                HinhAnhs = hinhAnhs,
                                MauSac = mauSacTenList,
                                KichCo = kichCoTenList,
                            });
                        }
                    }
                }
            }

            return Json(new { ChiTietSanPhams = sanPhamChiTietViewModels });
        }
        public async Task<IActionResult> Delete(Guid id)
        {
            if (id == Guid.Empty)
            {
                return NotFound("Id cannot be empty");
            }

            try
            {
                var promotion = await _promotionService.GetPromotionByIdAsync(id);
                if (promotion != null)
                {
                    var result = await _promotionService.DeleteAsync(id);
                    if (result)
                    {
                        _logger.LogInformation($"Successfully deleted promotion with Id: {id}");
                        TempData["SuccessMessage"] = "Promotion deleted successfully.";
                    }
                    else
                    {
                        _logger.LogWarning($"Failed to delete promotion with Id: {id}");
                        TempData["ErrorMessage"] = "Failed to delete the promotion.";
                    }
                }
                else
                {
                    _logger.LogWarning($"Attempted to delete non-existent promotion with Id: {id}");
                    TempData["ErrorMessage"] = "Promotion not found.";
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error occurred while deleting promotion with Id: {id}");
                TempData["ErrorMessage"] = "An error occurred while deleting the promotion.";
            }

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(Guid id)
        {
            if (id == Guid.Empty)
            {
                return NotFound("Id cannot be empty");
            }

            try
            {
                var promotion = await _promotionService.GetPromotionByIdAsync(id);
                if (promotion == null)
                {
                    _logger.LogWarning($"Promotion not found for Id: {id}");
                    return NotFound("Promotion not found.");
                }
                ViewBag.TrangThaiList = new SelectList(new[]
                {
                    new { Value = 0, Text = "Disabled" },
                    new { Value = 1, Text = "Active" },
                    new { Value = 2, Text = "Paused" }
                }, "Value", "Text", promotion.TrangThai);
                return View(promotion);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error occurred while fetching promotion with Id: {id}");
                return StatusCode(500, "An error occurred while retrieving the promotion.");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, Promotion promotion)
        {
            if (id != promotion.IdPromotion)
            {
                return BadRequest("Id mismatch");
            }

            if (!ModelState.IsValid)
            {
                return View(promotion);
            }

            try
            {
                var result = await _promotionService.UpdateAsync(promotion);
                if (result)
                {
                    _logger.LogInformation($"Successfully updated promotion with Id: {promotion.IdPromotion}");
                    TempData["SuccessMessage"] = "Promotion updated successfully.";
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    _logger.LogWarning($"Failed to update promotion with Id: {promotion.IdPromotion}");
                    ModelState.AddModelError("", "Failed to update the promotion. Please check server logs for details.");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Exception occurred during promotion update. Promotion Id: {promotion.IdPromotion}");
                ModelState.AddModelError("", $"An error occurred: {ex.Message}");
            }

            return View(promotion);
        }
    }
}
