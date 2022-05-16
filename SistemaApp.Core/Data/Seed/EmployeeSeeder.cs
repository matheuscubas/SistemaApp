using Microsoft.EntityFrameworkCore;
using SistemaApp.Core.Models;
using SistemaApp.Core.Services.CsvReader;

namespace SistemaApp.Core.Data.Seed
{
    public class EmployeeSeeder : ISeeder<Employee>
    {
        public void SeedData(ModelBuilder builder) //SistemaAppDbContext context)
        {
            var filePath = @"C:\Users\ModalGR\OneDrive - MODALGR\Área de Trabalho\Projetos Treino\SistemaApp\SistemaApp.Core\Csv\employees.csv";
            var csvReader = new CsvReaderService<Employee>();
            var employees = csvReader.ReadCsv(filePath);


            builder.Entity<Employee>().HasData(employees);
            //context.Employees.AddRange(employees);
            //context.SaveChanges();
        }
    }
}
