
using Microsoft.EntityFrameworkCore;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace Laborator4
{
    public class ProductManagement : DbContext
    {

        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> CustomerSet { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=(localdb)\mssgllocadb;Database=Lab04DB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToTable("Product");
            modelBuilder.Entity<Product>(
                p =>
                {
                    p.Property(e => e.Id);
                    p.Property(e => e.Name);
                    p.Property(e => e.Description);
                    p.Property(e => e.startDate);
                    p.Property(e => e.endDate);
                    p.Property(e => e.price);
                    p.Property(e => e.VAT);

                });
            modelBuilder.Entity<Customer>().ToTable("Customer");
            modelBuilder.Entity<Customer>(
                p =>
                {
                    p.Property(e => e.Id);
                    p.Property(e => e.Name);
                    p.Property(e => e.Email);
                    p.Property(e => e.Adress);
                    p.Property(e => e.PhoneNumber);
                    
                });
                
            
        }
    }
}