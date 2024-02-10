using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace NETCorePortfolio.Views.Shared.Components.DashCard
{
    public class DashCard : ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.yetenekSayi = c.Skills.Count();
            ViewBag.mesajSayi = c.Messages.Count();
            ViewBag.okunmamisMesajSayi = c.Messages.Where(x => x.Status == true).Count();
            ViewBag.projeSayi = c.Portfolios.Count();
            ViewBag.hizmetSayi = c.Services.Count();

            return View();
        }
    }
}
