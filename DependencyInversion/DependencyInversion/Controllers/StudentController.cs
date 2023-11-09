using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DependencyInversion.Models;
using DependencyInversion.Repository;

namespace DependencyInversion.Controllers
{
    public class StudentController : Controller
    {
        //IStudentRepository _studentRepository=new StudentRepository(); // Tight coupling
        IStudentRepository _studentRepository;
        public StudentController(IStudentRepository studentRepository) // Passing the interface as constructor parameter
        {
            _studentRepository = studentRepository;
        }

        // GET: Student
        public ActionResult Details()
        {
           Student stu= _studentRepository.AddStudentDetails();
            return View(stu);
        }
    }
}