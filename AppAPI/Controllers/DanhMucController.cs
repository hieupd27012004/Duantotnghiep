using AppAPI.Service;
using AppData.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DanhMucController : ControllerBase
    {
        public IDanhMucService _service;
        public DanhMucController(IDanhMucService service)
        {
            _service = service;
        }
        [HttpGet("GetAllDanhMuc")]
        public async Task<ActionResult<List<DanhMuc>>> GetAllDanhMuc()
        {
            return Ok(await  _service.GetAllDanhMuc());
        }
        [HttpGet("GetIdDanhMuc")]
        public async Task<ActionResult<DanhMuc>> GetID(Guid id)
        {
            var getId = await _service.GetIdDanhMuc(id);
            if(getId == null) 
            { 
                return NotFound();
            }
            return Ok(getId);
        }
        [HttpPost("ThemDanhMuc")]
        public async Task<ActionResult<DanhMuc>> CreateDanhMuc(DanhMuc danhMuc)
        {
            try
            {
                _service.CreateDM(danhMuc);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }
        [HttpPut("SuaDanhMuc")]
        public async Task<IActionResult> UpDateDanhMuc(DanhMuc danhMuc)
        {
            await _service.UpdateDM(danhMuc);
            return  Ok(danhMuc);
        }
        [HttpDelete("Xoa")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _service.DeleteDM(id);
            return Ok();
        }
    }
}
