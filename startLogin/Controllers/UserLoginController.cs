using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace startLogin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserLoginController : ControllerBase
    {

        // POST api/<UserLoginController>
        [HttpPost]
        public IActionResult PostData([FromBody] string value)
        {
            var arr = value.Split('&');
            if (arr.Length != 2)
            {
                return BadRequest("Invalid input for 'password'");
            }
            if (!arr[0].Contains("@") && !arr[0].Contains(".com"))
            {
                return BadRequest(" Invalid input for 'email' \n Invalid input for 'password'");
            }
            return Ok("Successful login");
        }

        // PUT api/<UserLoginController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return NoContent();
        }

    }
}
