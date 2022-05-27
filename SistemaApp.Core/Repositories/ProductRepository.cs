using Dapper;
using SistemaApp.Core.Data;
using SistemaApp.Core.Extensions;
using SistemaApp.Core.Models;
using SistemaApp.Core.Services.ConnectionService;

namespace SistemaApp.Core.Repositories
{
    public class ProductRepository : RepositoryCud<Product>, IRepositoryCud<Product>, IRepositoryRead<Product>
    {
        private readonly IConnectionService _connection;
        private const string GetAllProductsQuery = @"
                        SELECT Products.ProductId AS Id,
                        Products.Name,
                        Products.SupplierId,
                        Products.CategoryId,
                        Products.Unit,
                        Products.Price
                        FROM Products";

        public ProductRepository(SistemaAppDbContext context, IConnectionService connection) 
            : base(context)
        {
            _connection = connection;
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            using var connection = _connection.Connection();
            return await connection.QueryAsync<Product>(GetAllProductsQuery);
        }

        public async Task<Product?> GetById(int id)
        {
            var query = @"
                        SELECT Products.ProductId AS Id,
                        Products.Name,
                        Products.SupplierId,
                        Products.CategoryId,
                        Products.Unit,
                        Products.Price
                        FROM Products
                        WHERE Products.ProductId = @Id";

            using var connection = _connection.Connection();
            return await connection.QueryFirstAsync<Product>(query, new { Id = id });
        }

        public async Task<PaginationResult<Product>> GetPaginated(int pageSize, int pageNumber)
        {
            using var connection = _connection.Connection();
            return await connection.GetUsingSqlServerNativePagination<Product, object>(GetAllProductsQuery, new { }, pageSize, pageNumber);
        }
    }
}
