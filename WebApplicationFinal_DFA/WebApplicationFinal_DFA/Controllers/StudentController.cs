using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationFinal_DFA.Repository;

namespace WebApplicationFinal_DFA.Controllers
{
    public class StudentController : Controller
    {
        IStudentRepository stuRepo = new StudentRepository();
        // GET: Student
        public ActionResult StudentOperation(int? page)
        {
            //int pageSize = 5;
            //int pageNumber = (page ?? 1);
            var stu = stuRepo.GetStudentData();
            return View(stu);
        }
       
        public ActionResult StudentSearchById(int id)
        {
            var temp = stuRepo.Search(id);
            return View(temp);
        }
    }
}