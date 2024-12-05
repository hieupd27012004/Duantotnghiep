using AppData.Model;
using AppData.Model.Vnpay;
using AppData.ViewModel;
using APPMVC.IService;
using APPMVC.Libraries;
using APPMVC.Service.Vnpay;
using DinkToPdf;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Threading.Tasks;
using static AppData.ViewModel.HoaDonChiTietViewModel;
using SanPhamChiTietViewModel = AppData.ViewModel.HoaDonChiTietViewModel.SanPhamChiTietViewModel;

namespace APPMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BanHangTQController : Controller
    {
        private readonly ISanPhamChiTietService _sanPhamCTService;
        private readonly ISanPhamService _sanPhamService;
        private readonly IKhachHangService _khachHangService;
        private readonly IHoaDonChiTietService _hoaDonChiTietService;
        private readonly IHoaDonService _hoaDonService;
        private readonly INhanVienService _nhanVienService;
        private readonly ILichSuHoaDonService _lichSuHoaDonService;
        private readonly IMauSacService _mauSacService;
        private readonly IKichCoService _kichCoService;
        private readonly ISanPhamChiTietMauSacService _sanPhamChiTietMauSacService;
        private readonly ISanPhamChiTietKichCoService _sanPhamChiTietKichCoService;
        private readonly IHinhAnhService _hinhAnhService;
        private readonly IVnPayService _vnPayServie;
        private readonly IConfiguration _configuration;
        private readonly IDiaChiService _services;
        private readonly ILichSuThanhToanService _lichSuThanhToanService;
        private readonly GiaoHangNhanhService _giaoHangNhanhService;

        public BanHangTQController(
            ISanPhamChiTietService sanPhamChiTietService,
            ISanPhamService sanPhamService,
            IKhachHangService khachHangService,
            IHoaDonChiTietService hoaDonChiTietService,
            IHoaDonService hoaDonService,
            INhanVienService nhanVienService,
            ILichSuHoaDonService lichSuHoaDonService,
            IMauSacService mauSacService,
            IKichCoService kichCoService,
            ISanPhamChiTietMauSacService sanPhamChiTietMauSacService,
            ISanPhamChiTietKichCoService sanPhamChiTietKichCoService,
            IHinhAnhService hinhAnhService,
            IVnPayService vnPayServie,
            IConfiguration configuration,
            IDiaChiService services,
            GiaoHangNhanhService giaoHangNhanhService,
            ILichSuThanhToanService lichSuThanhToanService
            )
        {
            _sanPhamCTService = sanPhamChiTietService;
            _sanPhamService = sanPhamService;
            _khachHangService = khachHangService;
            _hoaDonChiTietService = hoaDonChiTietService;
            _hoaDonService = hoaDonService;
            _nhanVienService = nhanVienService;
            _lichSuHoaDonService = lichSuHoaDonService;
            _mauSacService = mauSacService;
            _kichCoService = kichCoService;
            _sanPhamChiTietMauSacService = sanPhamChiTietMauSacService;
            _sanPhamChiTietKichCoService = sanPhamChiTietKichCoService;
            _hinhAnhService = hinhAnhService;
            _vnPayServie = vnPayServie;
            _configuration = configuration;
            _services = services;
            _lichSuThanhToanService = lichSuThanhToanService;
            _giaoHangNhanhService = giaoHangNhanhService;
        }

        public async Task<ActionResult> Index()
        {
            var hoaDons = await _hoaDonService.GetAllAsync();

            if (hoaDons == null || !hoaDons.Any())
            {
                return View(new List<HoaDonChiTietViewModel>());
            }

            var filteredOrders = hoaDons
                .Where(hd => hd.TrangThai == "Tạo đơn hàng")
                .Select(hd => new HoaDonChiTietViewModel
                {
                    IdHoaDon = hd.IdHoaDon,
                    HoaDon = new HoaDonChiTietViewModel.HoaDonViewModel
                    {
                        MaDon = hd.MaDon
                    }
                })
                .Take(5)
                .ToList();

            return View(filteredOrders);
        }
        [HttpPost]
        public async Task<IActionResult> TaoHD()
        {
            if (!ModelState.IsValid)
            {
                return View("Index");
            }

            var NVIdString = HttpContext.Session.GetString("IdNhanVien");

            if (string.IsNullOrEmpty(NVIdString) || !Guid.TryParse(NVIdString, out Guid NVID))
            {
                return Unauthorized(new { message = "Nhân viên không tồn tại trong phiên làm việc." });
            }

            var currentOrders = await _hoaDonService.GetAllAsync();
            var countPendingOrders = currentOrders.Count(hd => hd.TrangThai == "Tạo đơn hàng");

            if (countPendingOrders >= 5)
            {
                ModelState.AddModelError("", "Không thể tạo thêm đơn hàng. Đã đạt giới hạn tối đa 5 đơn hàng với trạng thái 'Tạo đơn hàng'.");
                return View("Index");
            }

            var order = new HoaDon
            {
                IdHoaDon = Guid.NewGuid(),
                MaDon = await GenerateOrderNumberAsync(),
                NguoiNhan = null,
                SoDienThoaiNguoiNhan = null,
                DiaChiGiaoHang = null,
                LoaiHoaDon = "Tại Quầy",
                TienShip = 0,
                TongTienDonHang = 0,
                TongTienHoaDon = 0,
                NgayTao = DateTime.Now,
                NguoiTao = "Nhân Viên",
                KichHoat = 1,
                TrangThai = "Tạo đơn hàng",
                IdKhachHang = null,
                IdNhanVien = NVID
            };

            try
            {
                await _hoaDonService.AddAsync(order);

                var lichSu = new LichSuHoaDon
                {
                    IdLichSuHoaDon = Guid.NewGuid(),
                    ThaoTac = order.TrangThai,
                    NgayTao = DateTime.Now,
                    NguoiThaoTac = "Nhân Viên",
                    TrangThai = "1",
                    IdHoaDon = order.IdHoaDon,
                };

                await _lichSuHoaDonService.AddAsync(lichSu);

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Đã xảy ra lỗi khi xử lý đơn hàng. Vui lòng thử lại.");
                Console.WriteLine(ex.Message);
            }

            return View("Index");
        }

        private async Task<string> GenerateOrderNumberAsync()
        {
            var lastOrderNumber = await GetLastOrderNumberAsync();
            int newOrderNumber = lastOrderNumber + 1;
            string newOrderNumberString = $"HD{newOrderNumber}";

            while (await IsOrderNumberExists(newOrderNumberString))
            {
                newOrderNumber++;
                newOrderNumberString = $"HD{newOrderNumber}";
            }

            return newOrderNumberString;
        }

        private async Task<int> GetLastOrderNumberAsync()
        {
            var allOrders = await _hoaDonService.GetAllAsync();
            if (allOrders == null || !allOrders.Any())
            {
                return 0;
            }

            var orderNumbers = new List<int>();
            foreach (var order in allOrders)
            {
                if (order.MaDon.Length > 2 &&
                    int.TryParse(order.MaDon.Substring(2), out int orderNumber))
                {
                    orderNumbers.Add(orderNumber);
                }
            }

            return orderNumbers.Any() ? orderNumbers.Max() : 0;
        }
        private async Task<bool> IsOrderNumberExists(string orderNumber)
        {
            var existingOrder = await _hoaDonService.GetByOrderNumberAsync(orderNumber);
            return existingOrder != null;
        }

        [HttpGet]
        public async Task<ActionResult> Edit(Guid id)
        {
            if (id == Guid.Empty)
            {
                return BadRequest("ID không hợp lệ.");
            }

            var hoaDon = await _hoaDonService.GetByIdAsync(id);
            if (hoaDon == null)
            {
                return NotFound($"Hóa đơn với ID {id} không tồn tại.");
            }

            var hoaDonChiTietList = await _hoaDonChiTietService.GetByIdHoaDonAsync(id) ?? new List<HoaDonChiTiet>();

            var sanPhamChiTiets = new List<HoaDonChiTietViewModel.SanPhamChiTietViewModel>();

            foreach (var hoaDonChiTiet in hoaDonChiTietList)
            {
                var sanPhamCT = await _sanPhamCTService.GetSanPhamChiTietById(hoaDonChiTiet.IdSanPhamChiTiet);
                if (sanPhamCT != null)
                {
                    var sanPham = await _sanPhamCTService.GetSanPhamByIdSanPhamChiTietAsync(hoaDonChiTiet.IdSanPhamChiTiet);

                    var mauSacList = await _sanPhamChiTietMauSacService.GetMauSacIdsBySanPhamChiTietId(sanPhamCT.IdSanPhamChiTiet);
                    var mauSacTenList = mauSacList.Select(ms => ms.TenMauSac).ToList();

                    var kichCoList = await _sanPhamChiTietKichCoService.GetKichCoIdsBySanPhamChiTietId(sanPhamCT.IdSanPhamChiTiet);
                    var kichCoTenList = kichCoList.Select(kc => kc.TenKichCo).ToList();

                    var hinhAnhs = await _hinhAnhService.GetHinhAnhsBySanPhamChiTietId(sanPhamCT.IdSanPhamChiTiet);

                    sanPhamChiTiets.Add(new HoaDonChiTietViewModel.SanPhamChiTietViewModel
                    {
                        IdSanPhamChiTiet = sanPhamCT.IdSanPhamChiTiet,
                        Quantity = hoaDonChiTiet.SoLuong,
                        Price = sanPhamCT.Gia,
                        ProductName = sanPham?.TenSanPham,
                        MauSac = mauSacTenList,
                        KichCo = kichCoTenList,
                        HinhAnhs = hinhAnhs,
                        IdHoaDonChiTiet = hoaDonChiTiet.IdHoaDonChiTiet
                    });
                }
            }

            double tongTienHang = hoaDonChiTietList.Sum(hoaDonChiTiet => hoaDonChiTiet.SoLuong * hoaDonChiTiet.DonGia);

            var viewModel = new HoaDonChiTietViewModel
            {
                DonGia = tongTienHang,
                GiamGia = hoaDon.TienGiam, 
                TongTien = tongTienHang + (hoaDon.TienShip ?? 0),
                PhiVanChuyen = hoaDon.TienShip,
                HoaDon = new HoaDonChiTietViewModel.HoaDonViewModel
                {
                    IdHoaDon = hoaDon.IdHoaDon,
                    MaDon = hoaDon.MaDon,
                    TrangThai = hoaDon.TrangThai,
                    SoDienThoaiNguoiNhan = hoaDon.SoDienThoaiNguoiNhan,
                    LoaiHoaDon = hoaDon.LoaiHoaDon,
                    DiaChiGiaoHang = hoaDon.DiaChiGiaoHang
                   
                },
                SanPhamChiTiets = sanPhamChiTiets 
            };

            return PartialView("Edit", viewModel);
        }

        public async Task<ActionResult> GetSanPhamChiTietList(Guid idHoaDon)
        {
            try
            {
                var sanPhamChiTietList = await _sanPhamCTService.GetSanPhamChiTiets();

                var sanPhamChiTietViewModels = new List<SanPhamChiTietViewModel>();
                if (sanPhamChiTietList != null && sanPhamChiTietList.Any())
                {
                    var tasks = sanPhamChiTietList.Select(async sanPhamCT =>
                    {
                        var sanPham = await _sanPhamCTService.GetSanPhamByIdSanPhamChiTietAsync(sanPhamCT.IdSanPhamChiTiet);
                        var mauSacList = await _sanPhamChiTietMauSacService.GetMauSacIdsBySanPhamChiTietId(sanPhamCT.IdSanPhamChiTiet);
                        var mauSacTenList = mauSacList.Select(ms => ms.TenMauSac).ToList();

                        var kichCoList = await _sanPhamChiTietKichCoService.GetKichCoIdsBySanPhamChiTietId(sanPhamCT.IdSanPhamChiTiet);
                        var kichCoTenList = kichCoList.Select(kc => kc.TenKichCo).ToList();

                        var hinhAnhs = await _hinhAnhService.GetHinhAnhsBySanPhamChiTietId(sanPhamCT.IdSanPhamChiTiet);

                        sanPhamChiTietViewModels.Add(new SanPhamChiTietViewModel
                        {
                            IdSanPhamChiTiet = sanPhamCT.IdSanPhamChiTiet,
                            Quantity = sanPhamCT.SoLuong,
                            Price = sanPhamCT.Gia,
                            ProductName = sanPham?.TenSanPham,
                            MauSac = mauSacTenList,
                            KichCo = kichCoTenList,
                            HinhAnhs = hinhAnhs
                        });
                    });

                    await Task.WhenAll(tasks);
                }

                return PartialView("~/Areas/Admin/Views/BanHangTQ/ListSanPhamChiTiet.cshtml", (sanPhamChiTietViewModels, idHoaDon));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetSanPhamChiTietList: {ex.Message}\n{ex.StackTrace}");
                return StatusCode(500, new { message = "Đã xảy ra lỗi khi lấy danh sách sản phẩm chi tiết." });
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateSanPhamChiTiet(Guid IdSanPhamChiTiet, Guid IdHoaDon)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var sanPhamChiTiet = await _sanPhamCTService.GetSanPhamChiTietById(IdSanPhamChiTiet);
                if (sanPhamChiTiet == null)
                {
                    return Json(new { success = false, message = "Sản phẩm không tồn tại." });
                }

                int requestedQuantity = 1; // Giả định bạn có thể thay đổi số lượng này từ frontend
                if (requestedQuantity <= 0)
                {
                    return Json(new { success = false, message = "Số lượng phải lớn hơn 0." });
                }

                if (requestedQuantity > sanPhamChiTiet.SoLuong)
                {
                    return Json(new { success = false, message = "Số lượng yêu cầu vượt quá số lượng có sẵn." });
                }

                var hoaDonChiTiet = new HoaDonChiTiet
                {
                    IdHoaDonChiTiet = Guid.NewGuid(),
                    IdHoaDon = IdHoaDon,
                    IdSanPhamChiTiet = sanPhamChiTiet.IdSanPhamChiTiet,
                    DonGia = sanPhamChiTiet.Gia,
                    SoLuong = requestedQuantity,
                    TongTien = sanPhamChiTiet.Gia * requestedQuantity,
                    KichHoat = 1
                };

                // Thêm sản phẩm vào hóa đơn mà không trừ số lượng
                await _hoaDonChiTietService.AddAsync(new List<HoaDonChiTiet> { hoaDonChiTiet });

                // Không trừ số lượng sản phẩm
                // sanPhamChiTiet.SoLuong -= requestedQuantity; // Dòng này đã được bỏ

                // Cập nhật sản phẩm nếu cần, hoặc bỏ qua
                // await _sanPhamCTService.Update(sanPhamChiTiet); // Có thể bỏ nếu không cần cập nhật

                var updatedProductList = await GetSanPhamChiTietList(IdHoaDon);
                return Json(new { success = true, message = "Thêm sản phẩm thành công.", html = updatedProductList });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in CreateSanPhamChiTiet: {ex.Message}");
                return StatusCode(500, new { message = "Đã xảy ra lỗi khi thêm sản phẩm vào hóa đơn." });
            }
        }

        [HttpPost]
        public async Task<IActionResult> UpdateInvoiceDetails([FromBody] HoaDonChiTietViewModel model)
        {
            if (model == null || model.IdHoaDon == Guid.Empty)
            {
                return Json(new { success = false, message = "Dữ liệu hóa đơn không hợp lệ." });
            }

            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage);
                return Json(new { success = false, errors });
            }

            var hoaDonChiTietList = await _hoaDonChiTietService.GetByIdHoaDonAsync(model.IdHoaDon);

            foreach (var item in hoaDonChiTietList)
            {
                var updatedItem = model.SanPhamChiTiets.FirstOrDefault(x => x.IdSanPhamChiTiet == item.IdSanPhamChiTiet);
                if (updatedItem != null)
                {
                    var originalQuantity = item.SoLuong;
                    item.SoLuong = updatedItem.Quantity;

                    var sanPhamCT = await _sanPhamCTService.GetSanPhamChiTietById(item.IdSanPhamChiTiet);
                    if (sanPhamCT == null)
                    {
                        return Json(new { success = false, message = "Chi tiết sản phẩm không tồn tại." });
                    }

                    double quantityChange = item.SoLuong - originalQuantity;

                    item.TongTien = item.SoLuong * sanPhamCT.Gia;

                    await _sanPhamCTService.Update(sanPhamCT);
                }
            }

            await _hoaDonChiTietService.UpdateAsync(hoaDonChiTietList);

            return Json(new { success = true });
        }

        [HttpPost]
        public async Task<IActionResult> XacNhanThanhToan(Guid idHoaDon, Guid? idKhachHang)
        {
            Console.WriteLine($"idKhachHang: {idKhachHang}");
            if (!ModelState.IsValid)
            {
                return BadRequest(new { message = "Dữ liệu không hợp lệ." });
            }

            var NVIdString = HttpContext.Session.GetString("IdNhanVien");
            if (string.IsNullOrEmpty(NVIdString) || !Guid.TryParse(NVIdString, out Guid NVID))
            {
                return Unauthorized(new { message = "Nhân viên không tồn tại trong phiên làm việc." });
            }

            var hoaDonChiTietList = await _hoaDonChiTietService.GetByIdHoaDonAsync(idHoaDon);
            if (hoaDonChiTietList == null)
            {
                return NotFound(new { message = "Không tìm thấy chi tiết hóa đơn." });
            }

            double tongTienHang = 0;
            foreach (var hoaDonChiTiet in hoaDonChiTietList)
            {
                var sanPhamCT = await _sanPhamCTService.GetSanPhamChiTietById(hoaDonChiTiet.IdSanPhamChiTiet);
                if (sanPhamCT != null)
                {
                    double thanhTien = hoaDonChiTiet.SoLuong * hoaDonChiTiet.DonGia;
                    tongTienHang += thanhTien;

                    sanPhamCT.SoLuong -= hoaDonChiTiet.SoLuong; 
                    await _sanPhamCTService.Update(sanPhamCT);
                }
            }

            var hoaDon = await _hoaDonService.GetByIdAsync(idHoaDon);
            if (hoaDon == null)
            {
                return NotFound(new { message = "Hóa đơn không tồn tại." });
            }

            if (idKhachHang.HasValue && idKhachHang.Value != Guid.Empty)
            {
                hoaDon.IdKhachHang = idKhachHang.Value;
                var customer = await _khachHangService.GetIdKhachHang(hoaDon.IdKhachHang);
                if (customer != null)
                {
                    hoaDon.NguoiNhan = customer.HoTen; 
                }
            }
            else
            {
                var newCustomer = new KhachHang
                {
                    IdKhachHang = Guid.NewGuid(),
                    HoTen = "Khách Lẻ",
                    AuthProvider = "1",
                    NgayTao = DateTime.Now,
                    NgayCapNhat = DateTime.Now,
                    NguoiTao = "Nhân Viên",
                    NguoiCapNhat = "Nhân Viên",
                    KichHoat = 1,
                };

                try
                {
                    await _khachHangService.AddKhachHang(newCustomer);
                    hoaDon.IdKhachHang = newCustomer.IdKhachHang;
                    hoaDon.NguoiNhan = newCustomer.HoTen;
                }
                catch (Exception ex)
                {
                    return StatusCode(500, new { message = "Đã xảy ra lỗi khi tạo khách hàng." });
                }
            }

            hoaDon.TienGiam = 0;

            hoaDon.TongTienDonHang = tongTienHang;
            hoaDon.TongTienHoaDon = tongTienHang;
            hoaDon.TrangThai = "Hoàn Thành";

            try
            {
                await _hoaDonService.UpdateAsync(hoaDon);

                var lichSu = new LichSuHoaDon
                {
                    IdLichSuHoaDon = Guid.NewGuid(),
                    ThaoTac = hoaDon.TrangThai,
                    NgayTao = DateTime.Now,
                    NguoiThaoTac = "Nhân Viên",
                    TrangThai = "1",
                    IdHoaDon = hoaDon.IdHoaDon,
                };

                await _lichSuHoaDonService.AddAsync(lichSu);

                var lichSuThanhToan = new LichSuThanhToan
                {
                    IdLichSuThanhToan = Guid.NewGuid(),
                    SoTien = hoaDon.TongTienHoaDon,
                    TienThua = 0, 
                    NgayTao = DateTime.Now,
                    LoaiGiaoDich = "Thanh Toán",
                    Pttt = "Tiền mặt", 
                    NguoiThaoTac = "Nhân Viên", 
                    TrangThai = "Đã thanh toán",
                    IdHoaDon = hoaDon.IdHoaDon,
                    IdNhanVien = NVID 
                };

                await _lichSuThanhToanService.AddAsync(lichSuThanhToan);

                var htmlContent = await GenerateInvoiceHtmlFromTemplate(hoaDon, hoaDonChiTietList);

                var pdfBytes = GeneratePdfFromHtml(htmlContent);

                var tempFilePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "TempFiles");
                if (!Directory.Exists(tempFilePath))
                {
                    Directory.CreateDirectory(tempFilePath);
                }

                var fileName = $"HoaDon_{hoaDon.IdHoaDon}.pdf";
                var fullPath = Path.Combine(tempFilePath, fileName);
                await System.IO.File.WriteAllBytesAsync(fullPath, pdfBytes);
                var fileUrl = $"/TempFiles/{fileName}";

                TempData["SuccessMessage"] = "Thanh toán thành công! Bạn có muốn in hóa đơn không?";
                TempData["FileUrl"] = fileUrl;
                return RedirectToAction("ShowInvoiceMessage");
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Đã xảy ra lỗi khi xác nhận thanh toán." });
            }
        }
        public IActionResult ShowInvoiceMessage()
        {
            return View();
        }

        private async Task<string> GenerateInvoiceHtmlFromTemplate(HoaDon hoaDon, List<HoaDonChiTiet> hoaDonChiTietList)
        {
            string templatePath = Path.Combine(Directory.GetCurrentDirectory(), "Areas", "Admin", "Templates", "InvoiceTemplate.html");

            if (!System.IO.File.Exists(templatePath))
            {
                throw new FileNotFoundException($"Template file not found: {templatePath}");
            }

            string htmlTemplate = await System.IO.File.ReadAllTextAsync(templatePath);
            string chiTietHoaDonHtml = "";

            foreach (var chiTiet in hoaDonChiTietList)
            {
                var sanPhamCT = await _sanPhamCTService.GetSanPhamChiTietById(chiTiet.IdSanPhamChiTiet);
                if (sanPhamCT != null)
                {
                    chiTietHoaDonHtml += $@"
            <tr>
                <td>{sanPhamCT.IdSanPham}</td>
                <td>{chiTiet.SoLuong}</td>
                <td>{chiTiet.DonGia:C}</td>
                <td>{chiTiet.SoLuong * chiTiet.DonGia:C}</td>
            </tr>";
                }
            }

            string finalHtml = htmlTemplate
                .Replace("{{MaDon}}", hoaDon.MaDon.ToString())
                .Replace("{{NgayTao}}", hoaDon.NgayTao.ToString("dd/MM/yyyy"))
                .Replace("{{ChiTietHoaDon}}", chiTietHoaDonHtml)
                .Replace("{{TongTien}}", hoaDon.TongTienHoaDon.ToString("C"));

            return finalHtml;
        }

        private byte[] GeneratePdfFromHtml(string htmlContent)
        {
            var converter = new SynchronizedConverter(new PdfTools());

            var doc = new HtmlToPdfDocument
            {
                GlobalSettings = new GlobalSettings
                {
                    PaperSize = PaperKind.A4,
                    Orientation = Orientation.Portrait,
                    DPI = 300
                }
            };

            doc.Objects.Add(new ObjectSettings
            {
                HtmlContent = htmlContent,
                WebSettings = new WebSettings
                {
                    DefaultEncoding = "utf-8"
                }
            });

            return converter.Convert(doc);
        }
        [HttpPost]
        public async Task<IActionResult> ThanhToanVNPay(Guid idHoaDon)
        {
            var hoaDonChiTietList = await _hoaDonChiTietService.GetByIdHoaDonAsync(idHoaDon);
            if (hoaDonChiTietList == null)
            {
                return NotFound(new { message = "Không tìm thấy chi tiết hóa đơn." });
            }

            double tongTienHang = 0;
            foreach (var hoaDonChiTiet in hoaDonChiTietList)
            {
                var sanPhamCT = await _sanPhamCTService.GetSanPhamChiTietById(hoaDonChiTiet.IdSanPhamChiTiet);
                if (sanPhamCT != null)
                {
                    double thanhTien = hoaDonChiTiet.SoLuong * hoaDonChiTiet.DonGia;
                    tongTienHang += thanhTien;
                }
            }

            var hoaDon = await _hoaDonService.GetByIdAsync(idHoaDon);
            if (hoaDon == null)
            {
                return NotFound(new { message = "Không tìm thấy hóa đơn." });
            }

            // Update invoice totals
            hoaDon.TongTienDonHang = tongTienHang;
            hoaDon.TongTienHoaDon = tongTienHang;
            hoaDon.TienGiam = 0;

            // Check for guest customer and create if needed
            if (hoaDon.IdKhachHang == null || hoaDon.IdKhachHang == Guid.Empty)
            {
                var newCustomer = new KhachHang
                {
                    IdKhachHang = Guid.NewGuid(),
                    HoTen = "Khách Lẻ",
                    AuthProvider = "1",
                    NgayTao = DateTime.Now,
                    NgayCapNhat = DateTime.Now,
                    NguoiTao = "Nhân Viên",
                    NguoiCapNhat = "Nhân Viên",
                    KichHoat = 1,
                };

                try
                {
                    await _khachHangService.AddKhachHang(newCustomer);
                    hoaDon.IdKhachHang = newCustomer.IdKhachHang;
                    hoaDon.NguoiNhan = newCustomer.HoTen;

                    // Store customer information in TempData
                    TempData["IdKhachHang"] = newCustomer.IdKhachHang.ToString();
                    TempData["NguoiNhan"] = newCustomer.HoTen;
                }
                catch (Exception ex)
                {
                    return StatusCode(500, new { message = "Đã xảy ra lỗi khi tạo khách hàng." });
                }
            }

            // Store necessary data in TempData
            TempData["idHoaDon"] = idHoaDon.ToString();
            TempData["TongTienDonHang"] = tongTienHang.ToString(); // Convert to string
            TempData["TongTienHoaDon"] = tongTienHang.ToString(); // Convert to string

            var vnPay = new PaymentInformationModel()
            {
                Amount = tongTienHang,
                CreatDate = DateTime.Now,
                Description = "Thanh Toán VnPay",
                FullName = "Nhân Viên",
                OrderId = Guid.NewGuid(),
            };

            return Redirect(_vnPayServie.CreatePaymentUrl(vnPay, HttpContext));
        }

        public IActionResult ThanhToanLoi()
        {
            return View();
        }

        public IActionResult ThanhToanThanhCong()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> ReturnVNPay()
        {
            var response = _vnPayServie.PaymentExecute(Request.Query);
            if (response == null || response.VnPayResponseCode != "00")
            {
                TempData["Message"] = $"Lỗi Thanh Toán: {response.VnPayResponseCode}";
                return RedirectToAction("ThanhToanLoi");
            }

            // Retrieve idHoaDon from TempData
            if (TempData.TryGetValue("idHoaDon", out var idHoaDonValue) && Guid.TryParse(idHoaDonValue.ToString(), out Guid idHoaDon))
            {
                var hoaDon = await _hoaDonService.GetByIdAsync(idHoaDon);
                if (hoaDon == null)
                {
                    return NotFound(new { message = "Không tìm thấy hóa đơn." });
                }

                // Retrieve totals from TempData and convert back to double
                if (TempData.TryGetValue("TongTienDonHang", out var tongTienDonHangValue) &&
                    double.TryParse(tongTienDonHangValue.ToString(), out double tongTienDonHang))
                {
                    hoaDon.TongTienDonHang = tongTienDonHang;
                }

                if (TempData.TryGetValue("TongTienHoaDon", out var tongTienHoaDonValue) &&
                    double.TryParse(tongTienHoaDonValue.ToString(), out double tongTienHoaDon))
                {
                    hoaDon.TongTienHoaDon = tongTienHoaDon;
                }

                // Retrieve customer information from TempData
                if (TempData.TryGetValue("IdKhachHang", out var idKhachHangValue) &&
                    Guid.TryParse(idKhachHangValue.ToString(), out Guid idKhachHang))
                {
                    hoaDon.IdKhachHang = idKhachHang;
                }

                if (TempData.TryGetValue("NguoiNhan", out var nguoiNhanValue))
                {
                    hoaDon.NguoiNhan = nguoiNhanValue.ToString();
                }


                hoaDon.TienGiam = 0;
                hoaDon.TrangThai = "Hoàn Thành";
                await _hoaDonService.UpdateAsync(hoaDon);

                var hoaDonChiTietList = await _hoaDonChiTietService.GetByIdHoaDonAsync(idHoaDon);
                foreach (var chiTiet in hoaDonChiTietList)
                {
                    var sanPhamCT = await _sanPhamCTService.GetSanPhamChiTietById(chiTiet.IdSanPhamChiTiet);
                    if (sanPhamCT != null)
                    {
                        sanPhamCT.SoLuong -= chiTiet.SoLuong; 
                        await _sanPhamCTService.Update(sanPhamCT); 
                    }
                }

                // Create a new history entry for the invoice
                var lichSu = new LichSuHoaDon
                {
                    IdLichSuHoaDon = Guid.NewGuid(),
                    ThaoTac = hoaDon.TrangThai,
                    NgayTao = DateTime.Now,
                    NguoiThaoTac = "Nhân Viên",
                    TrangThai = "1",
                    IdHoaDon = hoaDon.IdHoaDon,
                };

                await _lichSuHoaDonService.AddAsync(lichSu);

                // Directly create a payment history entry
                var TenNv = HttpContext.Session.GetString("NhanVienName");
                var NVIdString = HttpContext.Session.GetString("IdNhanVien");

                if (string.IsNullOrEmpty(NVIdString) || !Guid.TryParse(NVIdString, out Guid NVID))
                {
                    // Handle unauthorized access or log the issue
                    TempData["Message"] = "Nhân viên không tồn tại trong phiên làm việc.";
                    return RedirectToAction("ThanhToanLoi");
                }

                var lichSuThanhToan = new LichSuThanhToan
                {
                    IdLichSuThanhToan = Guid.NewGuid(),
                    SoTien = hoaDon.TongTienHoaDon,
                    TienThua = 0, 
                    NgayTao = DateTime.Now,
                    LoaiGiaoDich = "Thanh Toán VnPay",
                    Pttt = "VnPay",
                    NguoiThaoTac = TenNv,
                    TrangThai = "Đã thanh toán",
                    IdHoaDon = hoaDon.IdHoaDon,
                    IdNhanVien = NVID
                };

                await _lichSuThanhToanService.AddAsync(lichSuThanhToan);

                TempData["Message"] = "Thanh toán VnPay Thành công";
                return RedirectToAction("ThanhToanThanhCong");
            }

            return NotFound(new { message = "Không tìm thấy hóa đơn." });
        }

        [HttpGet]
        public async Task<IActionResult> SearchCustomer(string search, Guid IdHoadon)
        {
            // Validate the search input
            if (string.IsNullOrWhiteSpace(search))
            {
                return BadRequest("Invalid search criteria.");
            }

            var customer = await _khachHangService.GetCustomerByPhoneOrEmailAsync(search);
            if (customer == null)
            {
                return Ok(new
                {
                    customerName = (string)null,
                    idKhachHang = (Guid?)null,
                    nguoiNhan = (string)null,
                    soDienThoai = (string)null,
                    provinceName = (string)null,
                    districtName = (string)null,
                    wardName = (string)null,
                    moTa = (string)null,
                    idHoaDon = (Guid?)null,
                    phiVanChuyen = 0.0
                });
            }

            // Retrieve the default address for the customer
            var diaChiKhachHang = await _services.GetDefaultAddressByCustomerIdAsync(customer.IdKhachHang);
            double phiVanChuyen = 0.0;

            // Retrieve invoice details based on IdHoadon
            var hoaDonChiTietList = await _hoaDonChiTietService.GetByIdHoaDonAsync(IdHoadon);
            if (hoaDonChiTietList == null || !hoaDonChiTietList.Any())
            {
                return NotFound(new { message = "No invoice details found." });
            }

            // Define shipping parameters
            double totalWeight = 0.0;
            int fromDistrictId = 3440; // Adjust accordingly
            string fromWardCode = "13005"; // Adjust accordingly
            double height = 50; // Item height in cm
            double length = 20; // Item length in cm
            double width = 20; // Item width in cm
            int serviceTypeId = 2; // Shipping service type

            // Calculate the shipping fee
            try
            {
                foreach (var hoaDonChiTiet in hoaDonChiTietList)
                {
                    var sanPhamCT = await _sanPhamCTService.GetSanPhamChiTietById(hoaDonChiTiet.IdSanPhamChiTiet);
                    if (sanPhamCT != null)
                    {
                        // Calculate the total weight for shipping
                        totalWeight += hoaDonChiTiet.SoLuong * 200; // Assuming weight per item is 200 grams

                        // Calculate the shipping fee if the destination address is available
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
                                hoaDonChiTiet.SoLuong * 200, // Total weight for this item
                                width,
                                serviceTypeId,
                                sanPhamCT?.NguoiTao ?? "Unknown Product",
                                (int)hoaDonChiTiet.SoLuong
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error calculating shipping fee: {ex.Message}");
                phiVanChuyen = 0.0; 
            }

            // Return the customer and calculated shipping fee
            return Ok(new
            {
                customerName = customer.HoTen,
                idKhachHang = customer.IdKhachHang,
                nguoiNhan = diaChiKhachHang?.HoTen,
                soDienThoai = diaChiKhachHang?.SoDienThoai,
                provinceName = diaChiKhachHang?.ProvinceName,
                districtName = diaChiKhachHang?.DistrictName,
                wardName = diaChiKhachHang?.WardName,
                moTa = diaChiKhachHang?.MoTa,
                idHoaDon = IdHoadon,
                phiVanChuyen
            });
        }
    }

}