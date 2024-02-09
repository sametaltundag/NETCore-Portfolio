using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace NETCorePortfolio.Views.Shared.Components.ReferenceList
{
    public class ReferenceList : ViewComponent
    {
        ReferenceManager referenceManager = new ReferenceManager(new EfReferenceDal());

        public IViewComponentResult Invoke()
        {
            var values = referenceManager.TGetList();
            return View(values);
        }
    }
}
