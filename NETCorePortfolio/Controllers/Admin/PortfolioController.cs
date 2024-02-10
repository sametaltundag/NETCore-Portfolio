using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace NETCorePortfolio.Controllers.Admin
{
    public class PortfolioController : Controller
    {
        PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolioDal());
        public IActionResult Index()
        {
            var values = portfolioManager.TGetList();
            return View(values);
        }

        [HttpPost]
        public IActionResult AddPortfolio(Portfolio portfolio)
        {
            PortfolioValidator validator = new PortfolioValidator();
            ValidationResult result = validator.Validate(portfolio);

            if (!result.IsValid)
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
                }
                return View(portfolio);
            }

            portfolioManager.TAdd(portfolio);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DeletePortfolio(int id)
        {
            var values = portfolioManager.TGetById(id);
            portfolioManager.TDelete(values);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult EditPortfolio(Portfolio portfolio)
        {
            portfolioManager.TUpdate(portfolio);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult GetById(int id)
        {
            var Portfolio = portfolioManager.TGetById(id);
            if (Portfolio == null)
            {
                return NotFound();
            }

            return Json(new { id = Portfolio.PortfolioID, name = Portfolio.Name, link = Portfolio.Link, imageurl = Portfolio.ImageUrl });
        }
    }
}
