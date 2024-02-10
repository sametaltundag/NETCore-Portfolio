using Microsoft.AspNetCore.Mvc;

namespace NETCorePortfolio.Controllers.Dashboard
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
