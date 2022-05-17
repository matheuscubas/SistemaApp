using Dapper;
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

        public override Order GetById(int id)
        {
            var query = @"Select
	                        OrderId as Id,
	                        CustomerId,
	                        EmployeeId,
	                        ShipperId,
	                        OrderDate
                          FROM
	                        Orders
                          WHERE
                            Orders.OrderId = @orderId";

            using var connection = _connection.Connection();
            var order = connection.QueryFirstOrDefault<Order>(query, new { orderId = id });

            return order;
        }
        public override async Task<IEnumerable<Order>> GetPaginated(int pageSize, int pageNumber)
        {
            var query = @"SELECT 
                            [Orders].* 
                            FROM
                            Orders";

            var connection = _connection.Connection();

            var result = await connection.GetUsingSqlServerNativePagination<Order, object>(query, new { },pageSize, pageNumber);
            return result.Items;
        }
    }
}
