using Microsoft.EntityFrameworkCore;
using SistemaApp.Core.Models;
using SistemaApp.Core.Services.CsvReader;

namespace SistemaApp.Core.Data.Seed
{
    public class CustomerSeeder : ISeeder<Customer>
    {
        public void SeedData(SistemaAppDbContext context)
        {
            var filePath = @"C:\Users\ModalGR\OneDrive - MODALGR\Área de Trabalho\Projetos Treino\SistemaApp\SistemaApp.Core\Csv\customers.csv";
            var csvReader = new CsvReaderService<Customer>();
            var customers = csvReader.ReadCsv(filePath);

            context.Customers.AddRange(customers);
            context.SaveChanges();
        }

        public void SeedData(ModelBuilder modelBuilder)
        {
            var filePath = @"C:\Users\ModalGR\OneDrive - MODALGR\Área de Trabalho\Projetos Treino\SistemaApp\SistemaApp.Core\Csv\customers.csv";
            var csvReader = new CsvReaderService<Customer>();
            var customers = csvReader.ReadCsv(filePath);

            modelBuilder.Entity<Customer>().HasData(customers);
        }
    }
}