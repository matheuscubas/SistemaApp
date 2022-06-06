using Microsoft.EntityFrameworkCore;
using SistemaApp.Core.Models;
using SistemaApp.Core.Services.CsvReader;

namespace SistemaApp.Core.Data.Seed
{
    public class EmployeeSeeder : ISeeder<Employee>
    {
        private readonly string _filePath = @"..\SistemaApp.Core\csv\employees.csv";
        public void SeedData(SistemaAppDbContext context)
        {
            var filePath = Path.GetFullPath(_filePath);
            var csvReader = new CsvReaderService<Employee>();
            var employees = csvReader.ReadCsv(filePath);

            using var transaction = context.Database.BeginTransaction();
            var table = context.Model.FindEntityType(typeof(Employee)).GetSchemaQualifiedTableName();
            context.Employees.AddRange(employees);
            context.Database.ExecuteSqlRaw($"SET IDENTITY_INSERT {table} ON");
            context.SaveChanges();
            transaction.Commit();
        }

        public void SeedData(ModelBuilder modelBuilder)
        {
            var filePath = Path.GetFullPath(_filePath);
            var csvReader = new CsvReaderService<Employee>();
            var employees = csvReader.ReadCsv(filePath);

            modelBuilder.Entity<Employee>().HasData(employees);
        }
    }
}
