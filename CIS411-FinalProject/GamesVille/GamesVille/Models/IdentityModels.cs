using GamesVille.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using Microsoft.AspNet.Identity;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Data.Entity.Validation;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace GamesVille.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
          public int Membership { get; set; }
          public string Address {  get; set; }
          public string City { get; set; }
          public string State { get; set; }
          public string ZipCode { get; set; }
          public string PhoneNumber { get; set; }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        

        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }

        //public DbSet<IdentityUserRole> UserRoles { get; set; }
        //public DbSet<IdentityUserClaim> Claims { get; set; }
        //public DbSet<IdentityUserLogin> Logins { get; set; }

        //public ApplicationDbContext(string name)
        //{
        //    // TODO: Complete member initialization
        //    this.name = name;
        //}


        
    }
}