using Microsoft.EntityFrameworkCore;
using SistemaApp.Core.Models;
using SistemaApp.Core.Services.CsvReader;

namespace SistemaApp.Core.Data.Seed
{
    public class ProductSeeder : ISeeder<Product>
    {
        public void SeedData(ModelBuilder builder/*SistemaAppDbContext context*/)
        {
            var filePath = @"C:\Users\ModalGR\OneDrive - MODALGR\Área de Trabalho\Projetos Treino\SistemaApp\SistemaApp.Core\Csv\products.csv";
            var csvReader = new CsvReaderService<Product>();
            var products = csvReader.ReadCsv(filePath);

            builder.Entity<Product>().HasData(products);
            //context.Products.AddRange(products);
            //context.SaveChanges();
        }
    }
}