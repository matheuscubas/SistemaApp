using Microsoft.EntityFrameworkCore;
using SistemaApp.Core.Models;
using SistemaApp.Core.Services.CsvReader;

namespace SistemaApp.Core.Data.Seed
{
    public class CustomerSeeder : ISeeder<Customer>
    {
        public void SeedData(ModelBuilder builder)//SistemaAppDbContext context)
        {
            var filePath = @"C:\Users\ModalGR\OneDrive - MODALGR\Área de Trabalho\Projetos Treino\SistemaApp\SistemaApp.Core\Csv\customers.csv";
            var csvReader = new CsvReaderService<Customer>();
            var customers = csvReader.ReadCsv(filePath);


            builder.Entity<Customer>().HasData(customers);

            //context.Customers.AddRange(customers);
            //context.SaveChanges();
        }
    }
}