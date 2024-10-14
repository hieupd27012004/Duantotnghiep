using AppAPI.IService;
using AppData.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SanPhamChiTietController : ControllerBase
    {
        private readonly ISanPhamChiTietService _service;

        public SanPhamChiTietController(ISanPhamChiTietService service)
        {
            _service = service;
        }

        // GET: api/SanPhamChiTiet/getall
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            try
            {
                var sanPhamChiTiet = _service.GetSanPhamChiTiet();
                return Ok(sanPhamChiTiet);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        // GET: api/SanPhamChiTiet/getbyid?id=<guid>
        [HttpGet("getbyid")]
        public IActionResult Get(Guid id)
        {
            try
            {
                var sanPhamChiTiet = _service.GetSanPhamChitietById(id);
                if (sanPhamChiTiet == null)
                {
                    return NotFound($"SanPhamChiTiet with ID {id} not found.");
                }
                return Ok(sanPhamChiTiet);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        // POST: api/SanPhamChiTiet/them
        [HttpPost("them")]
        public IActionResult Post(SanPhamChiTiet sanPhamChiTiet)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                _service.Create(sanPhamChiTiet);
                return Ok(sanPhamChiTiet);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error : {ex.Message}");
            }
        }

        // PUT: api/SanPhamChiTiet/Sua
        [HttpPut("Sua")]
        public IActionResult Put(SanPhamChiTiet sanPhamChiTiet)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                _service.Update(sanPhamChiTiet);
                return Ok(sanPhamChiTiet);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        // DELETE: api/SanPhamChiTiet/Xoa?id=<guid>
        [HttpDelete("Xoa")]
        public IActionResult Delete(Guid id)
        {
            try
            {
                _service.Delete(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

    }
}
