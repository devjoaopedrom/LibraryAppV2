using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LibraryAppV2.Api.Controllers
{
    public class UserController : ControllerBase
    {
        // GET api/users/1234
        [HttpGet("{id}")]
        public IActionResult GetById()
        {
            return Ok();
        }

        // POST api/users
        [HttpPost]
        [AllowAnonymous]
        public IActionResult Post()
        {
            return Ok();
        }

    }
}
