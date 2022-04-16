using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _1000Kitap
{
    [NotMapped]
    public class ApplicationRole:IdentityRole
    {
        
        public int Description { get; set; }
    }
}