using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace NETCorePortfolio.Controllers.Admin
{
    public class FeatureController : Controller
    {
        FeatureManager featureManager = new FeatureManager(new EfFeatureDal());
        public IActionResult Index()
        {
            var values = featureManager.TGetById(1);
            return View(values);
        }

        [HttpGet]
        public IActionResult EditFeature(int id) { 
            var values = featureManager.TGetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult EditFeature(Feature feature)
        {
            featureManager.TUpdate(feature);
            return RedirectToAction("Index");
        }
    }
}
