using AppAPI.Service;
using AppData.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatLieuController : ControllerBase
    {
        private readonly IChatLieuService _serivce;
        public ChatLieuController(IChatLieuService service)
        {
            _serivce = service;
        }
        // GET: api/<ChatLieuController>
        [HttpGet("GetAllCL")]
        public async Task<ActionResult<List<ChatLieu>>> GetAllChatLieu() 
        { 
            return Ok(await _serivce.GetAllChatLieu());
        }

        // GET api/<ChatLieuController>/5
        [HttpGet("GetIdCL")]
        public async Task<ActionResult<DanhMuc>> GetIdChatLieu(Guid id) 
        {
            var chatLieu = await _serivce.GetIdChatLieu(id);
            if(chatLieu == null)
            {
                return NotFound();
            }
            return Ok(chatLieu);
        }

        // POST api/<ChatLieuController>
        [HttpPost("CreateCL")]
        public async Task<ActionResult<ChatLieu>> CreateChatLieu(ChatLieu chatLieu)
        {
            try
            {
                var createCL = await _serivce.CreateChatLieu(chatLieu);
                return Ok(createCL);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
            
        }

        // PUT api/<ChatLieuController>/5
        [HttpPut("UpdateCL")]
        public async Task<IActionResult> UpdateChatLieu(ChatLieu chatLieu)
        {
            await _serivce.UpdateChatLieu(chatLieu);
            return Ok(chatLieu);
            
        }

        // DELETE api/<ChatLieuController>/5
        [HttpDelete("DeleteCL")]
        public async Task<IActionResult> DeleteChatLieu(Guid idChatLieu)
        {
            await _serivce.DeleteChatLieu(idChatLieu);
            return NoContent();
        }
    } 
}
