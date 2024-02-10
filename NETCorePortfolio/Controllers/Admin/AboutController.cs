using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace NETCorePortfolio.Controllers.Admin
{
    public class AboutController : Controller
    {
        AboutManager aboutManager = new AboutManager(new EfAboutDal());
        public IActionResult Index()
        {
            var values = aboutManager.TGetById(1);
            return View(values);
        }

        [HttpGet]
        public IActionResult EditAbout(int id)
        {
            var values = aboutManager.TGetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult EditAbout(About about)
        {
            aboutManager.TUpdate(about);
            return RedirectToAction("Index");
        }


    }
}
