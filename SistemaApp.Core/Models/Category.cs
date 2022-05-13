using CsvHelper.Configuration.Attributes;

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
        public ICollection<Product> Products { get; set; }
    }
}
