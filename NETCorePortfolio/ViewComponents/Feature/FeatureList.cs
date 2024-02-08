using Microsoft.AspNetCore.Mvc;

namespace NETCorePortfolio.ViewComponents.Feature
{
    public class FeatureList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
