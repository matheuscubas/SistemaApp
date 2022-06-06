using Microsoft.EntityFrameworkCore;
using SistemaApp.Core.Models;
using SistemaApp.Core.Services.CsvReader;

namespace SistemaApp.Core.Data.Seed
{
    public class OrderDetailSeeder : ISeeder<OrderDetail>
    {
        private readonly string _filePath = @"..\SistemaApp.Core\csv\orderDetails.csv";
        public void SeedData(SistemaAppDbContext context)
        {
            var filePath = Path.GetFullPath(_filePath);
            var csvReader = new CsvReaderService<OrderDetail>();
            var orderDetails = csvReader.ReadCsv(filePath);

            using var transaction = context.Database.BeginTransaction();
            var table = context.Model.FindEntityType(typeof(OrderDetail)).GetSchemaQualifiedTableName();
            context.OrderDetails.AddRange(orderDetails);
            context.Database.ExecuteSqlRaw($"SET IDENTITY_INSERT {table} ON");
            context.SaveChanges();
            transaction.Commit();
        }

        public void SeedData(ModelBuilder modelBuilder)
        {
            var filePath = Path.GetFullPath(_filePath);
            var csvReader = new CsvReaderService<OrderDetail>();
            var orderDetails = csvReader.ReadCsv(filePath);

            modelBuilder.Entity<OrderDetail>().HasData(orderDetails);
        }
    }
}
