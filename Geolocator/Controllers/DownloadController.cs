using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Geolocator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DownloadController : ControllerBase
    {

        private readonly ILogger<DownloadController> _logger;

        public DownloadController(ILogger<DownloadController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return null;
        }
    }
}
