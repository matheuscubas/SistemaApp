using SistemaApp.Core.Models;
using SistemaApp.Core.Services.CsvReader;

namespace SistemaApp.Core.Data.Seed
{
    public class ShipperSeeder : ISeeder<Shipper>
    {
        public void SeedData(SistemaAppDbContext context)
        {
            var filePath = @"..\SistemaApp.Core\Csv\shippers.csv";
            var csvReader = new CsvReaderService<Shipper>();
            var shippers = csvReader.ReadCsv(filePath);

            context.Shippers.AddRange(shippers);
            context.SaveChanges();
        }
    }
}