using Microsoft.EntityFrameworkCore;
using SistemaApp.Core.Data.Seed;
using SistemaApp.Core.Models;
using System.Reflection;


namespace SistemaApp.Core.Data
{
    public class SistemaAppDbContext : DbContext
    {
        public SistemaAppDbContext(DbContextOptions<SistemaAppDbContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            //var categorySeeder = new CategorySeeder();
            //var customerSeeder = new CustomerSeeder();
            //var employeeSeeder = new EmployeeSeeder();
            //var orderDetailSeeder = new OrderDetailSeeder();
            //var orderSeeder = new OrderSeeder();
            //var productSeeder = new ProductSeeder();
            //var shipperSeeder = new ShipperSeeder();
            //var supplierSeeder = new SupplierSeeder();
            //var roleSeeder = new RoleSeeder();
            //var userSeeder = new UserSeeder();


            //categorySeeder.SeedData(modelBuilder);
            //customerSeeder.SeedData(modelBuilder);
            //employeeSeeder.SeedData(modelBuilder);
            //shipperSeeder.SeedData(modelBuilder);
            //supplierSeeder.SeedData(modelBuilder);
            //productSeeder.SeedData(modelBuilder);
            //orderSeeder.SeedData(modelBuilder);
            //orderDetailSeeder.SeedData(modelBuilder);
            //roleSeeder.SeedData(modelBuilder);
            //userSeeder.SeedData(modelBuilder);
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Shipper> Shippers { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
}
