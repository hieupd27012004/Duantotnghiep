using AppAPI.IService;
using AppData.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GiaoDichController : ControllerBase
    {
        private readonly IGiaoDichService _service;

        public GiaoDichController(IGiaoDichService service)
        {
            _service = service;
        }

        // GET: api/GiaoDich/getall
        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var giaoDichList = await _service.GetAllAsync();
                return Ok(giaoDichList);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        // GET: api/GiaoDich/getbyid?id=<guid>
        [HttpGet("getbyid")]
        public async Task<IActionResult> Get(Guid id)
        {
            try
            {
                var giaoDich = await _service.GetByIdAsync(id);
                if (giaoDich == null)
                {
                    return NotFound($"GiaoDich with ID {id} not found.");
                }
                return Ok(giaoDich);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        // POST: api/GiaoDich/them
        [HttpPost("them")]
        public async Task<IActionResult> Post([FromBody] GiaoDich giaoDich)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                await _service.AddAsync(giaoDich);
                return CreatedAtAction(nameof(Get), new { id = giaoDich.IdGiaoDich }, giaoDich);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        // PUT: api/GiaoDich/sua
        [HttpPut("sua")]
        public async Task<IActionResult> Put([FromBody] GiaoDich giaoDich)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                await _service.UpdateAsync(giaoDich);
                return Ok(giaoDich);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        // DELETE: api/GiaoDich/xoa?id=<guid>
        [HttpDelete("xoa")]
        public async Task<IActionResult> Delete(Guid id)
        {
            try
            {
                await _service.DeleteAsync(id);
                return NoContent(); // 204 No Content
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}
