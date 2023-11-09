using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DapperInMVC.Models;
using DapperInMVC.Repository;

namespace DapperInMVC.Controllers
{
    public class HomeController : Controller
    {
        IEmployeeRepository emRepo = new EmployeeRepository();
        [OutputCache(Duration =60)]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetEmployees()
        {
            var t = emRepo.GetEmployeeDetail();
            return View(t);
        }

      
        [HttpPost]
        public ActionResult GetEmployees(int Id)
        {
            var t = emRepo.SearchEmployee(Id);
            return View(t);

        }
        [HttpGet]
        public ActionResult CreateEmployees()
        {
             
            return View();
        }
        [HttpPost]
        public ActionResult CreateEmployees(EmpViewModel emp)
        {
            int result= emRepo.CreateEmployee(emp);
            if(result == 1) 
            {
                ViewBag.res = "Record Saved";
            }

            return View();
        }
        [HttpGet]
        public ActionResult UpdateEmployees(int Id)
        {

            return View(emRepo.SearchEmployee(Id));      
   
        }
        [HttpPost]
        public ActionResult UpdateEmployees( Employee emp)
        {
             emRepo.UpdateEmployee(emp);
            ModelState.Clear();
            return RedirectToAction("GetEmployees");
        }
       

        public ActionResult DeleteEmployees(int Id)
        {
            emRepo.DeleteEmployee(Id);
            return RedirectToAction("GetEmployees");
        }
        //[HttpGet]
        //public ActionResult SearchEmployees()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public ActionResult SearchEmployees(int Id)
        //{
        //   var t= emRepo.SearchEmployee(Id);
        //    return View(t);
        //}

    }
}