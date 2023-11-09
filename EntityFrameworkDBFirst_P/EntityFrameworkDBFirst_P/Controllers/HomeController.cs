using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EntityFrameworkDBFirst_P.Models;

namespace EntityFrameworkDBFirst_P.Controllers
{
    public class HomeController : Controller
    {
        DBFirstDB_ProcContext dbFirstDB_ProcContext=new DBFirstDB_ProcContext();
     

       
        [HttpGet]
        public ActionResult SearchData() 
        { 
            return View();
        }
        [HttpPost]
        public ActionResult SearchData(Customers_SearchCustomers_Result cs)
        {
            var result=dbFirstDB_ProcContext.Customers_SearchCustomers(cs).ToList();
            return View(result);
        }


        public ActionResult GetCustDetail()
        {
            var t = dbFirstDB_ProcContext.GetCustomer();
            return View(t);

        }



        [HttpGet]
        public ActionResult AddCustDetail()
        {

            return View();
        }
        [HttpPost]
        public ActionResult AddCustDetail(CustomerViewModel cust)
        {
            dbFirstDB_ProcContext.AddCusDetails(cust);
            ModelState.Clear();
            return RedirectToAction("GetCustDetail");
        }
        public ActionResult DeleteCustomers(int Id)
        {
            dbFirstDB_ProcContext.DeleteCusById(Id);
            return RedirectToAction("GetCustDetail");
        }
        [HttpGet]
        public ActionResult UpdateCustomers(int Id)
        {

            return View(dbFirstDB_ProcContext.SearchCustomer(Id));

        }
        [HttpPost]
        public ActionResult UpdateCustomers(Customer customer)
        {
            dbFirstDB_ProcContext.UpdateCustomer(customer);
            ModelState.Clear();
            return RedirectToAction("GetCustDetail");
        }


    }
