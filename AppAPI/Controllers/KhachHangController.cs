using AppAPI.IService;
using AppData;
using AppData.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KhachHangController : ControllerBase
    {
        private readonly IKhachHangService _service;
       
        public KhachHangController(IKhachHangService service)
        {
            _service = service;
            
        }
        [HttpPost("DangKy")]
        public async Task<IActionResult> DangKy([FromBody] KhachHang khachHang)
        {
            try
            {
                var result = await _service.AddKhachHang(khachHang);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }
        [HttpGet("GetAllKhachHang")]
        public async Task<ActionResult<List<KhachHang>>> GetAllKhachHang()
        {
            return Ok(await _service.GetAllKhachHang());
        }
        [HttpPost("Login") ]
        public async Task<IActionResult> LoginKH([FromBody] KhachHang khach)
        {
            if(ModelState.IsValid)
            {
                try
                {
                    var kh = await _service.Login(khach.Email, khach.MatKhau);
                    return Ok(kh);
                }
                catch(Exception ex)
                {
                    return BadRequest(new {message = ex.Message});
                }
            }
            return BadRequest(ModelState);
        }
    }
}
