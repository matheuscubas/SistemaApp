﻿using SistemaApp.Core.Models;
using SistemaApp.Core.Services.CsvReader;

namespace SistemaApp.Core.Data.Seed
{
    public class OrderSeeder : ISeeder<Order>
    {
        public void SeedData(SistemaAppDbContext context)
        {
            var filePath = @"..\SistemaApp.Core\Csv\orders.csv";
            var csvReader = new CsvReaderService<Order>();
            var orders = csvReader.ReadCsv(filePath);

            context.Orders.AddRange(orders);
            context.SaveChanges();
        }
    }
}