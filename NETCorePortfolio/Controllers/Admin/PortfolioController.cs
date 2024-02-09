using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace NETCorePortfolio.Controllers.Admin
{
    public class PortfolioController : Controller
    {
        PortfolioManager portfolio = new PortfolioManager(new EfPortfolioDal());
        public IActionResult Index()
        {
            var values = portfolio.TGetList();
            return View(values);
        }
    }
}
