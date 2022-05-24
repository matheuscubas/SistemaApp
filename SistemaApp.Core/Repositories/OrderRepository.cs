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

        public async Task<int> CreateAsync(CreateOrderDto dto)
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

            await _context.Orders.AddAsync(order);
            await _context.OrderDetails.AddAsync(orderdetail);
            await _context.SaveChangesAsync();
            return order.Id;
        }

        public async Task<IEnumerable<OrderWithNamesDto>> GetAllAsync()
        {
            using var connection = _connection.Connection();
            var orders = await connection.QueryAsync<OrderWithNamesDto>(GetAllQueryOrdersWithNames);

            return orders;
        }

        public async Task<IEnumerable<OrderWithNamesDto?>> GetByIdAsync(int id)
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

        public async Task<Order?> GetById(int id)
        {
            var query = @"
                        SELECT Orders.OrderId AS Id,
                        Orders.CustomerId AS CustomerId,
                        Orders.EmployeeId AS EmployeeId,
                        Orders.ShipperId AS ShipperId,
                        Orders.OrderDate AS OrderDate
                        FROM Orders
                        WHERE OrderId = @Id";

            var connection = _connection.Connection();
            var order = await connection.QueryFirstAsync<Order>(query, new { Id = id });

            return order;
        }
        public  async Task<PaginationResult<OrderWithNamesDto>> GetPaginated(int pageSize, int pageNumber)
        {
            var connection = _connection.Connection();

            var result = await connection.GetUsingSqlServerNativePagination<OrderWithNamesDto, object>(GetAllQueryOrdersWithNames, new { },pageSize, pageNumber);
            return result;
        }

        public async Task UpdateAsync(UpdateOrderDto model)
        {
            var order = await GetById(model.OrderId);
            //TODO: quando tiver orderDetail Repository usar metodo get by id aqui.
            var orderDetailQuery = @"SELECT OrderDetails.OrderDetailId AS Id,
                                    OrderDetails.OrderId AS OrderId,
                                    OrderDetails.ProductId AS ProductId,
                                    OrderDetails.Quantity AS Quantity 
                                    FROM OrderDetails
                                    WHERE OrderDetails.OrderId = @OrderId
                                    AND OrderDetails.ProductId = @ProductId";

            _context.Orders.Attach(order);
            using var connection = _connection.Connection();
            var orderDetails = await connection.QueryFirstAsync<OrderDetail>(orderDetailQuery, new { OrderId = model.OrderId, ProductId = model.ProductId });
            _context.OrderDetails.Attach(orderDetails);

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

        Task<OrderWithNamesDto?> IRepositoryRead<OrderWithNamesDto>.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
