using Microsoft.AspNetCore.Mvc;

namespace NETCorePortfolio.Controllers.Admin
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
