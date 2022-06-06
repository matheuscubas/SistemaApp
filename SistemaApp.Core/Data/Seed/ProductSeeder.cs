using Microsoft.EntityFrameworkCore;
using SistemaApp.Core.Models;
using SistemaApp.Core.Services.CsvReader;

namespace SistemaApp.Core.Data.Seed
{
    public class ProductSeeder : ISeeder<Product>
    {
        private readonly string _filePath = @"..\SistemaApp.Core\csv\products.csv";
        public void SeedData(SistemaAppDbContext context)
        {
            var filePath = Path.GetFullPath(_filePath);
            var csvReader = new CsvReaderService<Product>();
            var products = csvReader.ReadCsv(filePath);

            using var transaction = context.Database.BeginTransaction();
            var table = context.Model.FindEntityType(typeof(Product)).GetSchemaQualifiedTableName();
            context.Products.AddRange(products);
            context.Database.ExecuteSqlRaw($"SET IDENTITY_INSERT {table} ON");
            context.SaveChanges();
            transaction.Commit();
        }

        public void SeedData(ModelBuilder modelBuilder)
        {
            var filePath = Path.GetFullPath(_filePath);
            var csvReader = new CsvReaderService<Product>();
            var products = csvReader.ReadCsv(filePath);

            modelBuilder.Entity<Product>().HasData(products);
        }
    }
}