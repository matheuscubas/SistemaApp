using Microsoft.EntityFrameworkCore;
using SistemaApp.Core.Models;
using SistemaApp.Core.Services.CsvReader;

namespace SistemaApp.Core.Data.Seed
{
    public class ShipperSeeder : ISeeder<Shipper>
    {
        private readonly string _filePath = @"..\SistemaApp.Core\csv\shippers.csv";
        public void SeedData(SistemaAppDbContext context)
        {
            var filePath = Path.GetFullPath(_filePath);
            var csvReader = new CsvReaderService<Shipper>();
            var shippers = csvReader.ReadCsv(filePath);

            using var transaction = context.Database.BeginTransaction();
            var table = context.Model.FindEntityType(typeof(Shipper)).GetSchemaQualifiedTableName();
            context.Shippers.AddRange(shippers);
            context.Database.ExecuteSqlRaw($"SET IDENTITY_INSERT {table} ON");
            context.SaveChanges();
            transaction.Commit();
        }

        public void SeedData(ModelBuilder modelBuilder)
        {
            var filePath = Path.GetFullPath(_filePath);
            var csvReader = new CsvReaderService<Shipper>();
            var shippers = csvReader.ReadCsv(filePath);

            modelBuilder.Entity<Shipper>().HasData(shippers);
        }
    }
}