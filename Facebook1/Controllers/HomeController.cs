using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Facebook1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Profile()
        {
            return View();
        }

        public ActionResult MyFriends()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult EditAccount()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Search()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult FriendRequest()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult LogOut()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        
    }
}