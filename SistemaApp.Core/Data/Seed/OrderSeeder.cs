using Microsoft.EntityFrameworkCore;
using SistemaApp.Core.Models;
using SistemaApp.Core.Services.CsvReader;

namespace SistemaApp.Core.Data.Seed
{
    public class OrderSeeder : ISeeder<Order>
    {
        public void SeedData(SistemaAppDbContext context)
        {
            var filePath = @"C:\Users\ModalGR\OneDrive - MODALGR\Área de Trabalho\Projetos Treino\SistemaApp\SistemaApp.Core\Csv\orders.csv";
            var csvReader = new CsvReaderService<Order>();
            var orders = csvReader.ReadCsv(filePath);

            context.Orders.AddRange(orders);
            context.SaveChanges();
        }

        public void SeedData(ModelBuilder modelBuilder)
        {
            var filePath = @"C:\Users\ModalGR\OneDrive - MODALGR\Área de Trabalho\Projetos Treino\SistemaApp\SistemaApp.Core\Csv\orders.csv";
            var csvReader = new CsvReaderService<Order>();
            var orders = csvReader.ReadCsv(filePath);

            modelBuilder.Entity<Order>().HasData(orders);
        }
    }
}