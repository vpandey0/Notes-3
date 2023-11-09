using System;
using System.Collections.Generic;
using System.Web.Mvc;
using PracticeMvc.Models;
using PracticeMvc.Repository;
namespace PracticeMvc.Controllers
{
    public class StudentController : Controller
    {
        IStudent stuRepo = new StudentRepo();
        // GET: Student
        [HttpGet]
        public ActionResult AddStudentData()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddStudentData(Student s)
        {
            if(ModelState.IsValid)
            {
                stuRepo.AddStudent(s);
                 ModelState.Clear();
            }
           
           

            return View();
        }
       

          [HttpGet]
        public ActionResult UpdateStudentData() 
        {
            return View();
        }
        [HttpPost]
        public ActionResult UpdateStudentData(Student s)
        {
            if (ModelState.IsValid)
            {
                stuRepo.UpdateStudent(s.Id);
                ModelState.Clear();
            }
            return View();
        }
        [HttpGet]
        public ActionResult DeleteStudentData()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DeleteStudentData(int id)
        {
            stuRepo.DeleteStudent(id);
          
            return View();
        }

        [HttpGet]
        public ActionResult SearchStudentData()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SearchStudentData(int id)
        {
            var temp=stuRepo.SearchStudent(id);
            return View(temp);
        }

        public ActionResult Index()
        {

            return View(stuRepo.GetAllStudents());
        }



    }
}