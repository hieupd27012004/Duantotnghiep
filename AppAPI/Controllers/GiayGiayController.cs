using AppAPI.Service;
using AppData.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace AppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GiayGiayController : ControllerBase
    {
        private readonly IServicegiaygiay _service;

        public GiayGiayController(IServicegiaygiay service)
        {
            _service = service;
        }
        [HttpGet("getall")]
        public IActionResult Getall()
        {
            var dayGiay = _service.GetDayGiay();
            return Ok(dayGiay);

        }

        // GET api/<ValuesController>/5
        [HttpGet("getbyid")]
        public IActionResult Get(Guid id)
        {
            var dayGiay = _service.GetDayGiayById(id);
            return Ok(dayGiay);
        }

        // POST api/<ValuesController>
        [HttpPost("them")]
        public IActionResult Post(DayGiay dayGiay)
        {
            try
            {
                _service.Create(dayGiay);
                return Ok(dayGiay);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        // PUT api/<ValuesController>/5
        [HttpPut("Sua")]
        public IActionResult Put(DayGiay dayGiay)
        {
            _service.Update(dayGiay);
            return Ok(dayGiay);
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("Xoa")]
        public IActionResult Delete(Guid id)
        {
            _service.Delete(id);
            return Ok();
        }
    }
}