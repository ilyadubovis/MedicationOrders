using Microsoft.EntityFrameworkCore;

namespace MedicationOrders.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {       
        }

        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) =>
            modelBuilder.Seed(); // extension method (see ModelBuilderExtensions class)
    }
}
