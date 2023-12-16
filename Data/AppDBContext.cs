using EfCoreRelation.Entity;
using Microsoft.EntityFrameworkCore;

namespace EfCoreRelation.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions options) : base(options)
        {
        }

      

       // public DbSet<Catagory> catagories { get; set; }
        //public DbSet<Product> products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerAddress> customerAddresses { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomerAddress>()
                .HasOne(_ => _.customer)
                 .WithMany(_ => _.customerAddresses)
                 .HasForeignKey(_ => _.CustomerId);

        }
    }
}
