using Microsoft.EntityFrameworkCore;
using SistemaApp.Core.Models;
using SistemaApp.Core.Services.CsvReader;

namespace SistemaApp.Core.Data.Seed
{
    public class CategorySeeder : ISeeder<Category>
    {
        public void SeedData(ModelBuilder modelBuilder)
        {
            var filePath = Path.GetFullPath("categories.csv");
            var csvReader = new CsvReaderService<Category>();
            var categories = csvReader.ReadCsv(filePath);

            modelBuilder.Entity<Category>().HasData(categories);
        }

        public void SeedData(SistemaAppDbContext context)
        {
            var filePath = Path.GetFullPath("categories.csv");
            var csvReader = new CsvReaderService<Category>();
            var categories = csvReader.ReadCsv(filePath);

            using var transaction = context.Database.BeginTransaction();
            var table = context.Model.FindEntityType(typeof(Category)).GetSchemaQualifiedTableName();
            context.Categories.AddRange(categories);
            context.Database.ExecuteSqlRaw($"SET IDENTITY_INSERT {table} ON");
            context.SaveChanges();
            transaction.Commit();
        }
    }
}
