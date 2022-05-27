using Microsoft.EntityFrameworkCore;
using SistemaApp.Core.Models;
using SistemaApp.Core.Services.CsvReader;

namespace SistemaApp.Core.Data.Seed
{
    public class SupplierSeeder : ISeeder<Supplier>
    {
        public void SeedData(SistemaAppDbContext context)
        {
            var filePath = Path.GetFullPath("suppliers.csv");
            var csvReader = new CsvReaderService<Supplier>();
            var suppliers = csvReader.ReadCsv(filePath);

            using var transaction = context.Database.BeginTransaction();
            var table = context.Model.FindEntityType(typeof(Supplier)).GetSchemaQualifiedTableName();
            context.Suppliers.AddRange(suppliers);
            context.Database.ExecuteSqlRaw($"SET IDENTITY_INSERT {table} ON");
            context.SaveChanges();
            transaction.Commit();
        }

        public void SeedData(ModelBuilder modelBuilder)
        {
            var filePath = Path.GetFullPath("suppliers.csv");
            var csvReader = new CsvReaderService<Supplier>();
            var suppliers = csvReader.ReadCsv(filePath);

            modelBuilder.Entity<Supplier>().HasData(suppliers);
        }
    }
}