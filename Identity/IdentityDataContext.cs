using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;

namespace _1000Kitap.Identity
{
   
    public class IdentityDataContext:IdentityDbContext<ApplicationUser>
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder.Ignore<IdentityDbContext>());
        }
        public IdentityDataContext():base("identityConnection")
        {
           
        }

        


    }
}