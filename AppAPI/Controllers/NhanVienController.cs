using AppAPI.IService;
using AppData.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NhanVienController : ControllerBase
    {
        private readonly INhanVienService _service;
        public NhanVienController(INhanVienService service)
        {
            _service = service;
        }
        [HttpGet("GetAllNhanVien")]
        public async Task<ActionResult<List<NhanVien>>> GetAllNhanVien()
        {
            return Ok(await _service.GetAllNhaVien());
        }
        [HttpGet("GetIDNhanVien")]
        public async Task<ActionResult<NhanVien>> GetIdNhanVien(Guid id) 
        {
            var nhanVien = await _service.GetIdNhanVien(id);
            if(nhanVien == null)
            {
                return NotFound();
            }
            return Ok(nhanVien);
        }
        [HttpPost("CreateNhanVien")]
        public async Task<ActionResult<NhanVien>> CreateNhanVien(NhanVien nhanVien)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var createdNhanVien = await _service.CreateNV(nhanVien);
                return CreatedAtAction(nameof(GetIdNhanVien), new { id = createdNhanVien.IdNhanVien }, createdNhanVien);
            }
            catch (Exception ex)
            {
                // Logger.LogError(ex, "Error creating NhanVien");
                return BadRequest($"An error occurred while creating the employee: {ex.Message}");
            }
        }
        [HttpPost("Login")]
        public async Task<IActionResult> LoginKH([FromBody] NhanVien nv)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var kh = await _service.Login(nv.Email, nv.MatKhau);
                    return Ok(kh);
                }
                catch (Exception ex)
                {
                    return BadRequest(new { message = ex.Message });
                }
            }
            return BadRequest(ModelState);
        }
    }
}
