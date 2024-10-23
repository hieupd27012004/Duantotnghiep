using Microsoft.AspNetCore.Mvc;
using APPMVC.IService;
using AppData.Model;
using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace APPMVC.Controllers
{
    [Area("Admin")]
    public class HinhAnhController : Controller
    {
        private readonly IHinhAnhService _hinhAnhService;
        private readonly ILogger<HinhAnhController> _logger;

        public HinhAnhController(IHinhAnhService hinhAnhService, ILogger<HinhAnhController> logger)
        {
            _hinhAnhService = hinhAnhService ?? throw new ArgumentNullException(nameof(hinhAnhService));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<IActionResult> Index()
        {
            try
            {
                var hinhAnhs = await _hinhAnhService.GetHinhAnhsAsync();
                return View(hinhAnhs);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching HinhAnh list");
                return View(new List<HinhAnh>());
            }
        }

        public IActionResult Upload()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Upload(IFormFile file, Guid idMauSac)
        {
            if (file == null || file.Length == 0)
            {
                ModelState.AddModelError("file", "Please select a file to upload.");
                return View();
            }

            // Log the content type for debugging
            _logger.LogInformation($"Received file: {file.FileName}, ContentType: {file.ContentType}");

            var allowedTypes = new List<string> { "image/jpeg", "image/png", "image/gif" };
            if (!allowedTypes.Contains(file.ContentType))
            {
                ModelState.AddModelError("file", "The selected file type is not supported.");
                return View();
            }

            try
            {
                using (var memoryStream = new MemoryStream())
                {
                    await file.CopyToAsync(memoryStream);
                    var hinhAnh = new HinhAnh
                    {
                        IdHinhAnh = Guid.NewGuid(),
                        LoaiFileHinhAnh = file.ContentType,
                        DataHinhAnh = memoryStream.ToArray(),
                        IdMauSac = idMauSac
                    };

                    var result = await _hinhAnhService.UploadAsync(hinhAnh);
                    if (result)
                    {
                        TempData["SuccessMessage"] = "Image uploaded successfully.";
                        return RedirectToAction(nameof(Index));
                    }
                    else
                    {
                        ModelState.AddModelError("", "Failed to upload the image. Please check server logs for details.");
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Exception occurred during image upload");
                ModelState.AddModelError("", $"An error occurred: {ex.Message}");
            }

            return View();
        }

        public async Task<IActionResult> Delete(Guid id)
        {
            try
            {
                var hinhAnh = await _hinhAnhService.GetHinhAnhByIdAsync(id);
                if (hinhAnh != null)
                {
                    var result = await _hinhAnhService.DeleteAsync(id);
                    if (result)
                    {
                        _logger.LogInformation($"Successfully deleted image with Id: {id}");
                        TempData["SuccessMessage"] = "Image deleted successfully.";
                    }
                    else
                    {
                        _logger.LogWarning($"Failed to delete image with Id: {id}");
                        TempData["ErrorMessage"] = "Failed to delete the image.";
                    }
                }
                else
                {
                    _logger.LogWarning($"Attempted to delete non-existent image with Id: {id}");
                    TempData["ErrorMessage"] = "Image not found.";
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error occurred while deleting image with Id: {id}");
                TempData["ErrorMessage"] = "An error occurred while deleting the image.";
            }

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> GetHinhAnhById(Guid id)
        {
            try
            {
                var hinhAnh = await _hinhAnhService.GetHinhAnhByIdAsync(id);
                if (hinhAnh == null)
                {
                    _logger.LogWarning($"Image not found for Id: {id}");
                    return NotFound("Image not found.");
                }
                return File(hinhAnh.DataHinhAnh, hinhAnh.LoaiFileHinhAnh);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error occurred while fetching image with Id: {id}");
                return StatusCode(500, "An error occurred while retrieving the image.");
            }
        }
    }
}