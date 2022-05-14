using SistemaApp.Core.Models;
using SistemaApp.Core.Services.CsvReader;

namespace SistemaApp.Core.Data.Seed
{
    public class ProductSeeder : ISeeder<Product>
    {
        public void SeedData(SistemaAppDbContext context)
        {
            var filePath = @"..\SistemaApp.Core\Csv\products.csv";
            var csvReader = new CsvReaderService<Product>();
            var products = csvReader.ReadCsv(filePath);

            context.Products.AddRange(products);
            context.SaveChanges();
        }
    }
}