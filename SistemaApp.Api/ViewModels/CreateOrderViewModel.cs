namespace SistemaApp.Api.ViewModels
{
    public class CreateOrderViewModel
    {
        public int CustomerId { get; set; }
        public int EmployeeId { get; set; }
        public int ShipperId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
