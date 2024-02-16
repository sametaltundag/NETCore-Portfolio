using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace NETCorePortfolio.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class DefaultController : Controller
    {
        NotificationManager notificationManager = new NotificationManager(new EfNotificationDal());

        public IActionResult Index()
        {
            var values = notificationManager.TGetList();
            return View(values);
        }

        [HttpPost]
        public IActionResult AddNotification(Notification notification)
        {
            notificationManager.TAdd(notification);
            return Redirect("/Writer/Default/Index/");
        }

        [HttpGet]
        public IActionResult DeleteNotification(int id)
        {
            var value = notificationManager.TGetById(id);
            notificationManager.TDelete(value);
            return Redirect("/Writer/Default/Index/");
        }

        [HttpGet]
        public IActionResult NotificationDetail(int id)
        {
            var notification = notificationManager.TGetById(id);
            if (notification == null)
            {
                return NotFound();
            }

            return Json(new { id = notification.Id, title = notification.Title, content = notification.Content, date = notification.Date, status= notification.Status });
        }

        [HttpPost]
        public IActionResult EditNotification(Notification notification)
        {
            notificationManager.TUpdate(notification);
            return Redirect("/Writer/Default/Index");
        }
    }
}
