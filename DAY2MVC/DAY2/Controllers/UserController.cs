using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DAY2.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult CreateEmployee()
        {
            return View();
        }
    }
}