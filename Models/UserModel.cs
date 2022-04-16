using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _1000Kitap.Models
{
    public class Register
    {


        [Required]
        public string UserName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
        public string AgainPassword { get; set; }
        public string Name { get; set; }
    }

    
}