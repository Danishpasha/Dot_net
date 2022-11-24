using BookReadingEvent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace BookReadingEvent.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Signup()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Signup(User model)
        {
            using (var context = new BookReadingEventEntities())
            {
                context.Users.Add(model);
                context.SaveChanges();

            }
            return RedirectToAction("Login");
        }


        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Models.User model)
        {
            using (var context = new BookReadingEventEntities())
            {
                bool isvalid = context.Users.Any(x => x.Email == model.Email && x.Password == model.Password && x.FullName==model.FullName);

                if (isvalid)
                {
                    
                    FormsAuthentication.SetAuthCookie(model.FullName, false);
                    
                    return RedirectToAction("Index", "Events");
                }
                ModelState.AddModelError("", "Invalid Email or Password");
                return View();
            }



        }
        //public ActionResult Home()
        //{
        //    return View();
        //}
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}
