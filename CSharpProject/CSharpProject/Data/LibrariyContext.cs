using CSharpProject.Models;
using Microsoft.EntityFrameworkCore;

namespace CSharpProject.Data
{
   public class LibrariyContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=Library;Integrated Security=True");
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Cart> Carts { get; set; }
    }
}
