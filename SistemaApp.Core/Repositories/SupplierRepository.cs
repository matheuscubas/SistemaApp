using Dapper;
using SistemaApp.Core.Data;
using SistemaApp.Core.Extensions;
using SistemaApp.Core.Models;
using SistemaApp.Core.Services.ConnectionService;

namespace SistemaApp.Core.Repositories
{
    public class SupplierRepository : RepositoryCud<Supplier>, IRepositoryCud<Supplier>, IRepositoryRead<Supplier>
    {
        private readonly ConnectionService _connection;
        private readonly string GetAllSupplierQuery = @"
                                                    SELECT Suppliers.SupplierId AS Id,
                                                    Suppliers.SupplierName AS Name,
                                                    Suppliers.ContactName,
                                                    Suppliers.Address,
                                                    Suppliers.City,
                                                    Suppliers.PostalCode,
                                                    Suppliers.Country,
                                                    Suppliers.Phone
                                                    FROM Suppliers";

        public SupplierRepository(SistemaAppDbContext context, ConnectionService connection) : base(context)
        {
            _connection = connection;
        }

        public async Task<IEnumerable<Supplier>> GetAllAsync()
        {
            using var connection = _connection.Connection();
            return await connection.QueryAsync<Supplier>(GetAllSupplierQuery);
        }

        public async Task<Supplier?> GetById(int id)
        {
            var query = @"
                        SELECT Suppliers.SupplierId AS Id,
                        Suppliers.SupplierName AS Name,
                        Suppliers.ContactName,
                        Suppliers.Address,
                        Suppliers.City,
                        Suppliers.PostalCode,
                        Suppliers.Country,
                        Suppliers.Phone
                        FROM Suppliers
                        WHERE Suppliers.SupplierId = @Id";

            using var connection = _connection.Connection();
            return await connection.QueryFirstAsync<Supplier>(query, new { Id = id });
        }

        public async Task<PaginationResult<Supplier>> GetPaginated(int pageSize, int pageNumber)
        {
            using var connection = _connection.Connection();
            return await connection.GetUsingSqlServerNativePagination<Supplier, object>(GetAllSupplierQuery, new { }, pageSize, pageNumber);
        }
    }
}
