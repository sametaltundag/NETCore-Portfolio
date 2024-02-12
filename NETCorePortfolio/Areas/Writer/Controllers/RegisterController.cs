using Microsoft.AspNetCore.Mvc;

namespace NETCorePortfolio.Areas.Writer.Controllers
{
    
    public class RegisterController : Controller
    {
        [Area("Writer")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string p)
        {
            return View();
        }
    }
}
