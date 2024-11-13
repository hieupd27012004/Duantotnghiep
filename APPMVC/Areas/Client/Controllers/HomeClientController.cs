using AppData.ViewModel;
using APPMVC.IService;
using Microsoft.AspNetCore.Mvc;

namespace APPMVC.Areas.Client.Controllers
{
	[Area("Client")]
	public class HomeClientController : Controller
	{
        private readonly IGioHangChiTietService _gioHangChiTietService;
        private readonly IHinhAnhService _hinhAnhService;
        private readonly ISanPhamChiTietService _sanPhamChiTietService;
        private readonly ICardService _cardService;
        public HomeClientController(IGioHangChiTietService gioHangChiTietService, IHinhAnhService hinhAnhService, ISanPhamChiTietService sanPhamChiTietService, ICardService cardService)
        {
            _gioHangChiTietService = gioHangChiTietService;
            _hinhAnhService = hinhAnhService;
            _sanPhamChiTietService = sanPhamChiTietService;
            _cardService = cardService;
        }
        public IActionResult Index()
		{
			return View();
		}
		public IActionResult LoginRegister()
		{
			return View();
		}
        public async Task<IActionResult> Card()
        {
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

            var gioHangChiTiets = await _gioHangChiTietService.GetByGioHangIdAsync(idGioHang);

            // Chuyển đổi chi tiết giỏ hàng sang ViewModel
            var viewModelTasks = gioHangChiTiets.Select(async item =>
            {
                // Lấy sản phẩm từ ID sản phẩm chi tiết
                var sanPham = await _sanPhamChiTietService.GetSanPhamByIdSanPhamChiTietAsync(item.IdSanPhamChiTiet);
                var hinhanh = await _hinhAnhService.GetHinhAnhsBySanPhamChiTietId(item.IdSanPhamChiTiet);
                return new GioHangChiTietViewModel
                {
                    IdGioHangChiTiet = item.IdGioHangChiTiet,
                    HinhAnhs = hinhanh,
                    TenSanPham = sanPham?.TenSanPham ?? "Unknown Product",
                    DonGia = item.SoLuong > 0 ? item.TongTien / item.SoLuong : 0,
                    SoLuong = item.SoLuong,
                    TongTien = item.TongTien
                };
            });

            var viewModelArray = await Task.WhenAll(viewModelTasks);
            var viewModel = viewModelArray.ToList();

            return View(viewModel);
        }

    }
}
