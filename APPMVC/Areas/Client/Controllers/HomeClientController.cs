﻿using AppData.Model;
using AppData.Model.Vnpay;
using AppData.ViewModel;
using APPMVC.IService;
using APPMVC.Session;
using APPMVC.Service.VnpayClient;
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
        private readonly ISanPhamService _sanPhamService;
        private readonly ICardService _cardService;
        private readonly IHoaDonService _hoaDonService;
        private readonly IHoaDonChiTietService _hoaDonChiTietService;
        private readonly IKhachHangService _khachHangService;
        private readonly ILichSuHoaDonService _lichSuHoaDonService;
        private readonly IDiaChiService _diaChiService;
        private readonly ILichSuThanhToanService _lichSuThanhToanService;
        private readonly iVnpayClientService _vnPayService;
        private readonly GiaoHangNhanhService _giaoHangNhanhService;
        private readonly IVoucherService _voucherService;
        public HomeClientController(IGioHangChiTietService gioHangChiTietService,
                                    IHinhAnhService hinhAnhService,
                                    ISanPhamChiTietService sanPhamChiTietService,
                                    ICardService cardService, IHoaDonService hoaDonService,
                                    IKhachHangService khachHangService,
                                    ISanPhamService sanPhamService,
                                    IHoaDonChiTietService hoaDonChiTietService,
                                    ILichSuHoaDonService lichSuHoaDonService,
                                    IDiaChiService diaChiService,
                                    GiaoHangNhanhService giaoHangNhanhService,
                                    iVnpayClientService vnPayService,
                                    ILichSuThanhToanService lichSuThanhToanService,
                                    IVoucherService voucherService
                                    )
        {
            _gioHangChiTietService = gioHangChiTietService;
            _hinhAnhService = hinhAnhService;
            _sanPhamChiTietService = sanPhamChiTietService;
            _cardService = cardService;
            _hoaDonService = hoaDonService;
            _hoaDonChiTietService = hoaDonChiTietService;
            _lichSuHoaDonService = lichSuHoaDonService;
            _lichSuThanhToanService = lichSuThanhToanService;
            _diaChiService = diaChiService;
            _vnPayService = vnPayService;
            _giaoHangNhanhService = giaoHangNhanhService;
            _sanPhamService = sanPhamService;
            _khachHangService = khachHangService;
            _voucherService = voucherService;
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

            var viewModelTasks = gioHangChiTiets.Select(async item =>
            {
                var sanPham = await _sanPhamChiTietService.GetSanPhamByIdSanPhamChiTietAsync(item.IdSanPhamChiTiet);
                var hinhanh = await _hinhAnhService.GetHinhAnhsBySanPhamChiTietId(item.IdSanPhamChiTiet);
                var sanPhamChiTiet = await _sanPhamChiTietService.GetSanPhamChiTietById(item.IdSanPhamChiTiet);

                var gia = sanPhamChiTiet?.Gia;
                var giaDaGiam = sanPhamChiTiet?.GiaGiam;
                double? phanTramGiam = null;

                if (gia.HasValue && giaDaGiam.HasValue && giaDaGiam < gia)
                {
                    phanTramGiam = Math.Round(((gia.Value - giaDaGiam.Value) / gia.Value) * 100, 2);
                }

                return new GioHangChiTietViewModel
                {
                    IdGioHangChiTiet = item.IdGioHangChiTiet,
                    HinhAnhs = hinhanh,
                    TenSanPham = sanPham?.TenSanPham ?? "Unknown Product",
                    DonGia = gia,
                    SoLuong = item.SoLuong,
                    TongTien = item.TongTien,
                    GiaDaGiam = giaDaGiam,
                    PhanTramGiam = phanTramGiam
                };
            });

            var viewModelArray = await Task.WhenAll(viewModelTasks);
            var viewModel = viewModelArray.ToList();

            return View(viewModel);
        }
        [HttpPost]
        public async Task<IActionResult> Remove(Guid idGioHangChiTiet)
        {
            await _gioHangChiTietService.DeleteAsync(idGioHangChiTiet);

            return RedirectToAction("Card");
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
                        var sanPhamChiTiet = await _sanPhamChiTietService.GetSanPhamChiTietById(item.IdSanPhamChiTiet);

                        // Calculate total quantity in cart for the specific product
                        double totalQuantityInCart = await _gioHangChiTietService.GetTotalQuantityBySanPhamChiTietIdAsync(item.IdSanPhamChiTiet, item.IdGioHang);

                        // Calculate available stock
                        double availableStock = sanPhamChiTiet.SoLuong + item.SoLuong - totalQuantityInCart;

                        // Check if requested quantity exceeds available stock
                        if (model.Quantity > availableStock)
                        {
                            return Json(new
                            {
                                success = false,
                                message = $"Số lượng yêu cầu vượt quá số lượng có sẵn cho sản phẩm " +
                                           $"Số lượng có sẵn: {availableStock}, Số lượng yêu cầu: {model.Quantity}"
                            });
                        }

                        // Update item quantity and total price
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
        public async Task<IActionResult> Checkout(List<Guid> selectedItems)
        {
            if (selectedItems == null || !selectedItems.Any())
            {
                var buyItem = HttpContext.Session.GetObject<BuyItemViewModel>("SelectedItem");

                if (buyItem == null)
                {
                    TempData["ErrorMessage"] = "Vui lòng chọn ít nhất một sản phẩm để thanh toán.";
                    return RedirectToAction("Index");
                }

                selectedItems = new List<Guid> { buyItem.IdSanPhamChiTiet };
            }

            // Save selectedItems into session
            HttpContext.Session.SetObject("SelectedItems", selectedItems);

            var (cartItems, thanhToanViewModel) = await GetCartItemsWithAddress(selectedItems);

            if (thanhToanViewModel == null)
            {
                return RedirectToAction("Index");
            }
            var availableVouchers = await GetAvailableVouchersForCustomer();
            Console.WriteLine($"Available Vouchers Count: {availableVouchers?.Count ?? 0}");

            ViewBag.AvailableVouchers = availableVouchers;

            ViewBag.Provinces = await _diaChiService.GetProvincesAsync();
            return View(thanhToanViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> ApplyVoucher(Guid voucherId)
        {
            var selectedItems = HttpContext.Session.GetObject<List<Guid>>("SelectedItems");

            if (selectedItems == null || !selectedItems.Any())
            {
                return Json(new { success = false, message = "Không có sản phẩm nào được chọn" });
            }

            var customerIdString = HttpContext.Session.GetString("IdKhachHang");
            if (string.IsNullOrEmpty(customerIdString) || !Guid.TryParse(customerIdString, out Guid customerId))
            {
                return Json(new { success = false, message = "Vui lòng đăng nhập" });
            }

            try
            {
                var (cartItems, thanhToanViewModel) = await GetCartItemsWithAddress(selectedItems);
                if (thanhToanViewModel == null)
                {
                    return Json(new { success = false, message = "Không tìm thấy thông tin giỏ hàng" });
                }

                var voucher = await _voucherService.GetVoucherByIdAsync(voucherId);
                if (voucher == null)
                {
                    return Json(new { success = false, message = "Voucher không tồn tại" });
                }

                // Kiểm tra số lượng voucher
                if (voucher.SoLuongVoucherConLai <= 0)
                {
                    return Json(new { success = false, message = "Voucher đã hết" });
                }

                double totalOrderValue = cartItems.Sum(item => item.Price * item.Quantity);

                // Kiểm tra điều kiện áp dụng voucher
                if (voucher.GiaTriDonHangToiThieu.HasValue && totalOrderValue < voucher.GiaTriDonHangToiThieu.Value)
                {
                    return Json(new
                    {
                        success = false,
                        message = $"Đơn hàng phải có giá trị tối thiểu {voucher.GiaTriDonHangToiThieu.Value:N0}đ để sử dụng voucher này"
                    });
                }

                // Tính giảm giá
                double discountAmount = CalculateDiscountAmount(voucher, totalOrderValue);

                // Giảm số lượng voucher
                voucher.SoLuongVoucherConLai -= 1;

                await _voucherService.UpdateAsync(voucher);

                return Json(new
                {
                    success = true,
                    message = "Áp dụng voucher thành công",
                    discountAmount = discountAmount,
                    totalAfterDiscount = totalOrderValue - discountAmount,
                    voucherId = voucher.VoucherId,
                    remainingQuantity = voucher.SoLuongVoucherConLai
                });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = "Có lỗi xảy ra khi áp dụng voucher" });
            }
        }

        private double CalculateDiscountAmount(Voucher voucher, double totalOrderValue)
        {
            double discountAmount = 0;
            if (voucher.LoaiGiamGia == 1) // Giảm theo %
            {
                discountAmount = totalOrderValue * (voucher.GiaTriGiam / 100.0);

                // Kiểm tra giới hạn giảm tối đa
                if (voucher.SoTienToiDa.HasValue)
                {
                    discountAmount = Math.Min(discountAmount, voucher.SoTienToiDa.Value);
                }
            }
            else // Giảm theo số tiền cố định
            {
                discountAmount = voucher.GiaTriGiam;
            }

            return Math.Min(discountAmount, totalOrderValue);
        }
        private async Task<List<Voucher>> GetAvailableVouchersForCustomer()
        {
            var customerIdString = HttpContext.Session.GetString("IdKhachHang");
            Console.WriteLine($"Customer ID from session: {customerIdString}");

            if (string.IsNullOrEmpty(customerIdString) || !Guid.TryParse(customerIdString, out Guid customerId))
            {
                Console.WriteLine("Customer ID is null or cannot be parsed");
                return new List<Voucher>();
            }

            try
            {
                var vouchers = await _voucherService.GetAvailableVouchersForCustomerAsync(customerId);

                Console.WriteLine($"Found {vouchers.Count} available vouchers");
                foreach (var voucher in vouchers)
                {
                    Console.WriteLine($"Voucher Details: ID={voucher.VoucherId}, Code={voucher.MaVoucher}, Description={voucher.MoTaVoucher}");
                }

                return vouchers;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting available vouchers: {ex.Message}");
                Console.WriteLine($"Stack Trace: {ex.StackTrace}");
                return new List<Voucher>();
            }
        }
        // Thanh Toán
        #region ThanhToan
        private async Task<bool> SaveOrder(List<CartItemViewModel> cartItems, ThanhToanViewModel thanhToanViewModel, Guid customerId, string giaoDich, string pttt, string trangThaiThanhToan)
        {
            try
            {
                var idGioHang = await _cardService.GetCartIdByCustomerIdAsync(customerId);
                double totalDonHang = cartItems.Sum(item => item.Price * item.Quantity);
                double totalHoaDon = totalDonHang;

                var order = new HoaDon
                {
                    IdHoaDon = Guid.NewGuid(),
                    MaDon = GenerateOrderNumber(),
                    NguoiNhan = thanhToanViewModel.NguoiNhan,
                    SoDienThoaiNguoiNhan = thanhToanViewModel.SoDienThoai,
                    DiaChiGiaoHang = $"{thanhToanViewModel.ProvinceName}, {thanhToanViewModel.DistrictName}, {thanhToanViewModel.WardName}",
                    LoaiHoaDon = "Trực tuyến",
                    TienShip = thanhToanViewModel.PhiVanChuyen,
                    TongTienDonHang = totalDonHang,
                    TongTienHoaDon = totalHoaDon,
                    NgayTao = DateTime.Now,
                    NguoiTao = "Khách hàng",
                    KichHoat = 1,
                    TrangThai = "Chờ Xác Nhận",
                    IdKhachHang = customerId,
                    IdNhanVien = null
                };

                var orderDetails = cartItems.Select(item => new HoaDonChiTiet
                {
                    IdHoaDonChiTiet = Guid.NewGuid(),
                    DonGia = item.Price,
                    SoLuong = item.Quantity,
                    TongTien = item.Price * item.Quantity,
                    KichHoat = 1,
                    IdHoaDon = order.IdHoaDon,
                    IdSanPhamChiTiet = item.IdSanPhamChiTiet
                }).ToList();

                var lichSu = new LichSuHoaDon
                {
                    IdLichSuHoaDon = Guid.NewGuid(),
                    ThaoTac = order.TrangThai,
                    NgayTao = DateTime.Now,
                    NguoiThaoTac = "Khách hàng",
                    TrangThai = "1",
                    IdHoaDon = order.IdHoaDon,
                };

                var lichSuThanhToan = new LichSuThanhToan
                {
                    IdLichSuThanhToan = Guid.NewGuid(),
                    SoTien = totalHoaDon,
                    TienThua = 0,
                    NgayTao = DateTime.Now,
                    LoaiGiaoDich = giaoDich,
                    Pttt = pttt,
                    NguoiThaoTac = "Khách hàng",
                    TrangThai = trangThaiThanhToan,
                    IdHoaDon = order.IdHoaDon,
                    IdNhanVien = null
                };

                await _hoaDonService.AddAsync(order);
                await _hoaDonChiTietService.AddAsync(orderDetails);
                await _lichSuHoaDonService.AddAsync(lichSu);
                await _lichSuThanhToanService.AddAsync(lichSuThanhToan);

                // Xóa giỏ hàng
                await _gioHangChiTietService.ClearCartByIdAsync(idGioHang);

                return true;
            }
            catch
            {
                return false;
            }
        }
        [HttpPost]
        public async Task<IActionResult> ProcessCheckout(ThanhToanViewModel model)
        {
            var selectedItems = HttpContext.Session.GetObject<List<Guid>>("SelectedItems");

            if (selectedItems == null || !selectedItems.Any())
            {
                ModelState.AddModelError("", "Không có sản phẩm nào được chọn. Vui lòng quay lại giỏ hàng.");
                return View("Checkout", model);
            }

            var (cartItems, thanhToanViewModel) = await GetCartItemsWithAddress(selectedItems);

            if (thanhToanViewModel == null || !ModelState.IsValid)
            {
                return View("Checkout", thanhToanViewModel);
            }

            model.CartItems = cartItems;
            var customerIdString = HttpContext.Session.GetString("IdKhachHang");
            if (string.IsNullOrEmpty(customerIdString) || !Guid.TryParse(customerIdString, out Guid customerId))
            {
                return Unauthorized(new { message = "Customer not found in session." });
            }

            double totalDonHang = cartItems.Sum(item => item.Price * item.Quantity);
            double totalHoaDon = totalDonHang;

            if (model.PaymentMethod == "cash_on_delivery")
            {
                var result = await SaveOrder(cartItems, thanhToanViewModel, customerId, "Thanh Toán COD", "Tiền Mặt", "Chờ Thanh Toán");
                if (result)
                {
                    return RedirectToAction("Index", new { message = "Đặt hàng thành công!" });
                }
            }
            else if (model.PaymentMethod == "online_payment")
            {
                var vnPay = new PaymentInformationModel()
                {
                    Amount = totalHoaDon,
                    CreatDate = DateTime.Now,
                    Description = "Thanh Toán VnPay",
                    FullName = thanhToanViewModel.NguoiNhan,
                    OrderId = Guid.NewGuid(), // Tạo mã tạm
                };

                string paymentUrl = _vnPayService.CreatePaymentUrl(vnPay, HttpContext);

                // Lưu thông tin tạm thời vào session
                HttpContext.Session.SetString("TemporaryOrderId", vnPay.OrderId.ToString());
                HttpContext.Session.SetObject("CartItems", cartItems);
                HttpContext.Session.SetObject("ThanhToanViewModel", thanhToanViewModel);

                return Redirect(paymentUrl);
            }

            return View("Checkout", thanhToanViewModel);
        }


        // VnPay    
        [HttpGet]
        public async Task<IActionResult> ReturnVNPay()
        {
            var response = _vnPayService.PaymentExecute(Request.Query);
            if (response.VnPayResponseCode == "00") // Thanh toán thành công
            {
                var temporaryOrderId = HttpContext.Session.GetString("TemporaryOrderId");
                var cartItems = HttpContext.Session.GetObject<List<CartItemViewModel>>("CartItems");
                var thanhToanViewModel = HttpContext.Session.GetObject<ThanhToanViewModel>("ThanhToanViewModel");
                var customerIdString = HttpContext.Session.GetString("IdKhachHang");
                if (string.IsNullOrEmpty(customerIdString) || !Guid.TryParse(customerIdString, out Guid customerId) ||
                cartItems == null || thanhToanViewModel == null || string.IsNullOrEmpty(temporaryOrderId))
                {
                    return BadRequest("Dữ liệu thanh toán không hợp lệ.");
                }
                var result = await SaveOrder(cartItems, thanhToanViewModel, customerId, "Thanh Toán VnPay", "VNPay", "Đã thanh toán");
                if (result)
                {
                    HttpContext.Session.Remove("TemporaryOrderId");
                    HttpContext.Session.Remove("CartItems");
                    HttpContext.Session.Remove("ThanhToanViewModel");
                    return RedirectToAction("Index", new { message = "Thanh toán thành công!" });
                }
            }

            return RedirectToAction("Checkout", new { message = "Thanh toán thất bại!" });
        }



        #endregion

        private string GenerateOrderNumber()
        {
            return $"DON{GetRandomOrderNumber()}";
        }

        private string GetRandomOrderNumber()
        {
            Random random = new Random();
            int orderNumber = random.Next(10000, 100000);
            return orderNumber.ToString();
        }


        private async Task<(List<CartItemViewModel> cartItems, ThanhToanViewModel thanhToanViewModel)> GetCartItemsWithAddress(List<Guid> selectedItems)
        {
            var customerIdString = HttpContext.Session.GetString("IdKhachHang");
            Guid customerId;

            // Check if customer ID is available
            if (string.IsNullOrEmpty(customerIdString) || !Guid.TryParse(customerIdString, out customerId))
            {
                // No customer found, attempt to get BuyItem from session
                var buyItem = HttpContext.Session.GetObject<BuyItemViewModel>("SelectedItem");

                if (buyItem == null)
                {
                    return (new List<CartItemViewModel>(), null);
                }

                // Create a cart item from the buyItem
                var singleCartItems = new List<CartItemViewModel>
        {
            new CartItemViewModel
            {
                IdSanPhamChiTiet = buyItem.IdSanPhamChiTiet,
                ProductName = buyItem.ProductName,
                Quantity = buyItem.Quantity,
                Price = buyItem.Price
            }
        };

                // Create a ThanhToanViewModel without customer address
                var viewModelWithoutAddress = new ThanhToanViewModel
                {
                    CartItems = singleCartItems,
                    PhiVanChuyen = 0.0 // Initialize shipping cost to 0
                };

                return (singleCartItems, viewModelWithoutAddress);
            }

            // Existing logic to get cart items and address for a logged-in customer
            var idGioHang = await _cardService.GetCartIdByCustomerIdAsync(customerId);
            if (idGioHang == Guid.Empty)
            {
                return (new List<CartItemViewModel>(), null);
            }

            var gioHangChiTiets = await _gioHangChiTietService.GetByGioHangIdAsync(idGioHang);
            if (gioHangChiTiets == null || !gioHangChiTiets.Any())
            {
                // Fallback to buyItem if no items are found in the cart
                var buyItem = HttpContext.Session.GetObject<BuyItemViewModel>("SelectedItem");

                if (buyItem != null)
                {
                    var fallbackCartItems = new List<CartItemViewModel>
            {
                new CartItemViewModel
                {
                    IdSanPhamChiTiet = buyItem.IdSanPhamChiTiet,
                    ProductName = buyItem.ProductName,
                    Quantity = buyItem.Quantity,
                    Price = buyItem.Price
                }
            };

                    var diaChiKhachHang2 = await _diaChiService.GetDefaultAddressByCustomerIdAsync(customerId);
                    double phiVanChuyen2 = 0.0;

                    if (diaChiKhachHang2 != null)
                    {
                        // Calculate shipping fee for the buy item
                        int toDistrictId = diaChiKhachHang2.DistrictId; // Destination district ID
                        string toWardCode = diaChiKhachHang2.WardId; // Destination ward code

                        // Assuming constant dimensions and weight for the buy item
                        double height2 = 50; // Example height in cm
                        double length2 = 20; // Example length in cm
                        double width2 = 20; // Example width in cm
                        int serviceTypeId2 = 2; // Example service type ID
                        int fromDistrictId2 = 3440; // Example district ID for shipping origin
                        string fromWardCode2 = "13005"; // Example ward code for shipping origin

                        phiVanChuyen2 = await _giaoHangNhanhService.CalculateShippingFee(
                            fromDistrictId2,
                            fromWardCode2,
                            toDistrictId,
                            toWardCode,
                            height2,
                            length2,
                            buyItem.Quantity * 200, // Total weight in grams
                            width2,
                            serviceTypeId2,
                            buyItem.ProductName,
                            (int)buyItem.Quantity
                        );
                    }

                    var viewModelFallback = new ThanhToanViewModel
                    {
                        CartItems = fallbackCartItems,
                        PhiVanChuyen = phiVanChuyen2 // Set shipping cost
                    };

                    return (fallbackCartItems, viewModelFallback);
                }

                return (new List<CartItemViewModel>(), null);
            }

            var cartItems = new List<CartItemViewModel>();
            var diaChiKhachHang = await _diaChiService.GetDefaultAddressByCustomerIdAsync(customerId);

            double totalWeight = 0.0;
            double height = 50; // Example height in cm
            double length = 20; // Example length in cm
            double width = 20; // Example width in cm
            int serviceTypeId = 2; // Example service type ID
            double phiVanChuyen = 0.0;

            int fromDistrictId = 3440; // Example district ID for shipping origin
            string fromWardCode = "13005"; // Example ward code for shipping origin

            try
            {
                Console.WriteLine($"Selected Items Count: {selectedItems.Count}");

                foreach (var item in gioHangChiTiets)
                {
                    if (selectedItems.Contains(item.IdGioHangChiTiet))
                    {
                        var sanPham = await _sanPhamChiTietService.GetSanPhamByIdSanPhamChiTietAsync(item.IdSanPhamChiTiet);
                        var cartItem = new CartItemViewModel
                        {
                            IdSanPhamChiTiet = item.IdSanPhamChiTiet,
                            ProductName = sanPham?.TenSanPham ?? "Unknown Product",
                            Quantity = item.SoLuong,
                            Price = item.SoLuong > 0 ? item.TongTien / item.SoLuong : 0
                        };

                        cartItems.Add(cartItem);
                        totalWeight += cartItem.Quantity * 200; // Assuming each item weighs 200 grams

                        if (diaChiKhachHang != null)
                        {
                            int toDistrictId = diaChiKhachHang.DistrictId; // Destination district ID
                            string toWardCode = diaChiKhachHang.WardId; // Destination ward code

                            // Calculate shipping fee
                            phiVanChuyen += await _giaoHangNhanhService.CalculateShippingFee(
                                fromDistrictId,
                                fromWardCode,
                                toDistrictId,
                                toWardCode,
                                height,
                                length,
                                cartItem.Quantity * 200, // Total weight in grams
                                width,
                                serviceTypeId,
                                cartItem.ProductName,
                                (int)cartItem.Quantity
                            );
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Product {item.IdSanPhamChiTiet} is not selected.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error calculating shipping fee: {ex.Message}");
                phiVanChuyen = 0.0; // Reset shipping fee on error
            }

            if (cartItems.Count == 0)
            {
                // If cart items are still empty, fallback to the buy item
                var buyItem = HttpContext.Session.GetObject<BuyItemViewModel>("SelectedItem");
                if (buyItem != null)
                {
                    cartItems.Add(new CartItemViewModel
                    {
                        IdSanPhamChiTiet = buyItem.IdSanPhamChiTiet,
                        ProductName = buyItem.ProductName,
                        Quantity = buyItem.Quantity,
                        Price = buyItem.Price
                    });

                    // Get customer address for shipping calculation
                    if (diaChiKhachHang != null)
                    {
                        int toDistrictId = diaChiKhachHang.DistrictId; // Destination district ID
                        string toWardCode = diaChiKhachHang.WardId; // Destination ward code

                        // Calculate shipping fee for the buy item
                        phiVanChuyen = await _giaoHangNhanhService.CalculateShippingFee(
                            fromDistrictId,
                            fromWardCode,
                            toDistrictId,
                            toWardCode,
                            height,
                            length,
                            buyItem.Quantity * 200, // Total weight in grams
                            width,
                            serviceTypeId,
                            buyItem.ProductName,
                            (int)buyItem.Quantity
                        );
                    }
                }
            }

            var thanhToanViewModel = new ThanhToanViewModel
            {
                NguoiNhan = diaChiKhachHang?.HoTen,
                SoDienThoai = diaChiKhachHang?.SoDienThoai,
                ProvinceName = diaChiKhachHang?.ProvinceName,
                DistrictName = diaChiKhachHang?.DistrictName,
                WardName = diaChiKhachHang?.WardName,
                DiaChiCuThe = diaChiKhachHang?.MoTa,
                CartItems = cartItems,
                PhiVanChuyen = phiVanChuyen,
                MoTa = diaChiKhachHang?.MoTa
            };

            return (cartItems, thanhToanViewModel);
        }
        //Địa Chỉ
        #region DiaChi
        public IActionResult GetAddressById(Guid id)
        {
            var diaChi = _diaChiService.GetByIdAsync(id);
            if (diaChi == null)
            {
                return NotFound();
            }
            return Json(diaChi);
        }
        //Lấy Danh sách
        public async Task<IActionResult> GetUserAddresses()
        {
            // Lấy IdKhachHang từ session
            var idKhachHang = HttpContext.Session.GetString("IdKhachHang");

            // Kiểm tra nếu IdKhachHang không tồn tại, chuyển hướng đến trang đăng nhập
            if (string.IsNullOrEmpty(idKhachHang))
            {
                return RedirectToAction("Login", "KhachHang");
            }

            // Chuyển đổi IdKhachHang thành Guid
            if (!Guid.TryParse(idKhachHang, out Guid id))
            {
                return BadRequest("Invalid customer ID.");
            }

            // Lấy danh sách địa chỉ của khách hàng
            var diaChiList = await _diaChiService.GetAllAsync(id);

            // Trả về view partial với danh sách địa chỉ
            return PartialView("ListDiaChi", diaChiList);
        }
        //Sửa địa chỉ
        [HttpGet]
        public async Task<IActionResult> EditDC(Guid id)
        {
            var diaChi = await _diaChiService.GetByIdAsync(id);
            await LoadDropDowns(diaChi);
            if (diaChi == null) return NotFound();
            await LoadDropDowns(diaChi);
            return View(diaChi);
        }
        [HttpPost]
        public async Task<IActionResult> EditDC(Guid IdDiaChi, DiaChi dc)
        {
            if (dc.WardId == null)
            {
                ModelState.AddModelError("WardId", "Vui lòng chọn phường/xã.");
                await LoadDropDowns(dc);  // Tải lại các dropdown
                return View(dc);  // Trả về lại view với thông báo lỗi
            }
            if (IdDiaChi == Guid.Empty)
            {
                ModelState.AddModelError("", "ID địa chỉ không hợp lệ.");
                await LoadDropDowns(dc);
                return View(dc);
            }


            if (!ModelState.IsValid)
            {
                await LoadDropDowns(dc);
                return View(dc);
            }
            var IdKhachHang = HttpContext.Session.GetString("IdKhachHang");
            var id = Guid.Parse(IdKhachHang);
            id = dc.IdKhachHang;
            bool success = await _diaChiService.UpdateAsync(IdDiaChi, dc);
            if (success)
            {
                return RedirectToAction("Checkout");
            }

            await LoadDropDowns(dc);
            return View(dc);
        }
        [HttpGet]
        public async Task<IActionResult> GetDistricts(int provinceId)
        {
            if (provinceId == 0)
            {
                return Json(new { error = "Invalid provinceId" });
            }
            var districts = await _diaChiService.GetDistrictsAsync(provinceId);
            if (districts == null || districts.Count == 0)
            {
                return Json(new { error = "No districts found" });
            }
            var districtList = districts.Select(d => new { DistrictId = d.DistrictId, DistrictName = d.DistrictName }).ToList();
            return Json(districtList);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var IdKhachHang = HttpContext.Session.GetString("IdKhachHang");
            if (string.IsNullOrEmpty(IdKhachHang))
            {
                return RedirectToAction("Login", "Account");  // Nếu chưa đăng nhập, chuyển hướng đến trang login
            }
            ViewBag.Provinces = await _diaChiService.GetProvincesAsync();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(DiaChi dc)
        {

            var IdKhachHang = HttpContext.Session.GetString("IdKhachHang");
            var id = Guid.Parse(IdKhachHang);
            int addressCount = await _diaChiService.GetAddressCountByCustomerId(id);
            if (addressCount >= 3)
            {
                ModelState.AddModelError("", "Khách hàng này đã có tối đa 3 địa chỉ.");
                ViewBag.Provinces = await _diaChiService.GetProvincesAsync();
                await LoadDropDownsCreate(dc);
                return View(dc);
            }
            // Kiểm tra địa chỉ mặc định           
            //if (dc.DiaChiMacDinh)
            //{
            //	bool check = await _services.HasDefaultAddressAsync(id);
            //	if (check)
            //	{
            //		ModelState.AddModelError("", "Khách hàng này đã có một địa chỉ mặc định.");
            //                 ViewBag.Provinces = await _services.GetProvincesAsync();
            //                 await LoadDropDownsCreate(dc);
            //		return View(dc);
            //	}
            //}
            if (!ModelState.IsValid)
            {
                foreach (var error in ModelState.Values.SelectMany(v => v.Errors))
                {
                    Console.WriteLine($"Error: {error.ErrorMessage}");  // In lỗi ra console
                }
                ViewBag.Provinces = await _diaChiService.GetProvincesAsync();
                await LoadDropDownsCreate(dc);
                return View(dc);
            }
            if (string.IsNullOrEmpty(IdKhachHang))
            {
                return RedirectToAction("Login", "KhachHang");  // Nếu chưa đăng nhập, chuyển hướng đến trang login
            }
            dc.IdKhachHang = id;
            //Nếu tất cả ok thì thêm =))
            bool success = await _diaChiService.AddAsync(dc);
            if (success)
            {
                return RedirectToAction("Checkout");
            }
            await LoadDropDowns(dc);
            return View(dc);
        }
        [HttpGet]
        public async Task<IActionResult> GetWards(int districtId)
        {
            var wards = await _diaChiService.GetWardsAsync(districtId);
            var wardList = wards.Select(w => new {
                WardId = w.WardId.ToString(),
                WardName = w.WardName
            }).ToList();

            return Json(wardList);
        }
        private async Task LoadDropDowns(DiaChi dc)
        {
            // Lấy danh sách tỉnh từ DB
            ViewBag.Provinces = await _diaChiService.GetProvincesAsync();

            // Nếu ProvinceId có giá trị hợp lệ, lấy danh sách các quận theo ProvinceId
            if (dc != null && dc.ProvinceId > 0)
            {
                ViewBag.Districts = await _diaChiService.GetDistrictsAsync(dc.ProvinceId);
            }
            else
            {
                ViewBag.Districts = new List<District>(); // Danh sách trống nếu dc không có ProvinceId
            }

            // Nếu DistrictId có giá trị hợp lệ, lấy danh sách các phường theo DistrictId
            if (dc != null && dc.DistrictId > 0)
            {
                ViewBag.Wards = await _diaChiService.GetWardsAsync(dc.DistrictId);
            }
            else
            {
                ViewBag.Wards = new List<Ward>(); // Danh sách trống nếu dc không có DistrictId
            }
        }
        public async Task LoadDropDownsCreate(DiaChi dc)
        {
            ViewBag.Districts = dc.ProvinceId != null
                ? await _diaChiService.GetDistrictsAsync(dc.ProvinceId)
                : new List<District>();

            ViewBag.Wards = dc.DistrictId != null
                ? await _diaChiService.GetWardsAsync(dc.DistrictId)
                : new List<Ward>(); // Danh sách trống nếu chưa chọn quận
        }
        #endregion


    }
}
