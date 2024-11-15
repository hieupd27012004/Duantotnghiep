using AppData.Model;
using AppData.ViewModel;
using APPMVC.IService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APPMVC.Areas.Client.Controllers
{
	[Area("Client")]
	public class HomeClientController : Controller
	{
        private readonly IGioHangChiTietService _gioHangChiTietService;
        private readonly IHinhAnhService _hinhAnhService;
        private readonly ISanPhamChiTietService _sanPhamChiTietService;
        private readonly ICardService _cardService;
        private readonly IHoaDonService _hoaDonService;
        private readonly IHoaDonChiTietService _hoaDonChiTietService;
        private readonly ILichSuHoaDonService _lichSuHoaDonService;
        public HomeClientController(IGioHangChiTietService gioHangChiTietService, IHinhAnhService hinhAnhService, ISanPhamChiTietService sanPhamChiTietService, ICardService cardService, IHoaDonService hoaDonService, IHoaDonChiTietService hoaDonChiTietService, ILichSuHoaDonService lichSuHoaDonService )
        {
            _gioHangChiTietService = gioHangChiTietService;
            _hinhAnhService = hinhAnhService;
            _sanPhamChiTietService = sanPhamChiTietService;
            _cardService = cardService;
            _hoaDonService = hoaDonService;
            _hoaDonChiTietService = hoaDonChiTietService;
            _lichSuHoaDonService = lichSuHoaDonService;
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
        [HttpPost]
        public async Task<IActionResult> UpdateQuantity([FromBody] List<UpdateQuantityViewModel>? models)
        {
            if (ModelState.IsValid && models != null)
            {
                foreach (var model in models)
                {
                    var item = await _gioHangChiTietService.GetByIdAsync(model.IdGioHangChiTiet);
                    if (item != null)
                    {
                        item.SoLuong = model.Quantity;
                        item.TongTien = model.TongTien;
                        await _gioHangChiTietService.UpdateAsync(item);
                    }
                }
                return Json(new { success = true });
            }
            return Json(new { success = false });
        }
        [HttpGet]
        public async Task<IActionResult> Checkout()
        {
            var model = new ThanhToanViewModel
            {
                CartItems = await GetCartItems() 
            };
            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> ProcessCheckout(ThanhToanViewModel model)
        {
            model.CartItems = await GetCartItems();
            // Check if the model state is valid
            if (ModelState.IsValid)
            {
                var customerIdString = HttpContext.Session.GetString("IdKhachHang");

                // Validate customer ID
                if (string.IsNullOrEmpty(customerIdString) || !Guid.TryParse(customerIdString, out Guid customerId))
                {
                    return Unauthorized(new { message = "Customer not found in session." });
                }

                var idGioHang = await _cardService.GetCartIdByCustomerIdAsync(customerId);
                // Initialize totals
                double totalDonHang = 0;
                double totalHoaDon = 0;
                foreach (var item in model.CartItems) // Access the CartItems property
                {
                    if (item.Price > 0 && item.Quantity > 0)
                    {
                        totalDonHang += item.Price * item.Quantity;
                    }
                }
                totalHoaDon = totalDonHang; 

                // Log totals for debugging
                Console.WriteLine($"Total Don Hang: {totalDonHang}, Total Hoa Don: {totalHoaDon}");

                // Create the order
                var order = new HoaDon
                {
                    IdHoaDon = Guid.NewGuid(),
                    MaDon = GenerateOrderNumber(),
                    NguoiNhan = model.NguoiNhan,
                    SoDienThoaiNguoiNhan = model.SoDienThoaiNguoiNhan,
                    DiaChiGiaoHang = model.DiaChiGiaoHang,
                    LoaiHoaDon = "Trực tuyến",
                    TienShip = 1,
                    TongTienDonHang = totalDonHang,
                    TongTienHoaDon = totalHoaDon,
                    NgayTao = DateTime.Now,
                    NguoiTao = "Khách hàng",
                    KichHoat = 1,
                    TrangThai = "Chờ xác nhận",
                    IdKhachHang = customerId,
                    IdNhanVien = null
                };

                var orderDetails = new List<HoaDonChiTiet>();
                foreach (var item in model.CartItems)
                {
                    if (item.Price > 0 && item.Quantity > 0) 
                    {
                        orderDetails.Add(new HoaDonChiTiet
                        {
                            IdHoaDonChiTiet = Guid.NewGuid(),
                            DonGia = item.Price,
                            SoLuong = item.Quantity,
                            TongTien = item.Price * item.Quantity,
                            KichHoat = 1,
                            IdHoaDon = order.IdHoaDon,
                            IdSanPhamChiTiet = item.IdSanPhamChiTiet
                        });
                    }
                }

                try
                {
                    await _hoaDonService.AddAsync(order);
                    await _hoaDonChiTietService.AddAsync(orderDetails); 

                    var lichSu = new LichSuHoaDon
                    {
                        IdLichSuHoaDon = Guid.NewGuid(),
                        ThaoTac = order.TrangThai,
                        NgayTao = DateTime.Now,
                        NguoiThaoTac = "Khách hàng",
                        TrangThai = "1",
                        IdHoaDon = order.IdHoaDon,
                    };

                    await _lichSuHoaDonService.AddAsync(lichSu);

                    await _gioHangChiTietService.ClearCartByIdAsync(idGioHang);

                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    // Log the exception (consider using a logging framework)
                    ModelState.AddModelError("", "An error occurred while processing your order. Please try again.");
                }
            }

            // Return to the checkout view with the existing model if the model state is invalid or an error occurred
            return View("Checkout", model);
        }

        private string GenerateOrderNumber()
        {
            return $"DON-{DateTime.Now:yyyyMMdd}-{GetNextOrderNumber():D3}"; 
        }

        private int GetNextOrderNumber()
        {
            return 1; 
        }


        private async Task<List<CartItemViewModel>> GetCartItems()
        {
            var customerIdString = HttpContext.Session.GetString("IdKhachHang");

            // Validate customer ID from session
            if (string.IsNullOrEmpty(customerIdString) || !Guid.TryParse(customerIdString, out Guid customerId))
            {
                return new List<CartItemViewModel>();
            }

            // Get the cart ID for the customer
            var idGioHang = await _cardService.GetCartIdByCustomerIdAsync(customerId);
            if (idGioHang == Guid.Empty)
            {
                return new List<CartItemViewModel>();
            }

            // Get cart details
            var gioHangChiTiets = await _gioHangChiTietService.GetByGioHangIdAsync(idGioHang);
            if (gioHangChiTiets == null || !gioHangChiTiets.Any())
            {
                return new List<CartItemViewModel>();
            }

            // Create a list of tasks for fetching product details
            var tasks = new List<Task<CartItemViewModel>>();
            foreach (var item in gioHangChiTiets)
            {
                tasks.Add(GetCartItemViewModelAsync(item));
            }

            // Await all tasks and return results
            return (await Task.WhenAll(tasks)).ToList();
        }

        private async Task<CartItemViewModel> GetCartItemViewModelAsync(GioHangChiTiet item)
        {
            var sanPham = await _sanPhamChiTietService.GetSanPhamByIdSanPhamChiTietAsync(item.IdSanPhamChiTiet);
            return new CartItemViewModel
            {
                IdSanPhamChiTiet = item.IdSanPhamChiTiet,
                ProductName = sanPham?.TenSanPham ?? "Unknown Product",
                Quantity = item.SoLuong,
                Price = item.SoLuong > 0 ? item.TongTien / item.SoLuong : 0
            };
        }
    }
}
