using Microsoft.AspNetCore.Mvc;

namespace LibraryAppV2.Api.Controllers
{
    public class LoanController : ControllerBase
    {
        // POST api/loan
        [HttpPost]
        public IActionResult Post()
        {
            return Ok();
        }
        // PUT api/loan
        [HttpPut]
        public IActionResult Put()
        {
            return NoContent();
        }
    }
}
