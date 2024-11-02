using AppAPI.IService;
using AppData.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiaChiController : ControllerBase
    {
        private readonly IDiaChiService _service;
        public DiaChiController(IDiaChiService service)
        {
            _service = service;
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll(string? name)
        {
            try
            {
                var dc = _service.GetDiaChi(name);
                return Ok(dc);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
        [HttpGet("GetById")]
        public IActionResult Get(Guid id)
        {
            try
            {
                var dc = _service.GetDiaChiById(id);
                if (dc == null)
                {
                    return NotFound($"DiaChi with ID {id} not found.");
                }
                return Ok(dc);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
        [HttpPost("them")]
        public IActionResult Post(DiaChi dc)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                _service.Create(dc);
                return Ok(dc);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
        [HttpPut("Sua")]
        public IActionResult Put(DiaChi diaChi)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                _service.Update(diaChi);
                return Ok(diaChi);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
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
        [HttpGet("GetDiaChiByIdKH")]
        public async Task<ActionResult<List<DiaChi>>> GetAllDiaChiByIdKH(Guid id)
        {
            return Ok(await _service.GetDiaChiByIdKH(id));
        }
        [HttpPut("SuaTheoIdKH")]
        public IActionResult PutIdKh(Guid id, DiaChi diaChi)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result =  _service.UpdateDCbyIdKH(id, diaChi);
                if (result)
                {
                    return Ok(diaChi);
                }
                return NotFound("Địa Chỉ Không Tồn Tại");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}
