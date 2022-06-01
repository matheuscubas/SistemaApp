using CsvHelper.Configuration.Attributes;
using System.Text.Json.Serialization;

namespace SistemaApp.Core.Models
{
    public class Order
    {
        [Index(0)]
        public int Id { get; set; }

        [Index(1)]
        public int CustomerId { get; set; }

        [Index(2)]
        public int EmployeeId { get; set; }

        [Index(4)]
        public int ShipperId { get; set; }

        [Index(3)]
        public DateTime OrderDate { get; set; }

        [JsonIgnore]
        [Ignore]
        public ICollection<OrderDetail> OrdersDetails { get; set; }

        [JsonIgnore]
        [Ignore]
        public Customer Customer { get; set; }

        [JsonIgnore]
        [Ignore]
        public Employee Employee { get; set; }

        [JsonIgnore]
        [Ignore]
        public Shipper Shipper { get; set; }
    }
}
