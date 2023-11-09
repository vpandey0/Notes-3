using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Day1MVC.Models;
namespace Day1MVC.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Course()
        {
//            int id = 101;
//            ViewBag.Id = id;
            CourseClass obj = new CourseClass();
            obj.Id = 1;
            obj.Name = "Test";
            ViewBag.Co = obj;
            return View();
        }
        public ActionResult Address()
        {
            string Cname = "Java";
            ViewBag.C = Cname;
            return View();
        }
    }
}