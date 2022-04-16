using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _1000Kitap.Identity
{
    public class ApplicationUser : IdentityUser
    {
        

        //[Compare("Password", ErrorMessage = "Şifreler uyuşmuyor")]
        //public string AgainPassword { get; set; }

        //public string Name { get; internal set; }
        public string Name { get; internal set; }
        public string AgainPassword { get; internal set; }
        public string Password { get; internal set; }
    }
}