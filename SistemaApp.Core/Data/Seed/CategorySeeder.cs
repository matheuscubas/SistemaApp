using SistemaApp.Core.Models;
using SistemaApp.Core.Services.CsvReader;

namespace SistemaApp.Core.Data.Seed
{
    public class CategorySeeder : ISeeder<Category>
    {
        public void SeedData(SistemaAppDbContext context)
        {
            var filePath = @"..\SistemaApp.Core\Csv\categories.csv";
            var csvReader = new CsvReaderService<Category>();
            var categories = csvReader.ReadCsv(filePath);

            context.Categories.AddRange(categories);
            context.SaveChanges();
        }
    }
}
