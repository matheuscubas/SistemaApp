using SistemaApp.Core.Models;

namespace SistemaApp.Core.Dtos
{
    public class OrderWithNamesDto : Order
    {
        public string Customer { get; set; }
        public string Employee { get; set; }
        public string Shipper { get; set; }
        public string Product { get; set; }
        public int Quantity { get; set; }
    }
}
