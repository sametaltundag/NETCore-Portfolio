using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NETCorePortfolio.Areas.Writer.Models;
using System.Threading.Tasks;

namespace NETCorePortfolio.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class LoginController : Controller
    {

        private readonly SignInManager<WriterUser> _signInManager;

        public LoginController(SignInManager<WriterUser> signInManager)
        {
            this._signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserLoginViewModel p)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(p.Username,p.Password,true,true);

                if (result.Succeeded)
                {
                    return LocalRedirect("/Writer/Profile/Index");
                } else
                {
                    ModelState.AddModelError("", "Hatalı kullanıcı adı veya şifre..");  
                }
            }
            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Login");
        }
    }
}
