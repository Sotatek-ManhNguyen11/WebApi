using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly IStringLocalizer<HomeController> _localizer;

        public HomeController(IStringLocalizer<HomeController> localizer)
        {
            _localizer = localizer;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return Ok(_localizer.GetString("Hello"));
        }
    }
}
