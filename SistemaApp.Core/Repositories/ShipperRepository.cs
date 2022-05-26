using Dapper;
using SistemaApp.Core.Data;
using SistemaApp.Core.Extensions;
using SistemaApp.Core.Models;
using SistemaApp.Core.Services.ConnectionService;

namespace SistemaApp.Core.Repositories
{
    public class ShipperRepository : RepositoryCud<Shipper>, IRepositoryCud<Shipper>, IRepositoryRead<Shipper>
    {
        private readonly ConnectionService _connection;
        private readonly string GetAllShippersQuery = @"
                                                    SELECT Shippers.ShipperId AS Id,
                                                    Shippers.ShipperName AS Name,
                                                    Shippers.Phone
                                                    FROM Shippers";
        public ShipperRepository(SistemaAppDbContext context, ConnectionService connection) 
            : base(context)
        {
            _connection = connection;
        }

        public async Task<IEnumerable<Shipper>> GetAllAsync()
        {
            using var connection = _connection.Connection();
            return await connection.QueryAsync<Shipper>(GetAllShippersQuery);
        }

        public async Task<Shipper?> GetById(int id)
        {
            var query = @"
                        SELECT Shippers.ShipperId AS Id,
                        Shippers.ShipperName AS Name,
                        Shippers.Phone
                        FROM Shippers
                        WHERE Shippers.ShipperId = @Id";

            using var connection = _connection.Connection();
            return await connection.QueryFirstAsync<Shipper>(query, new { Id = id });
        }

        public async Task<PaginationResult<Shipper>> GetPaginated(int pageSize, int pageNumber)
        {
            using var connection = _connection.Connection();
            return await connection.GetUsingSqlServerNativePagination<Shipper, object>(GetAllShippersQuery, new { }, pageSize, pageNumber);
        }
    }
}
