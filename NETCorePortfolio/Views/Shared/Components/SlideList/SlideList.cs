using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace NETCorePortfolio.Views.Shared.Components.SlideList
{
    public class SlideList:ViewComponent
    {
        PortfolioManager portfolio = new PortfolioManager(new EfPortfolioDal());

        public IViewComponentResult Invoke()
        {
            var values = portfolio.TGetList();
            return View(values);
        }
    }
}
