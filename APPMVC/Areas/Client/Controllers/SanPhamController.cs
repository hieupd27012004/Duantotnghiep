using APPMVC.ViewModel; // Đảm bảo bạn đã thêm namespace này
using APPMVC.IService;
using Microsoft.AspNetCore.Mvc;
using AppData.Model;
using AppAPI.Service;
using System.Net.Http.Headers;
using Microsoft.Extensions.Logging;
using AppData.ViewModel;
using Microsoft.EntityFrameworkCore;
using Castle.Core.Resource;
using APPMVC.Session;

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
        private readonly IKhachHangService _khachHangService;
        private readonly IPromotionService _promotionService;
        private readonly IDanhMucService _danhMucService;
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
            IPromotionSanPhamChiTietService promotionSanPhamChiTietService,
            IKhachHangService khachHangService,
            IPromotionService promotionService,
            IDanhMucService danhMucService)
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
            _khachHangService = khachHangService;
            _promotionService = promotionService;
            _danhMucService = danhMucService;
        }

        public async Task<IActionResult> Index(string? name)
        {
            var sanPhams = await _sanPhamservice.GetSanPhamClient(name);
            var activeSanPhams = sanPhams.Where(sp => sp.KichHoat == 1).ToList();

            var sanPhamClientViewModels = new List<SanPhamClientViewModel>();

            foreach (var sanPham in activeSanPhams)
            {
                var sanPhamChiTietList = await _sanPhamCTservice.GetSanPhamChiTietBySanPhamId(sanPham.IdSanPham);

                var hasActivePromotion = false;
                double highestDiscountPercentage = 0;
                double? minPrice = null;
                double? maxPrice = null;

                foreach (var sanPhamChiTiet in sanPhamChiTietList)
                {
                    // Lấy ID khuyến mãi tương ứng với sản phẩm chi tiết
                    var promotionId = await _promotionSanPhamChiTietService.GetPromotionsBySanPhamChiTietIdAsync(sanPhamChiTiet.IdSanPhamChiTiet);

                    // Kiểm tra nếu promotionId không phải là Guid.Empty
                    if (promotionId.HasValue && promotionId.Value != Guid.Empty)
                    {
                        var promotionDetails = await _promotionService.GetPromotionByIdAsync(promotionId.Value);
                        if (promotionDetails != null && promotionDetails.TrangThai == 1)
                        {
                            hasActivePromotion = true;

                            // Tính toán giá giảm chỉ nếu có khuyến mãi
                            if (sanPhamChiTiet.GiaGiam.HasValue && sanPhamChiTiet.GiaGiam.Value < sanPhamChiTiet.Gia)
                            {
                                var discountPercentage = Math.Round(((sanPhamChiTiet.Gia - sanPhamChiTiet.GiaGiam.Value) / sanPhamChiTiet.Gia) * 100);
                                highestDiscountPercentage = Math.Max(highestDiscountPercentage, discountPercentage);
                            }
                        }
                    }

                    // Tính toán giá hiệu dụng (giá sau khuyến mãi)
                    double effectivePrice = sanPhamChiTiet.GiaGiam.HasValue ? sanPhamChiTiet.GiaGiam.Value : sanPhamChiTiet.Gia;

                    // Cập nhật giá thấp nhất và cao nhất
                    minPrice = minPrice == null ? effectivePrice : Math.Min(minPrice.Value, effectivePrice);
                    maxPrice = maxPrice == null ? effectivePrice : Math.Max(maxPrice.Value, effectivePrice);
                }

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
                    // Cập nhật giá thấp nhất và cao nhất
                    GiaThapNhat = minPrice ?? sanPhamChiTietList.Min(x => x.Gia),
                    GiaCaoNhat = maxPrice ?? sanPhamChiTietList.Max(x => x.Gia),
                    RepresentativeImage = representativeImage,
                    ColorImages = colorImages,
                    HighestDiscountPercentage = highestDiscountPercentage // Phần trăm cao nhất từ sản phẩm có khuyến mãi
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

                    // Kiểm tra khuyến mãi
                    var promotionId = await _promotionSanPhamChiTietService.GetPromotionsBySanPhamChiTietIdAsync(chiTiet.IdSanPhamChiTiet);
                    double? discountedPrice = null;

                    // Kiểm tra nếu promotionId không phải là Guid.Empty
                    if (promotionId.HasValue && promotionId.Value != Guid.Empty)
                    {
                        var promotionDetails = await _promotionService.GetPromotionByIdAsync(promotionId.Value);
                        if (promotionDetails != null && promotionDetails.TrangThai == 1) 
                        {
                            discountedPrice = chiTiet.GiaGiam; 
                        }
                    }

                    sanPhamChiTietViewModels.Add(new SanPhamChiTietItemViewModel
                    {
                        IdSanPhamChiTiet = chiTiet.IdSanPhamChiTiet,
                        HinhAnhs = hinhAnhs,
                        MauSac = mauSacList.Select(ms => ms.TenMauSac).ToList(),
                        KichCo = kichCoList.Select(kc => kc.TenKichCo).ToList(),
                        Gia = chiTiet.Gia,
                        GiaDaGiam = discountedPrice, // Gán giá giảm nếu có khuyến mãi
                        SoLuong = chiTiet.SoLuong,
                        XuatXu = chiTiet.XuatXu,
                        KichHoat = chiTiet.KichHoat
                    });
                }

                var firstDetail = sanPhamChiTietViewModels.FirstOrDefault();

                var viewModel = new SanPhamChiTietClientViewModel
                {
                    IdSanPham = sanphamId,
                    TenSanPham = sanPham.TenSanPham,
                    MoTa = sanPham.MoTa,
                    DiscountedPrice = firstDetail?.GiaDaGiam, 
                    Gia = firstDetail?.Gia, // Giá gốc
                    SoLuong = firstDetail?.SoLuong,
                    SanPhamChiTietList = sanPhamChiTietViewModels,
                    HinhAnhs = sanPhamChiTietViewModels.SelectMany(d => d.HinhAnhs).Distinct().ToList(),
                    AvailableColors = availableColors.ToList(),
                    AvailableSizes = availableSizes.ToList(),
                    SelectedColorId = selectedColorId,
                    SelectedSizeId = selectedSizeId,
                    KichHoat = firstDetail.KichHoat,

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
            // Lấy thông tin sản phẩm chi tiết theo bộ lọc
            var sanPhamChiTiet = await _sanPhamCTservice.GetIdSanPhamChiTietByFilter(productId, sizeId, colorId);

            // Kiểm tra nếu sản phẩm chi tiết không tồn tại hoặc không được kích hoạt
            if (sanPhamChiTiet == null || sanPhamChiTiet.KichHoat != 1)
            {
                return Json(new { success = false, message = "Sản phẩm không hoạt động" });
            }

            // Lấy hình ảnh cho sản phẩm chi tiết
            var hinhAnhs = await _hinhAnhService.GetHinhAnhsBySanPhamChiTietId(sanPhamChiTiet.IdSanPhamChiTiet);

            // Giá gốc của sản phẩm chi tiết
            double? originalPrice = sanPhamChiTiet.Gia;

            // Khởi tạo giá giảm là null
            double? discountedPrice = null;

            // Kiểm tra khuyến mãi cho sản phẩm chi tiết
            var promotionId = await _promotionSanPhamChiTietService.GetPromotionsBySanPhamChiTietIdAsync(sanPhamChiTiet.IdSanPhamChiTiet);

            // Kiểm tra nếu promotionId không phải là Guid.Empty
            if (promotionId.HasValue && promotionId.Value != Guid.Empty)
            {
                var promotionDetails = await _promotionService.GetPromotionByIdAsync(promotionId.Value);
                if (promotionDetails != null && promotionDetails.TrangThai == 1 && promotionDetails.PhanTramGiam > 0)
                {
                    // Tính toán giá đã giảm
                    discountedPrice = sanPhamChiTiet.GiaGiam;

                    // Ghi log giá giảm để kiểm tra
                    Console.WriteLine($"Discounted Price: {discountedPrice}, Original Price: {originalPrice}, Discount Percentage: {promotionDetails.PhanTramGiam}");
                }
            }

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
                }).ToList(),
                kichHoat = sanPhamChiTiet.KichHoat
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
                    return Json(new { message = "Vui Lòng Đăng Nhập Để Mua Sắm" });
                }

                var idGioHang = await _cardService.GetCartIdByCustomerIdAsync(customerId);
                if (idGioHang == Guid.Empty)
                {
                    return Json(new { message = "Không tìm thấy giỏ hàng cho khách hàng này." });
                }

                var sanPhamChiTiet = await _sanPhamCTservice.GetIdSanPhamChiTietByFilter(productId, sizeId, colorId);
                if (sanPhamChiTiet == null)
                {
                    return Json(new { success = false, message = "Không tìm thấy sản phẩm." });
                }

                int requestedQuantity = 1;
                if (requestedQuantity <= 0)
                {
                    return Json(new { success = false, message = "Số lượng phải lớn hơn không." });
                }

                if (requestedQuantity > sanPhamChiTiet.SoLuong)
                {
                    return Json(new { success = false, message = "Số lượng còn lại không đủ." });
                }

                var existingItem = await _gioHangChiTietService.GetByProductIdAndCartIdAsync(sanPhamChiTiet.IdSanPhamChiTiet, idGioHang);
                if (existingItem != null)
                {
                    double newQuantity = existingItem.SoLuong + requestedQuantity;

                    if (newQuantity > sanPhamChiTiet.SoLuong)
                    {
                        return Json(new { success = false, message = "Tổng số lượng vượt quá hàng tồn kho." });
                    }

                    existingItem.SoLuong = newQuantity;
                    existingItem.TongTien = existingItem.DonGia * newQuantity;

                    await _gioHangChiTietService.UpdateAsync(existingItem);
                    return Ok(new { message = "Số lượng mặt hàng đã được cập nhật trong giỏ hàng thành công", existingItem });
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

                return Ok(new { message = "Mặt hàng đã được thêm vào giỏ hàng thành công", gioHangChiTiet });
            }
            catch (Exception ex)
            {
                // Log the exception
                Console.WriteLine($"Lỗi trong AddToCard: {ex.Message}");
                return StatusCode(500, new { message = "Đã xảy ra lỗi khi thêm vào giỏ hàng." });
            }
        }
        public async Task<IActionResult> BuyNow(Guid productId, Guid colorId, Guid sizeId, int quantity)
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
                    return Json(new { message = "Vui Lòng Đăng Nhập Để Mua Sắm" });
                }
                var sanPham = await _sanPhamservice.GetSanPhamById(productId);
                var sanPhamChiTiet = await _sanPhamCTservice.GetIdSanPhamChiTietByFilter(productId, sizeId, colorId);
                if (sanPhamChiTiet == null)
                {
                    return Json(new { success = false, message = "Không tìm thấy sản phẩm." });
                }

                if (quantity <= 0)
                {
                    return Json(new { success = false, message = "Số lượng phải lớn hơn không." });
                }

                if (quantity > sanPhamChiTiet.SoLuong)
                {
                    return Json(new { success = false, message = "Số lượng không đủ." });
                }

                double price = sanPhamChiTiet.Gia;

                var promotionId = await _promotionSanPhamChiTietService.GetPromotionsBySanPhamChiTietIdAsync(sanPhamChiTiet.IdSanPhamChiTiet);

                if (promotionId.HasValue && promotionId.Value != Guid.Empty)
                {
                    var promotionDetails = await _promotionService.GetPromotionByIdAsync(promotionId.Value);
                    if (promotionDetails != null && promotionDetails.TrangThai == 1 && promotionDetails.PhanTramGiam > 0)
                    {
                        // Tính giá đã giảm
                        price = Convert.ToDouble(sanPhamChiTiet.GiaGiam);
                    }
                }

                var buyItem = new BuyItemViewModel
                {
                    IdSanPhamChiTiet = sanPhamChiTiet.IdSanPhamChiTiet,
                    ProductName = sanPham.TenSanPham,
                    Quantity = quantity,
                    Price = price 
                };

                HttpContext.Session.SetObject("SelectedItem", buyItem);

                // Trả về URL để redirect client
                return Json(new { success = true, redirectUrl = "/Client/HomeClient/Checkout" });
            }
            catch (Exception ex)
            {
                // Ghi log lỗi
                Console.WriteLine($"Lỗi trong BuyNow: {ex.Message}");
                return StatusCode(500, new { message = "Đã xảy ra lỗi trong quá trình xử lý yêu cầu." });
            }
        }       
    }
}