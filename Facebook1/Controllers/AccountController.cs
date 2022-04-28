using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Facebook1.Models;

namespace Facebook1.Controllers
{
    public class AccountController : Controller
    {
        private Account db = new Account();


        // GET: Account
        [HttpGet]
        public ActionResult LogIn()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Verify(Account account)
        {
            return View();
        }
    }
}