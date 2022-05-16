using CsvHelper.Configuration.Attributes;

namespace SistemaApp.Core.Models
{
    public class OrderDetail
    {
        [Index(0)]
        public int Id { get; set; }

        [Index(1)]
        public int OrderId { get; set; }

        [Index(2)]
        public int ProductId { get; set; }

        [Index(3)]
        public int Quantity { get; set; }

        [Ignore]
        public Order Order { get; set; }

        [Ignore]
        public Product Product { get; set; }
    }
}
