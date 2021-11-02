using GRA.Application.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace GRA.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AwardsController : ControllerBase
    {
        public AwardsController(IAwardsService _service)
        {
            service = _service;
        }
        private IAwardsService service { get; }

        [HttpGet]
        public IActionResult GetAwardsInterval()
        {
            try
            {
                var result = service.GetAwardsInterval();
                return Ok(result);
            }
            catch (Exception)
            {
                return BadRequest("Error getting reward interval. For more information, please contact your system administrator.");
            }
            
        }
    }
}
