using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SingleSignApi.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class SecureController : ControllerBase
    {
        [Authorize]
        [HttpGet]
        public IActionResult GetSecureData()
        {
            return Ok(new { message = "This is a protected resource" });
        }
    }
}
