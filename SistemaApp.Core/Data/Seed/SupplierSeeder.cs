using Microsoft.EntityFrameworkCore;
using SistemaApp.Core.Models;
using SistemaApp.Core.Services.CsvReader;

namespace SistemaApp.Core.Data.Seed
{
    public class SupplierSeeder : ISeeder<Supplier>
    {
        public void SeedData(SistemaAppDbContext context)
        {
            var filePath = @"C:\Users\ModalGR\OneDrive - MODALGR\Área de Trabalho\Projetos Treino\SistemaApp\SistemaApp.Core\Csv\suppliers.csv";
            var csvReader = new CsvReaderService<Supplier>();
            var suppliers = csvReader.ReadCsv(filePath);

            context.Suppliers.AddRange(suppliers);
            context.SaveChanges();
        }

        public void SeedData(ModelBuilder modelBuilder)
        {
            var filePath = @"C:\Users\ModalGR\OneDrive - MODALGR\Área de Trabalho\Projetos Treino\SistemaApp\SistemaApp.Core\Csv\suppliers.csv";
            var csvReader = new CsvReaderService<Supplier>();
            var suppliers = csvReader.ReadCsv(filePath);

            modelBuilder.Entity<Supplier>().HasData(suppliers);
        }
    }
}