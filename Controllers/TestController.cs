using Microsoft.AspNetCore.Mvc;

namespace netcore_admin.Controllers
{
    public class TestController : Controller
    {
        [HttpGet("api/users")]
        public IActionResult Index()
        {
            return Ok(new { name = "Leo" });
        }
    }
}