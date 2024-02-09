using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace NETCorePortfolio.Controllers.Admin
{
    public class ExperienceController : Controller
    {
        ExperienceManager experienceManager = new ExperienceManager(new EfExperienceDal());
        public IActionResult Index()
        {
            var experience = experienceManager.TGetList();

            return View(experience);
        }

        [HttpPost]
        public IActionResult AddExperience(Experience experience)
        {
            experienceManager.TAdd(experience);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DeleteExperience(int id)
        {
            var experience = experienceManager.TGetById(id);
            experienceManager.TDelete(experience);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult EditExperience(Experience experience)
        {
            experienceManager.TUpdate(experience);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult GetById(int id)
        {
            var experience = experienceManager.TGetById(id);
            if (experience == null)
            {
                return NotFound();
            }

            return Json(new { experienceID = experience.ExperienceID, title = experience.Title, company = experience.Company, date=experience.Date });
        }
    }
}
