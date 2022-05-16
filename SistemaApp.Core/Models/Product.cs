using CsvHelper.Configuration.Attributes;

namespace SistemaApp.Core.Models
{
    public class Product
    {
        //[Index(0)]
        [Name("id")]
        public int Id { get; set; }

        //[Index(1)]
        [Name("name")]
        public string Name { get; set; }

        //[Index(2)]
        [Name("supplier_id")]
        public int SupplierId { get; set; }

        //[Index(3)]
        [Name("category_id")]
        public int CategoryId { get; set; }

        //[Index(4)]
        [Name("unit")]
        public string Unit { get; set; }

        //[Index(5)]
        [Name("price")]
        public double Price { get; set; }

        [Ignore]
        public Category Category { get; set; }

        [Ignore]
        public Supplier Supplier { get; set; }
    }
}
