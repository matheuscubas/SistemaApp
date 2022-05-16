using Microsoft.EntityFrameworkCore;
using SistemaApp.Core.Models;
using SistemaApp.Core.Services.CsvReader;

namespace SistemaApp.Core.Data.Seed
{
    public class OrderSeeder : ISeeder<Order>
    {
        public void SeedData(ModelBuilder builder/*SistemaAppDbContext context*/)
        {
            var filePath = @"C:\Users\ModalGR\OneDrive - MODALGR\Área de Trabalho\Projetos Treino\SistemaApp\SistemaApp.Core\Csv\orders.csv";
            var csvReader = new CsvReaderService<Order>();
            var orders = csvReader.ReadCsv(filePath);

            builder.Entity<Order>().HasData(orders);
            //context.Orders.AddRange(orders);
            //context.SaveChanges();
        }
    }
}