using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace NETCorePortfolio.Views.Shared.Components.UserMessage
{
    public class UserMessage:ViewComponent
    {
        UserMessageManager messageManager = new UserMessageManager(new EfUserMessageDal());

        public IViewComponentResult Invoke()
        {
            var values = messageManager.GetUserMessageWithUserService();
            return View(values);
        }
    }
}
