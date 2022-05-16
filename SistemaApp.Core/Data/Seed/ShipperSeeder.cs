using Microsoft.EntityFrameworkCore;
using SistemaApp.Core.Models;
using SistemaApp.Core.Services.CsvReader;

namespace SistemaApp.Core.Data.Seed
{
    public class ShipperSeeder : ISeeder<Shipper>
    {
        public void SeedData(ModelBuilder builder /*SistemaAppDbContext context*/)
        {
            var filePath = @"C:\Users\ModalGR\OneDrive - MODALGR\Área de Trabalho\Projetos Treino\SistemaApp\SistemaApp.Core\Csv\shippers.csv";
            var csvReader = new CsvReaderService<Shipper>();
            var shippers = csvReader.ReadCsv(filePath);

            builder.Entity<Shipper>().HasData(shippers);
            //context.Shippers.AddRange(shippers);
            //context.SaveChanges();
        }
    }
}