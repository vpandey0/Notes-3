using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DAY2.Controllers
{
    public class CanteenController : Controller
    {
        // GET: Canteen
        public ActionResult Breakfast()
        {
            return View();
        }
    }
}