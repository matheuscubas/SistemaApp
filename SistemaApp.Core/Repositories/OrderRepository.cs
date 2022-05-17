using Dapper;
using SistemaApp.Core.Data;
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

        public override IEnumerable<Order> GetAll()
        {
            var query = @"SELECT 
                            [Orders].* 
                          FROM
                            Orders";

            using var connection = _connection.Connection();
            var orders = connection.Query<Order>(query);

            return orders;
        }

        public override Order GetById(int id)
        {
            var query = @"SELECT 
                            [Orders].* 
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
