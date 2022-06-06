using Microsoft.EntityFrameworkCore;
using SistemaApp.Core.Models;
using SistemaApp.Core.Services.CsvReader;

namespace SistemaApp.Core.Data.Seed
{
    public class CustomerSeeder : ISeeder<Customer>
    {
        private readonly string _filePath = @"..\SistemaApp.Core\csv\customers.csv";
        public void SeedData(SistemaAppDbContext context)
        {
            var filePath = Path.GetFullPath(_filePath);
            var csvReader = new CsvReaderService<Customer>();
            var customers = csvReader.ReadCsv(filePath);

            using var transaction = context.Database.BeginTransaction();
            var table = context.Model.FindEntityType(typeof(Customer)).GetSchemaQualifiedTableName();
            context.Customers.AddRange(customers);
            context.Database.ExecuteSqlRaw($"SET IDENTITY_INSERT {table} ON");
            context.SaveChanges();
            transaction.Commit();
        }

        public void SeedData(ModelBuilder modelBuilder)
        {
            var filePath = Path.GetFullPath(_filePath);
            var csvReader = new CsvReaderService<Customer>();
            var customers = csvReader.ReadCsv(filePath);

            modelBuilder.Entity<Customer>().HasData(customers);
        }
    }
}