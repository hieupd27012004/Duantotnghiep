using APPMVC.ViewModel; // Đảm bảo bạn đã thêm namespace này
using APPMVC.IService;
using Microsoft.AspNetCore.Mvc;
using AppData.Model;
using AppAPI.Service;
using System.Net.Http.Headers;
using Microsoft.Extensions.Logging;
using AppData.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace APPMVC.Areas.Client.Controllers
{
    [Area("Client")]
    public class SanPhamController : Controller
    {
        private readonly ISanPhamService _sanPhamservice;
        private readonly ISanPhamChiTietService _sanPhamCTservice;
        private readonly ISanPhamChiTietMauSacService _sanPhamChiTietMauSacService;
        private readonly ISanPhamChiTietKichCoService _sanPhamChiTietKichCoService;
        private readonly IHinhAnhService _hinhAnhService;
        private readonly IKichCoService _kichCoService;
        private readonly IMauSacService _mauSacService;
        private readonly ILogger<SanPhamController> _logger;
        private readonly IGioHangChiTietService _gioHangChiTietService;
        private readonly ICardService _cardService;
        private readonly IPromotionSanPhamChiTietService _promotionSanPhamChiTietService;
        public SanPhamController(
            ISanPhamService sanPhamservice,
            ISanPhamChiTietService sanPhamCTservice,
            ISanPhamChiTietMauSacService sanPhamChiTietMauSacService,
            IHinhAnhService hinhAnhService,
            IKichCoService kichCoService,
            IMauSacService mauSacService,
            ISanPhamChiTietKichCoService sanPhamChiTietKichCoService,
            IGioHangChiTietService gioHangChiTietService,
            ILogger<SanPhamController> logger,
            ICardService cardService,
            IPromotionSanPhamChiTietService promotionSanPhamChiTietService)
        {
            _sanPhamservice = sanPhamservice;
            _sanPhamCTservice = sanPhamCTservice;
            _sanPhamChiTietMauSacService = sanPhamChiTietMauSacService;
            _sanPhamChiTietKichCoService = sanPhamChiTietKichCoService;
            _hinhAnhService = hinhAnhService;
            _kichCoService = kichCoService;
            _mauSacService = mauSacService;
            _gioHangChiTietService = gioHangChiTietService;
            _cardService = cardService;
            _logger = logger;
            _promotionSanPhamChiTietService = promotionSanPhamChiTietService;
        }

        public async Task<IActionResult> Index(string? name)
        {
            var sanPhams = await _sanPhamservice.GetSanPhamClient(name);
            var sanPhamClientViewModels = new List<SanPhamClientViewModel>();

            foreach (var sanPham in sanPhams)
            {
                var sanPhamChiTietList = await _sanPhamCTservice.GetSanPhamChiTietBySanPhamId(sanPham.IdSanPham);

                var representativeImage = new byte[0];
                var colorImages = new List<RepresentativeImageViewModel>();

                foreach (var sanPhamChiTiet in sanPhamChiTietList)
                {
                    var mauSacList = await _sanPhamChiTietMauSacService.GetMauSacIdsBySanPhamChiTietId(sanPhamChiTiet.IdSanPhamChiTiet);

                    foreach (var mauSac in mauSacList)
                    {
                        var hinhAnhs = await _hinhAnhService.GetHinhAnhsBySanPhamChiTietId(sanPhamChiTiet.IdSanPhamChiTiet);

                        if (hinhAnhs.Any())
                        {
                            if (representativeImage.Length == 0)
                            {
                                representativeImage = hinhAnhs.First().DataHinhAnh;
                            }

                            colorImages.Add(new RepresentativeImageViewModel
                            {
                                MauSacTen = mauSac.TenMauSac,
                                AnhDaiDien = hinhAnhs.First().DataHinhAnh
                            });
                        }
                    }
                }

                var viewModel = new SanPhamClientViewModel
                {
                    IdSanPham = sanPham.IdSanPham,
                    TenSanPham = sanPham.TenSanPham,
                    SoLuongMau = colorImages.Count,
                    GiaThapNhat = sanPhamChiTietList.Min(x => x.GiaGiam ?? x.Gia), 
                    GiaCaoNhat = sanPhamChiTietList.Max(x => x.GiaGiam ?? x.Gia), 
                    RepresentativeImage = representativeImage,
                    ColorImages = colorImages
                };

                sanPhamClientViewModels.Add(viewModel);
            }

            return View(sanPhamClientViewModels);
        }

        [HttpGet]
        public async Task<IActionResult> Detail(Guid sanphamId, Guid? selectedColorId = null, Guid? selectedSizeId = null)
        {
            try
            {
                if (sanphamId == Guid.Empty)
                {
                    return NotFound("Mã sản phẩm không hợp lệ.");
                }

                var sanPham = await _sanPhamservice.GetSanPhamById(sanphamId);
                if (sanPham == null)
                {
                    return NotFound($"Không tìm thấy sản phẩm có mã {sanphamId}.");
                }

                var sanPhamChiTietList = await _sanPhamCTservice.GetSanPhamChiTietBySanPhamId(sanphamId);
                if (sanPhamChiTietList == null || !sanPhamChiTietList.Any())
                {
                    return NotFound($"Không tìm thấy chi tiết sản phẩm cho mã {sanphamId}.");
                }

                var sanPhamChiTietViewModels = new List<SanPhamChiTietItemViewModel>();
                var availableColors = new HashSet<MauSac>();
                var availableSizes = new HashSet<KichCo>();

                foreach (var chiTiet in sanPhamChiTietList)
                {
                    var mauSacList = await _sanPhamChiTietMauSacService.GetMauSacIdsBySanPhamChiTietId(chiTiet.IdSanPhamChiTiet);
                    availableColors.UnionWith(mauSacList);

                    var kichCoList = await _sanPhamChiTietKichCoService.GetKichCoIdsBySanPhamChiTietId(chiTiet.IdSanPhamChiTiet);
                    availableSizes.UnionWith(kichCoList);

                    var hinhAnhs = await _hinhAnhService.GetHinhAnhsBySanPhamChiTietId(chiTiet.IdSanPhamChiTiet);

                    // Lấy giá đã giảm từ chi tiết sản phẩm
                    double? discountedPrice = chiTiet.GiaGiam; 

                    sanPhamChiTietViewModels.Add(new SanPhamChiTietItemViewModel
                    {
                        IdSanPhamChiTiet = chiTiet.IdSanPhamChiTiet,
                        HinhAnhs = hinhAnhs,
                        MauSac = mauSacList.Select(ms => ms.TenMauSac).ToList(),
                        KichCo = kichCoList.Select(kc => kc.TenKichCo).ToList(),
                        Gia = chiTiet.Gia,
                        GiaDaGiam = discountedPrice,
                        SoLuong = chiTiet.SoLuong,
                        XuatXu = chiTiet.XuatXu,
                    });
                }

                var firstDetail = sanPhamChiTietViewModels.FirstOrDefault();

                var viewModel = new SanPhamChiTietClientViewModel
                {
                    IdSanPham = sanphamId,
                    TenSanPham = sanPham.TenSanPham,
                    MoTa = sanPham.MoTa,
                    DiscountedPrice = firstDetail?.GiaDaGiam,
                    Gia = firstDetail?.Gia,
                    SoLuong = firstDetail?.SoLuong,
                    SanPhamChiTietList = sanPhamChiTietViewModels,
                    HinhAnhs = sanPhamChiTietViewModels.SelectMany(d => d.HinhAnhs).Distinct().ToList(),
                    AvailableColors = availableColors.ToList(),
                    AvailableSizes = availableSizes.ToList(),
                    SelectedColorId = selectedColorId,
                    SelectedSizeId = selectedSizeId,
                };

                return View(viewModel);
            }
            catch (Exception ex)
            {
                // Log the exception if necessary
                return StatusCode(500, "Đã xảy ra lỗi nội bộ. Vui lòng thử lại sau.");
            }
        }
        public async Task<IActionResult> GetVariant(Guid productId, Guid colorId, Guid sizeId)
        {
            var sanPhamChiTiet = await _sanPhamCTservice.GetIdSanPhamChiTietByFilter(productId, sizeId, colorId);

            if (sanPhamChiTiet == null)
            {
                return Json(new { success = false, message = "Không tìm thấy sản phẩm phù hợp" });
            }

            var hinhAnhs = await _hinhAnhService.GetHinhAnhsBySanPhamChiTietId(sanPhamChiTiet.IdSanPhamChiTiet);

            double? originalPrice = sanPhamChiTiet.Gia;
            double? discountedPrice = sanPhamChiTiet.GiaGiam;

            return Json(new
            {
                success = true,
                originalPrice = originalPrice,
                discountedPrice = discountedPrice,
                quantity = sanPhamChiTiet.SoLuong,
                images = hinhAnhs.Select(h => new
                {
                    base64 = Convert.ToBase64String(h.DataHinhAnh),
                    type = h.LoaiFileHinhAnh
                }).ToList()
            });
        }
        [HttpPost]
        public async Task<IActionResult> AddToCard(Guid productId, Guid colorId, Guid sizeId)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var customerIdString = HttpContext.Session.GetString("IdKhachHang");
                if (string.IsNullOrEmpty(customerIdString) || !Guid.TryParse(customerIdString, out Guid customerId))
                {
                    return Unauthorized(new { message = "Customer not found in session." });
                }

                var idGioHang = await _cardService.GetCartIdByCustomerIdAsync(customerId);
                if (idGioHang == Guid.Empty)
                {
                    return NotFound(new { message = "Shopping cart not found for this customer." });
                }

                var sanPhamChiTiet = await _sanPhamCTservice.GetIdSanPhamChiTietByFilter(productId, sizeId, colorId);
                if (sanPhamChiTiet == null)
                {
                    return Json(new { success = false, message = "Product not found" });
                }

                int requestedQuantity = 1; 
                if (requestedQuantity <= 0)
                {
                    return Json(new { success = false, message = "Quantity must be greater than zero." });
                }

                if (requestedQuantity > sanPhamChiTiet.SoLuong)
                {
                    return Json(new { success = false, message = "Insufficient quantity available." });
                }

                var existingItem = await _gioHangChiTietService.GetByProductIdAndCartIdAsync(sanPhamChiTiet.IdSanPhamChiTiet, idGioHang);
                if (existingItem != null)
                {

                    double newQuantity = existingItem.SoLuong + requestedQuantity;

                    if (newQuantity > sanPhamChiTiet.SoLuong)
                    {
                        return Json(new { success = false, message = "Total quantity exceeds available stock." });
                    }

                    existingItem.SoLuong = newQuantity;
                    existingItem.TongTien = existingItem.DonGia * newQuantity;

                    await _gioHangChiTietService.UpdateAsync(existingItem); 
                    return Ok(new { message = "Item quantity updated in cart successfully", existingItem });
                }

                var donGia = sanPhamChiTiet.GiaGiam ?? sanPhamChiTiet.Gia;

                var gioHangChiTiet = new GioHangChiTiet
                {
                    IdGioHangChiTiet = Guid.NewGuid(),
                    IdGioHang = idGioHang,
                    IdSanPhamChiTiet = sanPhamChiTiet.IdSanPhamChiTiet,
                    DonGia = donGia,
                    SoLuong = requestedQuantity,
                    TongTien = donGia * requestedQuantity,
                    KichHoat = 1
                };

                await _gioHangChiTietService.AddAsync(gioHangChiTiet);

                return Ok(new { message = "Item added to cart successfully", gioHangChiTiet });
            }
            catch (Exception ex)
            {
                // Log the exception
                Console.WriteLine($"Error in AddToCard: {ex.Message}");
                return StatusCode(500, new { message = "An error occurred while adding to the cart." });
            }
        }
    }
}