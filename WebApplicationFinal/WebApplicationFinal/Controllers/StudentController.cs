using PagedList;
using System;
using System.Web.Mvc;
using WebApplicationFinal.Models;
using WebApplicationFinal.Repository;


namespace WebApplicationFinal.Controllers
{
    public class StudentController : Controller
    {
        IStudentRepository stuRepo=new StudentRepository();
        // GET: Student
        public ActionResult StudentOperation(int? page)
        {
            int pageSize = 5;
            int pageNumber = (page ?? 1);
            var stu=stuRepo.GetStudentData();
            return View(stu.ToPagedList(pageNumber,pageSize));
        }
        [HttpGet]
        public ActionResult AddStudentData()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddStudentData(Student s)
        {
           
                stuRepo.AddStudent(s);
                ModelState.Clear();
            
            return RedirectToAction("StudentOperation");
        }
        [HttpGet]
        public ActionResult StudentSearchById()
        {
           
            return View();
        }
        [HttpPost]
        public ActionResult StudentSearchById(int id)
        {
            var temp = stuRepo.Search(id);
            return View(temp);
        }


        [HttpGet]
        public ActionResult UpdateStudent()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UpdateStudent(Student s)
        {
            
                stuRepo.UpdateData(s);
                ModelState.Clear();
            
            return View();
        }
        [HttpGet]
        public ActionResult DeleteStudent()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DeleteStudent(int id)
        {
            stuRepo.DeleteData(id);
            ModelState.Clear();
            return View();
        }
    }
}