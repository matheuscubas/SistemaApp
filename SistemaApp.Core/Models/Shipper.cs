using CsvHelper.Configuration.Attributes;

namespace SistemaApp.Core.Models
{
    public class Shipper
    {
        [Index(0)]
        public int Id { get; set; }
        [Index(1)]
        public string Name { get; set; }
        [Index(2)]
        public string Phone { get; set; }
    }
}
