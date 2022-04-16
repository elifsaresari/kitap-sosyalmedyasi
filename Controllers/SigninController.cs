using _1000Kitap.Identity;
using _1000Kitap.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace _1000Kitap.Controllers
{
    public class SigninController : Controller
    {
        private UserManager<ApplicationUser> UserManager;



        // GET: Signin

        public SigninController()
        {
            UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new IdentityDataContext()));
        }

        public object EntityValidationErrors { get; private set; }

        public ActionResult Index()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(Register model, object exception)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser();


                user.UserName = model.UserName;
                user.Email = model.Email;
                user.Name = model.Name;
                user.Password = model.Password;
                user.AgainPassword = model.AgainPassword;

                var result = UserManager.Create(user, model.Password);

                if (result.Succeeded)
                {
                    return RedirectToAction("~/Login");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error);

                    }

                }

            }

            return View(model);
        }
    }
}