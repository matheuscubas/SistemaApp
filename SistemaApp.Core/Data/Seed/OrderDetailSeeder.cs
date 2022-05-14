using SistemaApp.Core.Models;
using SistemaApp.Core.Services.CsvReader;

namespace SistemaApp.Core.Data.Seed
{
    public class OrderDetailSeeder : ISeeder<OrderDetail>
    {
        public void SeedData(SistemaAppDbContext context)
        {
            var filePath = @"..\SistemaApp.Core\Csv\orderDetails.csv";
            var csvReader = new CsvReaderService<OrderDetail>();
            var orderDetails = csvReader.ReadCsv(filePath);

            context.OrderDetails.AddRange(orderDetails);
            context.SaveChanges();
        }
    }
}
