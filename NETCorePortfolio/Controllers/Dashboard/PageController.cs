using Microsoft.AspNetCore.Mvc;

namespace NETCorePortfolio.Controllers.Dashboard
{
    public class PageController : Controller
    {
        public PartialViewResult Sidebar()
        {
            return PartialView();
        }

        public PartialViewResult Navbar()
        {
            return PartialView();
        }
    }
}
