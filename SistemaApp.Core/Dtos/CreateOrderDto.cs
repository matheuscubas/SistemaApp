using SistemaApp.Core.Models;

namespace SistemaApp.Api.ViewModels
{
    public class CreateOrderDto : Order
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
