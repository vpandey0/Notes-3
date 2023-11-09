using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using RelationshipOneToMany_FluentApi.Models;


namespace RelationshipOneToMany_FluentApi.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeDepartmentContext employeeDepartmentContext=new EmployeeDepartmentContext();
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetEmployeeDetails() 
        {
            var result=employeeDepartmentContext.Employees.Include(m => m.Department);
            return View(result.ToList());
        }
        [HttpGet]
        public ActionResult CreateEmployeeDetails()
        {
            ViewBag.DepartmentId = new SelectList(employeeDepartmentContext.Departments, "DepartmentId", "DepartmentName");
            return View();
        }
        [HttpPost]
        public ActionResult CreateEmployeeDetails(Employee emp) 
        {
            Employee employee = new Employee();
            employee.Name= emp.Name;
            employee.Email= emp.Email;
            employee.Address= emp.Address;
            employee.Age= emp.Age;
            employee.DepartmentId= emp.DepartmentId;

             employeeDepartmentContext.Employees.Add(employee);
             employeeDepartmentContext.SaveChanges();
             
            

            //ViewBag.DeptId = new SelectList(employeeDepartmentContext.Departments, "DepartmentId", "DepartmentName", employee.DepartmentId);

            employeeDepartmentContext.SaveChanges();
            return RedirectToAction("GetEmployeeDetails");
        }

        [HttpGet]
        public ActionResult DeleteEmployeeDetails()
        {
            
            return View();
        }
        
        [HttpPost]
        public ActionResult DeleteEmployeeDetails(int id)
        {
            Employee employee = employeeDepartmentContext.Employees.Find(id);
            employeeDepartmentContext.Employees.Remove(employee);
            employeeDepartmentContext.SaveChanges();
            return RedirectToAction("GetEmployeeDetails");
        }
        [HttpGet]
        public ActionResult SearchEmployeeDetails()
        {

            return View();
        }
        [HttpPost]
        public ActionResult SearchEmployeeDetails(int id) 
        {
            var temp = employeeDepartmentContext.Employees.Where(m => m.Id == id).Select(m=>new EmpViewModel { Id=m.Id,Name=m.Name})
                .FirstOrDefault();
            return View(temp);
        }
        [HttpGet]
        public ActionResult UpdateEmployeeDetails(int id)
        {
            
            return View(employeeDepartmentContext.Employees.Find(id));
        }
        [HttpPost]
     
        public ActionResult UpdateEmployeeDetails(Employee emp)
        {
            var e = employeeDepartmentContext.Employees.Find(emp.Id);
            e.Name = emp.Name;
            e.Address = emp.Address;
            e.Age = emp.Age;
            employeeDepartmentContext.SaveChanges();
            return View();
        }




    }
}