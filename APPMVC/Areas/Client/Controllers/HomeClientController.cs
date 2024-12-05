using AppData.Model;
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
        private readonly ICardService _cardService;
        private readonly IHoaDonService _hoaDonService;
        private readonly IHoaDonChiTietService _hoaDonChiTietService;
        private readonly ILichSuHoaDonService _lichSuHoaDonService;
        private readonly IDiaChiService _diaChiService;
        private readonly ILichSuThanhToanService _lichSuThanhToanService;
        private readonly iVnpayClientService _vnPayService;
        private readonly GiaoHangNhanhService _giaoHangNhanhService;
        public HomeClientController(IGioHangChiTietService gioHangChiTietService, 
                                    IHinhAnhService hinhAnhService, 
                                    ISanPhamChiTietService sanPhamChiTietService, 
                                    ICardService cardService, IHoaDonService hoaDonService, 
                                    IHoaDonChiTietService hoaDonChiTietService, 
                                    ILichSuHoaDonService lichSuHoaDonService, 
                                    IDiaChiService diaChiService, 
                                    GiaoHangNhanhService giaoHangNhanhService, 
                                    iVnpayClientService vnPayService,
                                    ILichSuThanhToanService lichSuThanhToanService
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

                // Kiểm tra và tính phần trăm giảm giá
                if (gia.HasValue && giaDaGiam.HasValue && giaDaGiam < gia)
                {
                    phanTramGiam = Math.Round(((gia.Value - giaDaGiam.Value) / gia.Value) * 100, 2);
                }

                return new GioHangChiTietViewModel
                {
                    IdGioHangChiTiet = item.IdGioHangChiTiet,
                    HinhAnhs = hinhanh,
                    TenSanPham = sanPham?.TenSanPham ?? "Unknown Product",
                    DonGia = item.SoLuong > 0 ? item.TongTien / item.SoLuong : 0,
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

                        double totalQuantityInCart = await _gioHangChiTietService.GetTotalQuantityBySanPhamChiTietIdAsync(item.IdSanPhamChiTiet, item.IdGioHang);

                        double availableStock = sanPhamChiTiet.SoLuong + item.SoLuong - totalQuantityInCart;

                        if (model.Quantity > availableStock)
                        {
                            return Json(new { success = false, message = $"Requested quantity exceeds available stock for" });
                        }

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
            var (cartItems, thanhToanViewModel) = await GetCartItemsWithAddress();

            if (thanhToanViewModel == null)
            {
                return RedirectToAction("Index");
            }

            ViewBag.Provinces = await _diaChiService.GetProvincesAsync();
            thanhToanViewModel.CartItems = cartItems; 
            return View(thanhToanViewModel);
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
            var (cartItems, thanhToanViewModel) = await GetCartItemsWithAddress();

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

            //var idGioHang = await _cardService.GetCartIdByCustomerIdAsync(customerId);
            //double totalDonHang = cartItems.Sum(item => item.Price * item.Quantity);
            //double totalHoaDon = totalDonHang;
            //string diaChiGiaoHang = $"{thanhToanViewModel.ProvinceName}, {thanhToanViewModel.DistrictName}, {thanhToanViewModel.WardName}";
            //string diaChiCT = thanhToanViewModel.DiaChiCuThe;
            //var order = new HoaDon
            //{
            //    IdHoaDon = Guid.NewGuid(),
            //    MaDon = GenerateOrderNumber(),
            //    NguoiNhan = thanhToanViewModel.NguoiNhan,
            //    SoDienThoaiNguoiNhan = thanhToanViewModel.SoDienThoai,
            //    DiaChiGiaoHang = diaChiGiaoHang,
            //    LoaiHoaDon = "Trực tuyến",
            //    TienShip = thanhToanViewModel.PhiVanChuyen,
            //    TongTienDonHang = totalDonHang,
            //    TongTienHoaDon = totalHoaDon,
            //    NgayTao = DateTime.Now,
            //    NguoiTao = "Khách hàng",
            //    KichHoat = 1,
            //    TrangThai = "Chờ Xác Nhận",
            //    IdKhachHang = customerId,
            //    IdNhanVien = null
            //};

            //var orderDetails = cartItems.Select(item => new HoaDonChiTiet
            //{
            //    IdHoaDonChiTiet = Guid.NewGuid(),
            //    DonGia = item.Price,
            //    SoLuong = item.Quantity,
            //    TongTien = item.Price * item.Quantity,
            //    KichHoat = 1,
            //    IdHoaDon = order.IdHoaDon,
            //    IdSanPhamChiTiet = item.IdSanPhamChiTiet
            //}).ToList();

            //try
            //{
            //    await _hoaDonService.AddAsync(order);
            //    await _hoaDonChiTietService.AddAsync(orderDetails);

            //    // Bỏ qua việc trừ số lượng
            //    // foreach (var detail in orderDetails)
            //    // {
            //    //     await DeductStockAsync(detail.IdSanPhamChiTiet, detail.SoLuong);
            //    // }

            //    var lichSu = new LichSuHoaDon
            //    {
            //        IdLichSuHoaDon = Guid.NewGuid(),
            //        ThaoTac = order.TrangThai,
            //        NgayTao = DateTime.Now,
            //        NguoiThaoTac = "Khách hàng",
            //        TrangThai = "1",
            //        IdHoaDon = order.IdHoaDon,
            //    };


            //    if (model.PaymentMethod == "cash_on_delivery")
            //    {
            //        var lichSuThanhToan = new LichSuThanhToan
            //        {
            //            IdLichSuThanhToan = Guid.NewGuid(),
            //            SoTien = order.TongTienHoaDon,
            //            TienThua = 0,
            //            NgayTao = DateTime.Now,
            //            LoaiGiaoDich = "Thanh Toán COD",
            //            Pttt = "Tiền Mặt",
            //            NguoiThaoTac = "Khách hàng",
            //            TrangThai = "Chờ Thanh Toán",
            //            IdHoaDon = order.IdHoaDon,
            //            IdNhanVien = null
            //        };
            //        await _lichSuThanhToanService.AddAsync(lichSuThanhToan);
            //        await _lichSuHoaDonService.AddAsync(lichSu);
            //        await _gioHangChiTietService.ClearCartByIdAsync(idGioHang);
            //        return RedirectToAction("Index", new { message = "Đặt hàng thành công!" });
            //    }
            //    else if (model.PaymentMethod == "online_payment")
            //    {
            //        var vnPay = new PaymentInformationModel()
            //        {
            //            Amount = totalHoaDon,
            //            CreatDate = DateTime.Now,
            //            Description = "Thanh Toán VnPay",
            //            FullName = thanhToanViewModel.NguoiNhan,
            //            OrderId = order.IdHoaDon,
            //        };
            //        string paymentUrl = _vnPayService.CreatePaymentUrl(vnPay, HttpContext);

            //        return Redirect(paymentUrl);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    ModelState.AddModelError("", "An error occurred while processing your order. Please try again.");
            //}

            //return View("Checkout", thanhToanViewModel);
            double totalDonHang = cartItems.Sum(item => item.Price * item.Quantity);
            double totalHoaDon = totalDonHang;

            if (model.PaymentMethod == "cash_on_delivery")
            {
                // Lưu hóa đơn cho COD
                var result = await SaveOrder(cartItems, thanhToanViewModel, customerId, "Thanh Toán COD", "Tiền Mặt", "Chờ Thanh Toán");
                if (result)
                {
                    return RedirectToAction("Index", new { message = "Đặt hàng thành công!" });
                }
            }
            else if (model.PaymentMethod == "online_payment")
            {
                // Tạo URL thanh toán VNPay
                var vnPay = new PaymentInformationModel()
                {
                    Amount = totalHoaDon,
                    CreatDate = DateTime.Now,
                    Description = "Thanh Toán VnPay",
                    FullName = thanhToanViewModel.NguoiNhan,
                    OrderId = Guid.NewGuid(), // Tạo mã tạm
                };

                string paymentUrl = _vnPayService.CreatePaymentUrl(vnPay, HttpContext);
                HttpContext.Session.SetString("TemporaryOrderId", vnPay.OrderId.ToString()); // Lưu mã tạm vào session
                HttpContext.Session.SetObject("CartItems", cartItems); // Lưu giỏ hàng tạm thời
                HttpContext.Session.SetObject("ThanhToanViewModel", thanhToanViewModel); // Lưu thông tin tạm thời

                var modeld = HttpContext.Session.GetObject<ThanhToanViewModel>("ThanhToanViewModel");
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

        // Bỏ qua hàm DeductStockAsync
        // public async Task DeductStockAsync(Guid productId, double quantity)
        // {
        //     var product = await _sanPhamChiTietService.GetSanPhamChiTietById(productId);
        //     if (product != null && product.SoLuong >= quantity)
        //     {
        //         product.SoLuong -= quantity;
        //         await _sanPhamChiTietService.Update(product);
        //     }
        //     else
        //     {
        //         throw new Exception("Insufficient stock to fulfill the order.");
        //     }
        // }
        private async Task<(List<CartItemViewModel> cartItems, ThanhToanViewModel thanhToanViewModel)> GetCartItemsWithAddress()
        {
            var customerIdString = HttpContext.Session.GetString("IdKhachHang");
            if (string.IsNullOrEmpty(customerIdString) || !Guid.TryParse(customerIdString, out Guid customerId))
            {
                return (new List<CartItemViewModel>(), null);
            }

            var idGioHang = await _cardService.GetCartIdByCustomerIdAsync(customerId);
            if (idGioHang == Guid.Empty)
            {
                return (new List<CartItemViewModel>(), null);
            }

            var gioHangChiTiets = await _gioHangChiTietService.GetByGioHangIdAsync(idGioHang);
            if (gioHangChiTiets == null || !gioHangChiTiets.Any())
            {
                return (new List<CartItemViewModel>(), null);
            }

            var cartItems = new List<CartItemViewModel>();
            var diaChiKhachHang = await _diaChiService.GetDefaultAddressByCustomerIdAsync(customerId);

            double totalWeight = 0.0;
            double height = 50;
            double length = 20;
            double width = 20;
            int serviceTypeId = 2;
            double phiVanChuyen = 0.0;

            int fromDistrictId = 3440;
            string fromWardCode = "13005";

            try
            {
                foreach (var item in gioHangChiTiets)
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
                    totalWeight += cartItem.Quantity * 200;

                    if (diaChiKhachHang != null)
                    {
                        int toDistrictId = diaChiKhachHang.DistrictId;
                        string toWardCode = diaChiKhachHang.WardId;

                        phiVanChuyen += await _giaoHangNhanhService.CalculateShippingFee(
                            fromDistrictId,
                            fromWardCode,
                            toDistrictId,
                            toWardCode,
                            height,
                            length,
                            cartItem.Quantity * 200,
                            width,
                            serviceTypeId,
                            cartItem.ProductName,
                            (int)cartItem.Quantity
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi tính phí vận chuyển: {ex.Message}");
                phiVanChuyen = 0.0;
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
            return Json(diaChi); // Trả về dữ liệu dưới dạng JSON
        }
        //Lấy Danh sách
        public async Task<IActionResult> GetUserAddresses()
        {
            var IdKhachHang = HttpContext.Session.GetString("IdKhachHang");
            if (string.IsNullOrEmpty(IdKhachHang))
            {
                return RedirectToAction("Login", "KhachHang");
            }
            var id = Guid.Parse(IdKhachHang);
            var diaChiList = await _diaChiService.GetAllAsync(id);
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
                : new List<District>(); // Danh sách trống nếu chưa chọn tỉnh

            ViewBag.Wards = dc.DistrictId != null
                ? await _diaChiService.GetWardsAsync(dc.DistrictId)
                : new List<Ward>(); // Danh sách trống nếu chưa chọn quận
        }
        #endregion

       
    }
}
