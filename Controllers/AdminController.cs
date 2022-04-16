using _1000Kitap.Identity;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _1000Kitap.Controllers
{
    public class AdminController : Controller
    {
        private UserManager<ApplicationUser> UserManager;

        // GET: Admin

        public AdminController()
        {
            UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new IdentityDataContext()));
        }
        
        public ActionResult Index()
        {
            return View(UserManager.Users);
        }
    }
}