using CsvHelper.Configuration.Attributes;
using System.Text.Json.Serialization;

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

        [JsonIgnore]
        [Ignore]
        public Category? Category { get; set; }

        [JsonIgnore]
        [Ignore]
        public Supplier? Supplier { get; set; }
    }
}
