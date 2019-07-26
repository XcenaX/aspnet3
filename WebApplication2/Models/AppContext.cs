using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class AppContext : IdentityDbContext<AppUser>
    {
        public AppContext() : base("IdentityDb")
        {
        }

        public static AppContext Create()
        {
            return new AppContext();
        }
    }
}