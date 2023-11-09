using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DummyProject.Repository;
using DummyProject.Models;

namespace DummyProject.Controllers
{
    public class EmployeeController : Controller
    {
        IEmployeeRepository empRepo=new EmployeeRepository();

        // GET: Employee
        [HttpGet]
        public ActionResult CreateEmployee()
        {
         

            return View();
        }
        [HttpPost]
        [ActionName("CreateEmployee")]
        public ActionResult CreateEmployees()
        {
            Employee emp = new Employee();
            emp.Name = Request["Name"];
            emp.Address = Request["Address"];
            empRepo.CreateEmployees(emp);

            return View();
        }
        public void FetchEmployee()
        {
            ICollection<Employee> temp= empRepo.GetEmployees();
            foreach (var item in temp)
            {
                Response.Write(item.Name+" "+temp.Count);
            }

        }
        public void SearchEmployee()
        {
           Employee e= empRepo.SearchEmployees();
            if(e==null)
            {
                Response.Write("not found");
            }
            else
            {
                Response.Write(e.Name+" "+e.Address);
            }
        }
        public void DeleteEmployee()
        {
           Employee e= empRepo.DeleteEmployees();
            if (e == null)
            {
                Response.Write("not found");
            }
            else
            {
                Response.Write(e.Name + "is Deleted ");
            }

        }
        public void UpdateEmployee()
        {
            Employee em= empRepo.UpdateEmployees();
            if (em == null)
            {
                Response.Write(em.Name + "not found");

            }
            else
            {
                Response.Write(em.Name + "Updated");
            }

        }



        [HttpGet]
        public ActionResult CreateEmployeeH()
        {


            return View();
        }
        [HttpPost]
       
        public ActionResult CreateEmployeeH(Employee emp)
        {
           empRepo.CreateEmployees(emp);
            return View();
        }

    }
}