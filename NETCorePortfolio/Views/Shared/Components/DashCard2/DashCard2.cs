using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace NETCorePortfolio.Views.Shared.Components.DashCard2
{
    public class DashCard2:ViewComponent
    {
        Context c = new Context();

        public IViewComponentResult Invoke()
        {
            var sonMesaj = c.Messages.Where(m => m.Status == true)
                         .OrderByDescending(m => m.Date)
                         .FirstOrDefault();

            if (sonMesaj != null)
            {
                ViewBag.gonderen = sonMesaj.Name;
                ViewBag.sonMesajContent = sonMesaj.Content;
            }
            else
            {
                ViewBag.sonMesajContent = "Henüz bir mesaj bulunamadı.";
            }

            ViewBag.sonProje = c.Portfolios.OrderByDescending(p => p.PortfolioID).FirstOrDefault();
            ViewBag.toplamReferans = c.References.Count();
            return View();
        }
    }
}
