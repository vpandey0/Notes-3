using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserManagement_Security.Security;

namespace UserManagement_Security.Controllers
{
    [GuardController]  // This attribute act like Filter
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
       
        public ActionResult LogOut()
        {
            Session.Abandon();
            return RedirectToAction("UserLoginValidate", "User");
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}