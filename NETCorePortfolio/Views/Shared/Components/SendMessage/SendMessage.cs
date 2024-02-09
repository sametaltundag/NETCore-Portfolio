using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace NETCorePortfolio.Views.Shared.Components.SendMessage
{
    public class SendMessage:ViewComponent
    {


        [HttpGet]
        public IViewComponentResult Invoke()
        {
            return View();
        }

        //[HttpPost]
        //public IViewComponentResult Invoke(Message p)
        //{
            
        //    return View();
        //}
    }
}
