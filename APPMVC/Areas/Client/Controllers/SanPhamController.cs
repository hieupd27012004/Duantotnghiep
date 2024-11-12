using APPMVC.ViewModel; // Đảm bảo bạn đã thêm namespace này
using APPMVC.IService;
using Microsoft.AspNetCore.Mvc;
using AppData.Model;
using AppAPI.Service;
using System.Net.Http.Headers;
using Microsoft.Extensions.Logging;

namespace APPMVC.Areas.Client.Controllers
{
    [Area("Client")]
    public class SanPhamController : Controller
    {
        private readonly ISanPhamService _sanPhamservice;
        private readonly ISanPhamChiTietService _sanPhamCTservice;
        private readonly ISanPhamChiTietMauSacService _sanPhamChiTietMauSacService;
        private readonly IHinhAnhService _hinhAnhService;
        private readonly IKichCoService _kichCoService;
        private readonly IMauSacService _mauSacService;
        private readonly ILogger<SanPhamController> _logger;
        public SanPhamController(
            ISanPhamService sanPhamservice,
            ISanPhamChiTietService sanPhamCTservice,
            ISanPhamChiTietMauSacService sanPhamChiTietMauSacService,
            IHinhAnhService hinhAnhService,
            IKichCoService kichCoService,
            IMauSacService mauSacService,
            ILogger<SanPhamController> logger)
        {
            _sanPhamservice = sanPhamservice;
            _sanPhamCTservice = sanPhamCTservice;
            _sanPhamChiTietMauSacService = sanPhamChiTietMauSacService;
            _hinhAnhService = hinhAnhService;
            _kichCoService = kichCoService;
            _mauSacService = mauSacService;
            _logger = logger;
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
                            // Set the first image as the representative image
                            if (representativeImage.Length == 0)
                            {
                                representativeImage = hinhAnhs.First().DataHinhAnh;
                            }

                            // Add color images
                            colorImages.Add(new RepresentativeImageViewModel
                            {
                                MauSacTen = mauSac.TenMauSac,
                                AnhDaiDien = hinhAnhs.First().DataHinhAnh // Assuming you want the first image for each color
                            });
                        }
                    }
                }

                var viewModel = new SanPhamClientViewModel
                {
                    IdSanPham = sanPham.IdSanPham,
                    TenSanPham = sanPham.TenSanPham,
                    SoLuongMau = colorImages.Count,
                    GiaThapNhat = sanPhamChiTietList.Min(x => x.Gia),
                    GiaCaoNhat = sanPhamChiTietList.Max(x => x.Gia),
                    RepresentativeImage = representativeImage,
                    ColorImages = colorImages
                };

                sanPhamClientViewModels.Add(viewModel);
            }

            return View(sanPhamClientViewModels);
        }

        public async Task<IActionResult> Detail(Guid sanphamId)
        {
            try
            {
                // Kiểm tra ID hợp lệ
                if (sanphamId == Guid.Empty)
                {
                    return NotFound("Mã sản phẩm không hợp lệ");
                }

                // Lấy thông tin sản phẩm
                var sanPhamChiTiet = await _sanPhamservice.GetSanPhamById(sanphamId);

                // Kiểm tra sản phẩm có tồn tại không
                if (sanPhamChiTiet == null)
                {
                    return NotFound($"Không tìm thấy sản phẩm có mã {sanphamId}");
                }

                // Lấy danh sách kích cỡ
                List<KichCo> availableSizes = null;
                try
                {
                    availableSizes = await _kichCoService.GetKichCoBySanPhamId(sanphamId);

                    // Log thông tin chi tiết
                    _logger.LogInformation($"Retrieved sizes for product {sanphamId}: {availableSizes?.Count ?? 0} sizes");
                }
                catch (Exception ex)
                {
                    // Log toàn bộ chi tiết lỗi
                    _logger.LogError(ex, $"Error retrieving sizes for product {sanphamId}");

                    // Trả về thông báo lỗi chi tiết
                    return BadRequest(new
                    {
                        message = "Lỗi khi lấy kích cỡ sản phẩm",
                        details = ex.Message,
                        stackTrace = ex.StackTrace
                    });
                }

                // Kiểm tra danh sách kích cỡ
                if (availableSizes == null || !availableSizes.Any())
                {
                    _logger.LogWarning($"No sizes found for product {sanphamId}");
                    return NotFound($"Không tìm thấy size của sản phẩm {sanphamId}");
                }

                // Tương tự với colors
                List<MauSac> availableColors = null;
                try
                {
                    availableColors = await _mauSacService.GetMauSacBySanPhamId(sanphamId);

                    // Log thông tin chi tiết
                    _logger.LogInformation($"Retrieved colors for product {sanphamId}: {availableColors?.Count ?? 0} colors");
                }
                catch (Exception ex)
                {
                    // Log toàn bộ chi tiết lỗi
                    _logger.LogError(ex, $"Error retrieving colors for product {sanphamId}");

                    // Trả về thông báo lỗi chi tiết
                    return BadRequest(new
                    {
                        message = "Lỗi khi lấy màu sắc sản phẩm",
                        details = ex.Message,
                        stackTrace = ex.StackTrace
                    });
                }

                // Kiểm tra danh sách màu sắc
                if (availableColors == null || !availableColors.Any())
                {
                    _logger.LogWarning($"No colors found for product {sanphamId}");
                    return NotFound($"Không tìm thấy màu của sản phẩm {sanphamId}");
                }

                var viewModel = new SanPhamChiTietClientViewModel
                {
                    IdSanPham = sanphamId,
                    TenSanPham = sanPhamChiTiet.TenSanPham,
                    MoTa = sanPhamChiTiet.MoTa,
                   

                    AvailableSizes = availableSizes.Select(s => new KichCoViewModel
                    {
                        IdKichCo = s.IdKichCo,
                        TenKichCo = s.TenKichCo
                    }).ToList(),

                    AvailableColors = availableColors.Select(c => new MauSacViewModel
                    {
                        IdMauSac = c.IdMauSac,
                        TenMauSac = c.TenMauSac
                    }).ToList()
                };

                return View(viewModel);
            }
            catch (Exception ex)
            {
                // Log lỗi toàn cục
                _logger.LogError(ex, $"Unexpected error in product detail for {sanphamId}");

                // Trả về trang lỗi hoặc thông báo lỗi
                return StatusCode(500, new
                {
                    message = "Có lỗi xảy ra khi tải chi tiết sản phẩm",
                    details = ex.Message,
                    stackTrace = ex.StackTrace
                });
            }
        }

        // Các phương thức GetSizes và GetColors cũng cần được cập nhật tương tự
        public async Task<IActionResult> GetSizes(Guid sanPhamId)
        {
            try
            {
                var sizes = await _kichCoService.GetKichCoBySanPhamId(sanPhamId);

                // Chuyển đổi sang ViewModel
                var sizeViewModels = sizes?.Select(s => new KichCoViewModel
                {
                    IdKichCo = s.IdKichCo,
                    TenKichCo = s.TenKichCo
                }).ToList() ?? new List<KichCoViewModel>();

                return Json(sizeViewModels);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Lỗi khi lấy kích cỡ cho sản phẩm {sanPhamId}");
                return StatusCode(500, new
                {
                    message = "Có lỗi xảy ra khi tải kích cỡ",
                    error = ex.Message
                });
            }
        }

        public async Task<IActionResult> GetColors(Guid sanPhamId)
        {
            try
            {
                var colors = await _mauSacService.GetMauSacBySanPhamId(sanPhamId);

                // Chuyển đổi sang ViewModel
                var colorViewModels = colors?.Select(c => new MauSacViewModel
                {
                    IdMauSac = c.IdMauSac,
                    TenMauSac = c.TenMauSac
                }).ToList() ?? new List<MauSacViewModel>();

                return Json(colorViewModels);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Lỗi khi lấy màu sắc cho sản phẩm {sanPhamId}");
                return StatusCode(500, new
                {
                    message = "Có lỗi xảy ra khi tải màu sắc",
                    error = ex.Message
                });
            }
        }
        public async Task<IActionResult> GetProductDetailByFilter(Guid idSanPham, Guid idKichCo, Guid idMauSac)
        {
            var result = await _sanPhamCTservice.GetIdSanPhamChiTietByFilter(idSanPham, idKichCo, idMauSac);

            if (result == null)
            {
                ViewBag.Message = "Không tìm thấy sản phẩm phù hợp";
                return View("Error");
            }

            return View(result);
        }
    }
}