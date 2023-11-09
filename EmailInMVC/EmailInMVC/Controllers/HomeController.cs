using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web.Helpers;
using System.Web.Mvc;
using EmailInMVC.Auth;
using EmailInMVC.Database;
using EmailInMVC.Models;

namespace EmailInMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly EmailDbContext db = new EmailDbContext();

        public ActionResult Index()
        {
            if (Session["usr"] != null)
            {

                return RedirectToAction("MailInbox", "MailBox");
            }

            return View();
        }

        public new ActionResult Profile()
        {
            if (Session["usr"] != null)
            {
                var currentUser = db.Users.Where(e => e.Username == (string)Session["usr"]);

                return View(currentUser);
            }
            else
            {
                return HttpNotFound();
            }
        }

        [HttpPost]
        public ActionResult Login(User obj)
        {
            var Result = db.Users
                       .Where(m => m.Username == obj.Username && m.Password == obj.Password)
                       .FirstOrDefault();


            if (Result != null)
            {
                //usr is a variable of session Type 
                //Session will be persist in IIS Memory for next 20 minutes
                Session["Usr"] = obj.Username;
                Session["Password"] = obj.Password;
                Session["Name"] = Result.Name;


                return RedirectToAction("MailInbox", "MailBox");
            }

            else
            {
                return Content("Error: User Not Found");
            }
        }


        public ActionResult Signout()
        {
            Session.Abandon();
            return RedirectToAction("Index", "Home");
        }


        [AuthController]
        public ActionResult SendMail()
        {
            return View();
        }


        [AuthController]
        [HttpPost]
        public ActionResult SendMail(EmailModel model)
        {

            try
            {
                // MailKit package install 
                // MailMessage is a class to get Mail content (body, to, subject, etc.)
                // using parameterized constructor with params (From_Mail, To_Mail, subject, body)
                // Has 3 overloads

                if (!ModelState.IsValid)
                {
                    // Return to the view with validation errors
                    ViewBag.Message = "Model state isn't valid";
                    return View();
                }

                using (MailMessage mm = new MailMessage(model.Email, model.To, model.Subject, model.Body))
                {
                    if (model.Attachment != null && model.Attachment.ContentLength > 0)
                    {
                        string fileName = Path.GetFileName(model.Attachment.FileName);
                        mm.Attachments.Add(new Attachment(model.Attachment.InputStream, fileName));
                    }

                    //saving data to database
                    var emailData = new EmailModel
                    {
                        To = model.To,
                        Subject = model.Subject,
                        Body = model.Body,
                        Email = model.Email,
                        Password = model.Password,
                        Created = DateTime.Now
                    };

                    // bool function -> checks whether the mail body is HTML or not
                    mm.IsBodyHtml = false;

                    // SmtpClient is a class which uses SMTP protocol to send mail
                    using (SmtpClient smtp = new SmtpClient())
                    {
                        smtp.Host = "smtp.gmail.com";

                        // Secure Sockets Layer (SSL) is a standard security technology
                        // for establishing an encrypted link between a server and a client
                        smtp.EnableSsl = true;

                        // Use your Gmail email address and App Password for authentication(if two-factor auth is enabled)
                        NetworkCredential cred = new NetworkCredential(model.Email, "qcui ztyn doln lnmj");

                        smtp.UseDefaultCredentials = false;
                        smtp.Credentials = cred;

                        smtp.Port = 587;

                        smtp.Send(mm);

                        //adding mail to DATABASE
                        db.Emails.Add(emailData);

                        db.SaveChanges();

                        ViewBag.Message = "Email Sent 😊";
                    }
                }

                return View();
            }
            catch (Exception ex)
            {
                ViewBag.Message = ($"An error occurred while sending the email. ☹️ {ex.Message} Please try again later");
                return View();
            }
        }
    }
}
    
