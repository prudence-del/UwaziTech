using Microsoft.AspNetCore.Mvc;
using UwaziTech.API.Model.Request;

namespace UwaziTech.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        [HttpPost("add-user")]
        public IActionResult AddUser(UserRequest request)
        {
            return Ok();
        }

        [HttpGet("pre-request")]
        public IActionResult PreRequest()
        {
            return Ok();
        }

        [HttpPatch("update-user-detail")]
        public IActionResult UpdateUserDetails(UserRequest request)
        {
            return Ok();
        }
    }
}
