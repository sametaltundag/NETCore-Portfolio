using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace NETCorePortfolio.Views.Shared.Components.MessageList
{
    public class MessageList:ViewComponent
    {
        MessageManager message = new MessageManager(new EfMessageDal());

        public IViewComponentResult Invoke()
        {
            var messages = message.TGetList();
            var lastFiveMessages = messages.TakeLast(5).OrderByDescending(x => x.Date).ToList();
            return View(lastFiveMessages);
        }
    }
}
