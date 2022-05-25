using CsvHelper.Configuration.Attributes;

namespace SistemaApp.Core.Models
{
    public class Product
    {
        [Name("id")]
        public int Id { get; set; }

        [Name("name")]
        public string Name { get; set; }

        [Name("supplier_id")]
        public int SupplierId { get; set; }

        [Name("category_id")]
        public int CategoryId { get; set; }

        [Name("unit")]
        public string Unit { get; set; }

        [Name("price")]
        public double Price { get; set; }

        [Ignore]
        public Category? Category { get; set; }

        [Ignore]
        public Supplier? Supplier { get; set; }
    }
}
