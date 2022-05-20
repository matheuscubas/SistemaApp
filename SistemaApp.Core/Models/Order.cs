using CsvHelper.Configuration.Attributes;

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

        [Ignore]
        public ICollection<OrderDetail> OrdersDetails { get; set; }
        [Ignore]
        public Customer Customer { get; set; }
        [Ignore]
        public Employee Employee { get; set; }
        [Ignore]
        public Shipper Shipper { get; set; }
    }
}
