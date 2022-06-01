using CsvHelper.Configuration.Attributes;
using System.Text.Json.Serialization;

namespace SistemaApp.Core.Models
{
    public class Category
    {
        [Index(0)]
        public int Id { get; set; }

        [Index(1)]
        public string Name { get; set; }

        [Index(2)]
        public string Description { get; set; }

        [JsonIgnore]
        [Ignore]
        public ICollection<Product>? Products { get; set; }
    }
}
