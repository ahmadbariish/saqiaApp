using Microsoft.EntityFrameworkCore;
using SuqyaWaterSystem.Models;

namespace SuqyaWaterSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<Tank> Tanks { get; set; }
        public DbSet<WaterOrder> WaterOrders { get; set; }
        public DbSet<Driver> Drivers { get; set; }
    }
}
