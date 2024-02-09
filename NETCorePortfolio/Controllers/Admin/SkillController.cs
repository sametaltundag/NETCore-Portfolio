using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace NETCorePortfolio.Controllers.Admin
{
    public class SkillController : Controller
    {
        SkillManager skillManager = new SkillManager(new EfSkillDal());

        public IActionResult Index()
        {
            var skil = skillManager.TGetList();
            return View(skil);
        }

        [HttpPost]
        public IActionResult AddSkill(Skill skill)
        {
            skillManager.TAdd(skill);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DeleteSkill(int id)
        {
            var skill = skillManager.TGetById(id);
            skillManager.TDelete(skill);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult EditSkill(Skill skill)
        {
            skillManager.TUpdate(skill);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult GetById(int id)
        {
            var skill = skillManager.TGetById(id);
            if (skill == null)
            {
                return NotFound();
            }

            return Json(new { title = skill.Title, value = skill.Value });
        }

    }
}
