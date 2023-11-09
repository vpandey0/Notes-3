using MVC_Practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Practice.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        List<PracticeClass> stu;
        public StudentController() 
        {
            stu = new List<PracticeClass>()
            {
              new PracticeClass() {CName="Java",fee=12000,Id=121},
              new PracticeClass() {CName="Machine learning",fee=11000,Id=122},
              new PracticeClass() {CName="DBA",fee=11000,Id=123},
              new PracticeClass() {CName="C#",fee=23000,Id=124}
            };
        }

        public ActionResult StudentInfo()
        {
            ViewBag.li=stu;
           
            return View(stu);
        }
    }
}