using Microsoft.EntityFrameworkCore;
using SistemaApp.Core.Models;
using SistemaApp.Core.Services.CsvReader;

namespace SistemaApp.Core.Data.Seed
{
    public class CategorySeeder : ISeeder<Category>
    {
        //public void SeedData(SistemaAppDbContext context)
        public void SeedData(ModelBuilder modelBuilder)
        {
            var filePath = @"C:\Users\ModalGR\OneDrive - MODALGR\Área de Trabalho\Projetos Treino\SistemaApp\SistemaApp.Core\Csv\categories.csv";
            var csvReader = new CsvReaderService<Category>();
            var categories = csvReader.ReadCsv(filePath);

            modelBuilder.Entity<Category>().HasData(categories);
        }

        public void SeedData(SistemaAppDbContext context)
        {
            var filePath = @"C:\Users\ModalGR\OneDrive - MODALGR\Área de Trabalho\Projetos Treino\SistemaApp\SistemaApp.Core\Csv\categories.csv";
            var csvReader = new CsvReaderService<Category>();
            var categories = csvReader.ReadCsv(filePath);

            context.Categories.AddRange(categories);
            context.SaveChanges();
        }
    }
}
