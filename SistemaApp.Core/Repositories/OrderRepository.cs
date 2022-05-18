using Dapper;
using Microsoft.EntityFrameworkCore;
using SistemaApp.Api.ViewModels;
using SistemaApp.Core.Data;
using SistemaApp.Core.Dtos;
using SistemaApp.Core.Extensions;
using SistemaApp.Core.Models;
using SistemaApp.Core.Services.ConnectionService;

namespace SistemaApp.Core.Repositories
{
    public class OrderRepository : Repository<Order>, IRepository<Order>
    {
        private readonly ConnectionService _connection;
        public OrderRepository(SistemaAppDbContext context, ConnectionService connection) 
            : base(context)
        {
            _connection = connection;
        }

        public int Create(CreateOrderDto dto, SistemaAppDbContext _context)
        {
            var shipper = _context.Shippers.FirstOrDefault(x => x.Id == dto.ShipperId);
            var customer = _context.Customers.FirstOrDefault(x => x.Id == dto.CustomerId);
            var employee = _context.Employees.FirstOrDefault(x => x.Id == dto.EmployeeId);
            var product = _context.Products.FirstOrDefault(x => x.Id == dto.ProductId);

            var order = new Order()
            {
                ShipperId = dto.ShipperId,
                CustomerId = dto.CustomerId,
                EmployeeId = dto.EmployeeId,
                OrderDate = DateTime.UtcNow,
                Shipper = shipper,
                Customer = customer,
                Employee = employee
            };

            var orderdetail = new OrderDetail()
            {
                Order = order,
                Product = product,
                Quantity = dto.Quantity,
            };

            _context.Orders.Add(order);
            _context.OrderDetails.Add(orderdetail);
            _context.SaveChanges();
            return order.Id;
        }

        public override IEnumerable<OrderWithNamesDto> GetAll()
        {
            var query = @"
                        SELECT Orders.OrderId AS Id,
                        Customers.CustomerName AS Customer,
                        Employees.FirstName AS Employee,
                        Shippers.ShipperName AS Shipper,
                        Products.Name AS Product,
                        OrderDetails.Quantity AS Quantity,
                        OrderDate
                        FROM Orders
                        INNER JOIN Customers ON Customers.CustomerId = Orders.CustomerId
                        INNER JOIN Employees ON Orders.EmployeeId = Employees.EmployeeId
                        INNER JOIN Shippers ON Orders.ShipperId = Shippers.ShipperId
                        INNER JOIN OrderDetails ON Orders.OrderId = OrderDetails.OrderId
                        INNER JOIN Products ON OrderDetails.ProductId = Products.ProductId";

            using var connection = _connection.Connection();
            var orders = connection.Query<OrderWithNamesDto>(query);

            return orders;
        }

        public  IEnumerable<OrderWithNamesDto> GetById(int id)
        {
            var query = @"
                        SELECT Orders.OrderId AS Id,
                        Customers.CustomerName AS Customer,
                        Employees.FirstName AS Employee,
                        Shippers.ShipperName AS Shipper,
                        Products.Name AS Product,
                        OrderDetails.Quantity AS Quantity,
                        OrderDate
                        FROM Orders
                        INNER JOIN Customers ON Customers.CustomerId = Orders.CustomerId
                        INNER JOIN Employees ON Orders.EmployeeId = Employees.EmployeeId
                        INNER JOIN Shippers ON Orders.ShipperId = Shippers.ShipperId
                        INNER JOIN OrderDetails ON Orders.OrderId = OrderDetails.OrderId
                        INNER JOIN Products ON OrderDetails.ProductId = Products.ProductId
                        WHERE Orders.OrderId = @orderId";

            using var connection = _connection.Connection();
            var orders = connection.Query<OrderWithNamesDto>(query, new { orderId = id });

            return orders;
        }
        public override async Task<IEnumerable<Order>> GetPaginated(int pageSize, int pageNumber)
        {
            var query = @"
                        SELECT 
                        [Orders].* 
                        FROM
                        Orders";

            var connection = _connection.Connection();

            var result = await connection.GetUsingSqlServerNativePagination<Order, object>(query, new { },pageSize, pageNumber);
            return result.Items;
        }
    }
}
