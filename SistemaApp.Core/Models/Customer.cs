using CsvHelper.Configuration.Attributes;
using System.Text.Json.Serialization;

namespace SistemaApp.Core.Models
{
    public class Customer
    {
        [Index(0)]
        public int Id { get; set; }

        [Index(1)]
        public string Name { get; set; }

        [Index(2)]
        public string ContactName { get; set; }

        [Index(3)]
        public string Address { get; set; }

        [Index(4)]
        public string City { get; set; }

        [Index(5)]
        public string PostalCode { get; set; }

        [Index(6)]
        public string Country { get; set; }

        [JsonIgnore]
        [Ignore]
        public ICollection<Order>? Orders { get; set; }
    }
}
