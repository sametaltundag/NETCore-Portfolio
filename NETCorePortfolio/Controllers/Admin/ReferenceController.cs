using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace NETCorePortfolio.Controllers.Admin
{
    public class ReferenceController : Controller
    {
        ReferenceManager referenceManager = new ReferenceManager(new EfReferenceDal());

        public IActionResult Index()
        {
            var values = referenceManager.TGetList();
            return View(values);
        }

        [HttpPost]
        public IActionResult EditReference(Reference reference)
        {
            referenceManager.TUpdate(reference);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DeleteReference(int id)
        {
            var value = referenceManager.TGetById(id);
            referenceManager.TDelete(value);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult AddReference(Reference reference)
        {
            referenceManager.TAdd(reference);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult GetById(int id)
        {
            var reference = referenceManager.TGetById(id);
            if (reference == null)
            {
                return NotFound();
            }

            return Json(new { id = reference.ReferenceID, name = reference.Name, company = reference.Company, comment= reference.Comment, imageurl = reference.ImageUrl });
        }
    }
}
