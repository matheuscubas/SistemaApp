using Dapper;
using DesafioDesafiante.Services;
using Microsoft.AspNetCore.Connections.Features;
using SistemaApp.Core.Data;
using SistemaApp.Core.Extensions;
using SistemaApp.Core.Models;

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
        public override IEnumerable<Order> GetPaginated(int pageSize, int pageNumber)
        {
            var query = @"SELECT 
                            [Orders].* 
                          FROM
                            Orders";

            QueryExentions.GetUsingSqlServerNativePagination<Order>(_connection, query, parameters: , pageSize, pageNumber);
        }
    }
}
