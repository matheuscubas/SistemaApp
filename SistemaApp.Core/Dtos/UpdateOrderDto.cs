namespace SistemaApp.Core.Dtos
{
    public class UpdateOrderDto
    {
        public int OrderId { get; set; }
        public int ShipperId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
