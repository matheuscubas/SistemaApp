using Microsoft.EntityFrameworkCore;
using SistemaApp.Core.Data.Mappings;
using SistemaApp.Core.Models;

namespace SistemaApp.Core.Data
{
    public class SistemaAppDbContext : DbContext
    {
        private const string ConnectionString = "Server=.\\SQLExpress;Database=SistemaApp;TrustServerCertificate=True;Integrated Security = True;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer(ConnectionString);

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new OrderDetailMap());
        }
        
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Shipper> Shippers { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
    }
}
