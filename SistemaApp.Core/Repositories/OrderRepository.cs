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
    public class OrderRepository : RepositoryCud<Order>, IRepositoryRead<OrderWithNamesDto>, IRepositoryCud<Order>
    {
        private readonly ConnectionService _connection;
        private const string  GetAllQueryOrdersWithNames = 
                        @"
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
        public OrderRepository(SistemaAppDbContext context, ConnectionService connection) 
            : base(context)
        {
            _connection = connection;
        }

        public int Create(CreateOrderDto dto)
        {
            var order = new Order()
            {
                ShipperId = dto.ShipperId,
                CustomerId = dto.CustomerId,
                EmployeeId = dto.EmployeeId,
                OrderDate = DateTime.UtcNow,
            };

            var orderdetail = new OrderDetail()
            {
                Order = order,
                ProductId = dto.ProductId,
                Quantity = dto.Quantity,
            };

            _context.Orders.Add(order);
            _context.OrderDetails.Add(orderdetail);
            _context.SaveChanges();
            return order.Id;
        }

        public IEnumerable<OrderWithNamesDto> GetAll()
        {
            using var connection = _connection.Connection();
            var orders = connection.Query<OrderWithNamesDto>(GetAllQueryOrdersWithNames);

            return orders;
        }

        public async Task<IEnumerable<OrderWithNamesDto>> GetByIdAsync(int id)
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
            var orders = await connection.QueryAsync<OrderWithNamesDto>(query, new { orderId = id });

            return orders;
        }

        public async Task<Order> GetById(int id)
        {
            var query = @"
                        SELECT *
                        FROM Orders
                        WHERE OrderId = @Id";

            var connection = _connection.Connection();
            var order = await connection.QueryFirstAsync<Order>(query, new { Id = id });

            return order;
        }

        OrderWithNamesDto? IRepositoryRead<OrderWithNamesDto>.GetById(int id)
        {
            throw new NotImplementedException();
        }
        public  async Task<PaginationResult<OrderWithNamesDto>> GetPaginated(int pageSize, int pageNumber)
        {
            var connection = _connection.Connection();

            var result = await connection.GetUsingSqlServerNativePagination<OrderWithNamesDto, object>(GetAllQueryOrdersWithNames, new { },pageSize, pageNumber);
            return result;
        }

        public async Task UpdateAsync(UpdateOrderDto model)
        {
            //Trocar pra uma Query com Dapper depois
            var order = await _context.Orders.FirstOrDefaultAsync(x => x.Id == model.OrderId);
            var orderDetails = await _context
                .OrderDetails
                .FirstOrDefaultAsync(x => x.OrderId == order.Id && x.ProductId == model.ProductId);

            order.ShipperId = model.ShipperId;
            orderDetails.Quantity = model.Quantity;

            _context.OrderDetails.Update(orderDetails);
            _context.Orders.Update(order);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var order = await GetById(id);
            _context.Attach(order);
            _context.Orders.Remove(order);
            _context.SaveChanges();
        }
    }
}
