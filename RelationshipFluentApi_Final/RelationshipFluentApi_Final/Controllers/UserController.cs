using RelationshipFluentApi_Final.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RelationshipFluentApi_Final.Models;
using System.Runtime.Remoting.Messaging;

namespace RelationshipFluentApi_Final.Controllers
{
    public class UserController : Controller
    {
        IUserRepository userRepo = new UserRepository();
        // GET: User
        [HttpGet]
        public ActionResult CreateUserProfile()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateUserProfile(UserProfileViewModel userView)
        {
            userRepo.CreateUser(userView);
            
            ModelState.Clear();
            return Json(userView);
        }
      

        //public ActionResult GetUserProfile()
        //{

        //    return View(userRepo.GetUserDetail());
        //}

        public JsonResult GetJson()
        {
            return Json(userRepo.GetUserDetail(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetUserProfile()  //data
        {    

            return View();
        }

        [HttpGet]
        public ActionResult DeleteUserProfile()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DeleteUserProfile(int id)
        { 
            userRepo.DeleteUser(id);
            ModelState.Clear();
            return RedirectToAction("GetUserProfile");
        }
        [HttpGet]
        public ActionResult SearchUserProfile()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SearchUserProfile(User usr)
        {
            return View();
        }
    }
}