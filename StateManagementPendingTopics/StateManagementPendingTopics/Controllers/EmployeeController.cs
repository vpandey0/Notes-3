using StateManagementPendingTopics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace StateManagementPendingTopics.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            string name = (string)TempData["N"];
            Response.Write(name);
            return View();
        }
        public ActionResult Index1(string name)
        {
            TempData["N"] = name;
            return RedirectToAction("Index");
        }
        public ActionResult Index2()
        {
            //User u = new User();
            //u.Name = "Jiya";
            //u.Id = 10101;

            HttpCookie cookie = new HttpCookie("TestCookie");
            cookie.Value = "This is test cookie";
            this.ControllerContext.HttpContext.Response.Cookies.Add(cookie);
         
            
            return RedirectToAction("IndexRemove");
        }
        public ActionResult IndexRemove()
        {

            if (this.ControllerContext.HttpContext.Request.Cookies.AllKeys.Contains("TestCookie"))
            {
                HttpCookie cookie = this.ControllerContext.HttpContext.Request.Cookies["TestCookie"];
                cookie.Expires=DateTime.Now.AddSeconds(1);
                this.ControllerContext.HttpContext.Response.Cookies.Add(cookie);
            }
            if (this.ControllerContext.HttpContext.Request.Cookies.AllKeys.Contains("TestCookie"))
            {

                HttpCookie cookie = this.ControllerContext.HttpContext.Request.Cookies["TestCookie"];

                ViewBag.CookieMessage = cookie.Value;
            }
            return View();
        }
    }
}