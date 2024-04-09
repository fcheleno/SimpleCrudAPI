using Microsoft.AspNetCore.Mvc;

namespace SimpleCrudAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PingController : ControllerBase
    {
        private readonly ILogger<PingController> _logger;

        public PingController(ILogger<PingController> logger)
        {
            _logger = logger;
        }

        [HttpGet()]
        public IActionResult Ping()
        {
            return Ok(new
            {
                success = true,
                response = new { version = "1.0" }
            });
        }
    }
}
