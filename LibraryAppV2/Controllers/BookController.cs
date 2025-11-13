using Microsoft.AspNetCore.Mvc;

namespace LibraryAppV2.Api.Controllers
{
    public class BookController : ControllerBase
    {
        [Route("api/books")]

        // POST api/books
        [HttpPost]
        public IActionResult Post()
        {
            return Ok();
        }

        // PUT api/books
        [HttpPut]
        public IActionResult Put()
        {
            return Ok();
        }

        // GET api/books?search=book1 
        [HttpGet]
        public IActionResult Get()
        {
         
            return Ok();
        }

        [HttpDelete]
        // DELETE api/book
        public IActionResult Delete() 
        { 
            return NoContent();
        }

    }
}
