using SistemaApp.Core.Models;
using SistemaApp.Core.Services.CsvReader;

namespace SistemaApp.Core.Data.Seed
{
    public class SupplierSeeder : ISeeder<Supplier>
    {
        public void SeedData(SistemaAppDbContext context)
        {
            var filePath = @"..\SistemaApp.Core\Csv\suppliers.csv";
            var csvReader = new CsvReaderService<Supplier>();
            var suppliers = csvReader.ReadCsv(filePath);

            context.Suppliers.AddRange(suppliers);
            context.SaveChanges();
        }
    }
}