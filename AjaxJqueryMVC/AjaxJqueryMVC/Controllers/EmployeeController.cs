using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using AjaxJqueryMVC.Models;

namespace AjaxJqueryMVC.Controllers
{
    public class EmployeeController : Controller
    {
        string add = "noida";
        // GET: Employee
        public JsonResult GetData()
        {
            Employee emp = new Employee();
          
            emp.Id = 1;
            emp.Name = "Test";
            return Json(emp, JsonRequestBehavior.AllowGet);
        }
    }
}