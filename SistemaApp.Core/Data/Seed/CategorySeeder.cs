using Microsoft.EntityFrameworkCore;
using SistemaApp.Core.Models;
using SistemaApp.Core.Services.CsvReader;

namespace SistemaApp.Core.Data.Seed
{
    public class CategorySeeder : ISeeder<Category>
    {
        public void SeedData(ModelBuilder builder) //SistemaAppDbContext context)
        {
            var filePath = @"C:\Users\ModalGR\OneDrive - MODALGR\Área de Trabalho\Projetos Treino\SistemaApp\SistemaApp.Core\Csv\categories.csv";
            var csvReader = new CsvReaderService<Category>();
            var categories = csvReader.ReadCsv(filePath);


            builder.Entity<Category>().HasData(categories);

            //Usar depois quando arrumar o SeedService
            //context.Categories.AddRange(categories);
            //context.SaveChanges();
        }
    }
}
