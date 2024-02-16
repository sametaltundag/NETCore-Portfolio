using BusinessLayer.Concrete;
using NETCorePortfolio.Areas.Writer.Models;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace NETCorePortfolio.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class ProfileController : Controller
    {

        private readonly UserManager<WriterUser> _userManager;
        NotificationManager notification = new NotificationManager(new EfNotificationDal());

        public ProfileController(UserManager<WriterUser> userManager)
        {
            this._userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            return View(values);
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserViewEditModel p)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);

            if(p.Picture != null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(p.Picture.FileName);
                var imageName = Guid.NewGuid() + extension;
                var saveLocation = resource + "/wwwroot/userimage/" + imageName;

                var stream = new FileStream(saveLocation, FileMode.Create);
                await p.Picture.CopyToAsync(stream);
                values.ImageUrl = imageName;

            }

            values.Name = p.Name;
            values.Surname = p.SUrname;
            var result = await _userManager.UpdateAsync(values);

            if(result.Succeeded)
            {
                return RedirectToAction("Index", "Default");
            }
            return View(values);
        }
    }
}
