using LSMWebApi.Data;
using LSMWebApi.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LSMWebApi.Context
{
    public class LSMContext : IdentityDbContext<LSMStaffUser>
    {
        public LSMContext(DbContextOptions options)
           : base(options)
        {
        }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Borrower> Borrowers { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Binding> Bindings { get; set; }
        public DbSet<Shelf> Shelves { get; set; }
        public DbSet<Defaulter> Defaulters { get; set; }
        public DbSet<Return> Returns { get; set; }
    }
}

