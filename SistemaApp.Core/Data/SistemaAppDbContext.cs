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

            //var seeder = WebFramework

            //Arrumar reflection depois, não está funcionando devido a tipagem dinamica!
            //Type baseType = typeof(ISeeder<>);
            //Type genericType = baseType.MakeGenericType(typeof(object));

            //var types = AppDomain.CurrentDomain.GetAssemblies()
            //     .SelectMany(x => x.GetTypes())
            //     .Where(x => baseType.IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract)
            //     .Select(x => Activator.CreateInstance(x));

            //foreach (var type in types)
            //   type.GetType().


            //implementar reflection depois
            var categorySeeder = new CategorySeeder();
            var customerSeeder = new CustomerSeeder();
            var employeeSeeder = new EmployeeSeeder();
            var orderDetailSeeder = new OrderDetailSeeder();
            var orderSeeder = new OrderSeeder();
            var productSeeder = new ProductSeeder();
            var shipperSeeder = new ShipperSeeder();
            var supplierSeeder = new SupplierSeeder();


            categorySeeder.SeedData(modelBuilder);
            customerSeeder.SeedData(modelBuilder);
            employeeSeeder.SeedData(modelBuilder);
            shipperSeeder.SeedData(modelBuilder);
            supplierSeeder.SeedData(modelBuilder);
            productSeeder.SeedData(modelBuilder);
            orderSeeder.SeedData(modelBuilder);
            orderDetailSeeder.SeedData(modelBuilder);

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
