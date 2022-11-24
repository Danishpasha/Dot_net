using System.Web.Mvc;
using Business;
using Shared.DTOs;
using BookReadingEventManagement2.Models;
using BookReadingEventManagement2.Helper;
using Business.Exceptions;
using AutoMapper;

namespace BookReadingEventManagement2.Controllers
{
    public class UserController : Controller
    {
        private UserService UserService = new UserService();
        private UserMapper UserMapper = new UserMapper();

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(UserViewModel userViewModel)
        {
            UserDTO UserDTO = UserMapper.UserViewModel2userDTO(userViewModel);
            UserDTO LoggedInUserDTO;
            try
            {
                LoggedInUserDTO = UserService.Login(UserDTO);
            }
            catch (InvalidUserException ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
                return View(userViewModel);
            }

            UserViewModel LoggedInUser = UserMapper.UserDTO2UserViewModel(LoggedInUserDTO);
            Session["User"] = LoggedInUser;
            if (Session["User"] != null)
            {
                Session["FullName"] = LoggedInUser.FullName;
                if (LoggedInUser.isAdmin)
                {
                    Session["Admin"] = true;
                }
            }
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Index","Home");
        }

        // GET: User/Create
        public ActionResult Register()
        {
            return View();
        }

        // POST: User/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register([Bind(Include = "Email,Password,FullName,ConfirmPassword")] RegisterViewModel registerViewModel)
        {
            UserDTO UserDTO = UserMapper.RegisterViewModel2UserDTO(registerViewModel);
            try
            {
                UserService.Register(UserDTO);
            }
            catch (UsernameAlreadyExists ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
                return View(registerViewModel);
            }

            if (ModelState.IsValid)
            {
                
                return RedirectToAction("Index","Home");
            }

            return View(registerViewModel);
        }

       
       
    }
}
