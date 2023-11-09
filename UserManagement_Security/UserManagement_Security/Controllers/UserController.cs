using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserManagement_Security.Models;
using UserManagement_Security.Repository;

namespace UserManagement_Security.Controllers
{
    public class UserController : Controller
    {
        IUserRepository userRepo=new UserRepository();
        // GET: User
        [HttpGet]
        public ActionResult CreateUserAccount()
        {
            return View();
        }
       
        [HttpPost]
        public ActionResult CreateUserAccount(User user)
        {
            string i = "Hello";
            
            userRepo.CreateAccount(user);
            return RedirectToAction("UserLoginValidate");
        }
        [HttpGet]
        public ActionResult UserLoginValidate()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UserLoginValidate(LoginViewModel user)
        {
            bool value = userRepo.LoginValidate(user.UserName, user.Password);
            if (value == true)
            {
                Session["Usr"]=user.UserName; // Usr is a variable of Session type and Session will be Persist in IIS memory for 20 min
                
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return Content("Error");
            }
        }
            
    }
}