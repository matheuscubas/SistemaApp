using CsvHelper.Configuration.Attributes;

namespace SistemaApp.Core.Models
{
    public class Product
    {
        [Index(0)]
        public int Id { get; set; }
        [Index(1)]
        public string Name { get; set; }
        [Index(2)]
        public int SupplierId { get; set; }
        [Index(3)]
        public int CategoryId { get; set; }
        [Index(4)]
        public string Unit { get; set; }
        [Index(5)]
        public double Price { get; set; }
        public Category Category { get; set; }
        public Supplier Supplier { get; set; }
    }
}
