using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace NETCorePortfolio.Views.Shared.Components.OpenProjects
{
    public class OpenProjects:ViewComponent
    {

        Context c = new Context();

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var projects = await  c.Portfolios.OrderBy(p => p.PortfolioID).Take(5).ToListAsync();
            return View(projects);
        }
    }
}
