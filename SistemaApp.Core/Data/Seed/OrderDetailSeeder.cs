using Microsoft.EntityFrameworkCore;
using SistemaApp.Core.Models;
using SistemaApp.Core.Services.CsvReader;

namespace SistemaApp.Core.Data.Seed
{
    public class OrderDetailSeeder : ISeeder<OrderDetail>
    {
        public void SeedData(ModelBuilder builder) //SistemaAppDbContext context)
        {
            var filePath = @"C:\Users\ModalGR\OneDrive - MODALGR\Área de Trabalho\Projetos Treino\SistemaApp\SistemaApp.Core\Csv\orderDetails.csv";
            var csvReader = new CsvReaderService<OrderDetail>();
            var orderDetails = csvReader.ReadCsv(filePath);

            builder.Entity<OrderDetail>().HasData(orderDetails);
            //context.OrderDetails.AddRange(orderDetails);
            //context.SaveChanges();
        }
    }
}
