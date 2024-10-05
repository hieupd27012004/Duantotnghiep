using AppAPI.Service;
using AppData.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ThuongHieuController : ControllerBase
	{
		public IThuongHieuService _service;
        public ThuongHieuController(IThuongHieuService service)
        {
			_service = service; 
        }
		[HttpGet("GetAllTH")]
		public async Task<ActionResult<List<ThuongHieu>>> GetAllThuongHieu() 
		{
			return Ok(await _service.GetAllThuongHieu());
		}
		[HttpGet("GetIdTH")]
		public async Task<ActionResult<ThuongHieu>> GetIdThuongHieu(Guid id) 
		{
			var thuongHieu = await _service.GetIdThuongHieu(id);
			if(thuongHieu == null)
			{
				return NotFound();
			}
			return Ok(thuongHieu);
		}
		[HttpPost("CreateTH")]
		public async Task<ActionResult<ThuongHieu>> CreateThuongHieu(ThuongHieu th)
		{
			await _service.CreateTH(th);
			return Ok(th);
		}
		[HttpPut("UpdateTH")]
		public async Task<ActionResult> UpDateThuongHieu(ThuongHieu th)
		{
			await _service.UpdateTH(th);
			return Ok(th);
		}
		[HttpDelete("DeleteTH")]
		public async Task<ActionResult> DeleteThuongHieu(Guid id)
		{
			await _service.DeleteTH(id);
			return Ok();
		}
    }
}
