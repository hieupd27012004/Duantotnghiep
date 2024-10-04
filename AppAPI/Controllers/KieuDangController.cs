using AppAPI.Service;
using AppData.Model;
using Microsoft.AspNetCore.Mvc;

namespace AppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KieuDangController : ControllerBase
    {
        private readonly IServiceKieuDang _service;
        public KieuDangController(IServiceKieuDang service)
        {
            _service = service;
        }
        [HttpGet("GetAllKieuDang")]
        public IActionResult GetAll()
        {
            var kieuDang = _service.GetKieuDang();
            return Ok(kieuDang);
        }
        // GET api/<ValuesController>/5
        [HttpGet("GetKieuDangById")]
        public IActionResult Get(Guid id)
        {
            var kieuDang = _service.GetKieuDangById(id);
            return Ok(kieuDang);
        }

        // POST api/<ValuesController>
        [HttpPost("CreateKieuDang")]
        public IActionResult Post(KieuDang kieuDang)
        {
            _service.Create(kieuDang);
            return Ok(kieuDang);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("EditKieuDang")]
        public IActionResult Put(KieuDang kieuDang)
        {
            _service.Update(kieuDang);
            return Ok(kieuDang);
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("DeleteKieuDang")]
        public IActionResult Delete(Guid id)
        {
            _service.Delete(id);
            return Ok();
        }
    }
}
