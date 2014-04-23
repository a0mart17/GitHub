using GamesVille.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;

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
    }
}