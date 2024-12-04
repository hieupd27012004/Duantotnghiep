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
using System.Net.WebSockets;
using Newtonsoft.Json;

namespace APPMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class VoucherController : Controller
    {
        private readonly IVoucherService _voucherService;
        private readonly IKhachHangService _khachHangService;
        private readonly ILogger<VoucherController> _logger;

        public VoucherController(IVoucherService voucherService, IKhachHangService khachHangService, ILogger<VoucherController> logger)
        {
            _voucherService = voucherService ?? throw new ArgumentNullException(nameof(voucherService));
            _khachHangService = khachHangService;
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        // GET: Admin/Voucher
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            try
            {
                List<Voucher> vouchers = await _voucherService.GetVouchersAsync();
                _logger.LogInformation($"Retrieved {vouchers.Count} vouchers");
                return View(vouchers);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occured while fetching voucher list");
                return View(new List<Voucher>());
            }
        }
        public async Task<IActionResult> Details(Guid id)
        {
            if (id == Guid.Empty)
            {
                return NotFound("Id cannot be empty");
            }

            try
            {
                var voucher = await _voucherService.GetVoucherByIdAsync(id);
                if (voucher == null)
                {
                    _logger.LogWarning($"Voucher not found for Id: {id}");
                    return NotFound("Voucher not found");
                }
                var khachHangList = await _voucherService.GetKhachHangDaNhanVoucherAsync(id);
                ViewBag.KhachHangList = khachHangList;
                return View(voucher);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error occurred while fetching voucher details with Id: {id}");
                return StatusCode(500, "An error occurred while retrieving the voucher details.");
            }
        }

        // GET: Admin/Voucher/Create
        public async Task<IActionResult> Create()
        {
            ViewBag.KhachHang = await _khachHangService.GetAllKhachHang(); 

            return View();
        }

        // POST: Admin/Voucher/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Voucher voucher, string[] selectedKhachHangIds)
        {
            try
            {
                _logger.LogInformation("Starting to create voucher.");

                // Check if any customer IDs are selected
                if (selectedKhachHangIds == null || selectedKhachHangIds.Length == 0)
                {
                    _logger.LogWarning("No customer IDs selected.");
                    ModelState.AddModelError("", "Please select at least one customer.");
                    return await LoadKhachHangAndReturnView(voucher);
                }

                // Convert from string[] to List<Guid>
                List<Guid> selectedKhachHangGuidIds = selectedKhachHangIds
                    .Select(id => Guid.Parse(id))
                    .ToList();

                // Check ModelState
                if (!ModelState.IsValid)
                {
                    var errors = ModelState.Values.SelectMany(v => v.Errors);
                    foreach (var error in errors)
                    {
                        _logger.LogWarning($"ModelState Error: {error.ErrorMessage}");
                    }
                    return await LoadKhachHangAndReturnView(voucher);
                }

                // Log voucher information before sending the request
                _logger.LogInformation($"Creating voucher with details: {JsonConvert.SerializeObject(voucher)}");

                var result = await _voucherService.CreateAsync(voucher, selectedKhachHangGuidIds);

                if (result)
                {
                    _logger.LogInformation($"Successfully created voucher with ID: {voucher.VoucherId}");
                    TempData["SuccessMessage"] = "Voucher created successfully.";
                    return RedirectToAction(nameof(Index));
                }

                _logger.LogWarning("Failed to create the voucher.");
                ModelState.AddModelError("", "Failed to create the voucher");
                return await LoadKhachHangAndReturnView(voucher);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in Create action");
                ModelState.AddModelError("", $"Error: {ex.Message}");
                return await LoadKhachHangAndReturnView(voucher);
            }
        }

        // Phương thức để load danh sách khách hàng và trả về view
        private async Task<IActionResult> LoadKhachHangAndReturnView(Voucher voucher)
        {
            var khachHangs = await _khachHangService.GetAllKhachHang();
            ViewBag.KhachHang = khachHangs;
            return View(voucher);
        }

        // GET: Admin/Voucher/Edit/5
        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var voucher = await _voucherService.GetVoucherByIdAsync(id);
            if (voucher == null)
            {
                return NotFound();
            }

            // Ensure these values are set
            if (string.IsNullOrEmpty(voucher.NguoiTao))
            {
                voucher.NguoiTao = "Admin"; // Or whatever default value you want
            }
            if (voucher.NgayTao == default)
            {
                voucher.NgayTao = DateTime.Now;
            }

            return View(voucher);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, Voucher voucher)
        {
            try
            {
                if (id != voucher.VoucherId)
                {
                    return NotFound();
                }

                if (ModelState.IsValid)
                {
                    // Ensure required fields are set
                    if (string.IsNullOrEmpty(voucher.NguoiTao))
                    {
                        voucher.NguoiTao = "Admin";
                    }
                    if (voucher.NgayTao == default)
                    {
                        voucher.NgayTao = DateTime.Now;
                    }

                    // Set update information
                    voucher.NgayUpdate = DateTime.Now;
                    voucher.NguoiUpdate = "Admin";

                    var result = await _voucherService.UpdateAsync(voucher);
                    if (result)
                    {
                        TempData["SuccessMessage"] = "Cập nhật voucher thành công";
                        return RedirectToAction(nameof(Index));
                    }
                }

                return View(voucher);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(voucher);
            }
        }
        public async Task<IActionResult> Delete(Guid id)
        {
            if (id == Guid.Empty)
            {
                return NotFound("Id cannot be empty");
            }
            try
            {
                var voucher = await _voucherService.DeleteAsync(id);
                if (voucher != null)
                {
                    var result = await _voucherService.DeleteAsync(id);
                    if (!result)
                    {
                        _logger.LogInformation($"Successfully deleted voucher with Id: {id}");
                        TempData["SuccessMessage"] = "Xoá voucher thành công.";
                    }
                    else
                    {
                        _logger.LogWarning($"Failed to delete voucher with Id: {id}");
                        TempData["ErrorMessage"] = "Failed to delete the voucher.";
                    }
                }
                else
                {
                    _logger.LogWarning($"Attempted to delete non-existent voucher with Id: {id}");
                    TempData["ErrorMessage"] = "Voucher not found.";
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error occured while deleting voucher with Id: {id}");
                TempData["ErrorMessage"] = "An error occurred while deleting the voucher.";
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
