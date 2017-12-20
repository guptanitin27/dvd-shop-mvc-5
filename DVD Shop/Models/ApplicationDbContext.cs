using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace DVD_Shop.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {   // the gateway of the database

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }

        public DbSet<MembershipType> MembershipTypes { get; set; }
        public DbSet<Genre> Genres { get; set; }

        public DbSet<Rental> Rentals { get; set; }



        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}