using SistemaApp.Core.Models;
using SistemaApp.Core.Services.CsvReader;

namespace SistemaApp.Core.Data.Seed
{
    public class CustomerSeed : ISeeder<Customer>
    {
        public void SeedData(SistemaAppDbContext context)
        {
            var filePath = @"..\SistemaApp.Core\Csv\customers.csv";
            var csvReader = new CsvReaderService<Customer>();
            var customers = csvReader.ReadCsv(filePath);

            context.Customers.AddRange(customers);
            context.SaveChanges();
        }
    }
}