using SistemaApp.Core.Models;
using SistemaApp.Core.Services.CsvReader;

namespace SistemaApp.Core.Data.Seed
{
    public class EmployeeSeeder : ISeeder<Employee>
    {
        public void SeedData(SistemaAppDbContext context)
        {
            var filePath = @"..\SistemaApp.Core\Csv\employees.csv";
            var csvReader = new CsvReaderService<Employee>();
            var employees = csvReader.ReadCsv(filePath);

            context.Employees.AddRange(employees);
            context.SaveChanges();
        }
    }
}
