using Microsoft.AspNetCore.Mvc;

namespace Geolocator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LookupController : ControllerBase
    {
        [HttpGet]
        public IActionResult Index()
        {
            return null;
        }


    }
}
