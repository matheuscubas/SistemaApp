using SistemaApp.Core.Data;
using SistemaApp.Core.Models;
using SistemaApp.Core.Services.ConnectionService;

namespace SistemaApp.Core.Repositories
{
    public class ProductRepository : RepositoryCud<Product>, IRepositoryCud<Product>, IRepositoryRead<Product>
    {
        private readonly ConnectionService _connection;
        private const string GetAllProductsQuery = @"
                        SELECT Products.ProductId AS Id,
                        Products.Name,
                        Products.SupplierId,
                        Products.CategoryId,
                        Products.Unit,
                        Products.Price
                        FROM Products";

        public ProductRepository(SistemaAppDbContext context, ConnectionService connection) 
            : base(context)
        {
            _connection = connection;
        }

        public Task<IEnumerable<Product>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Product?> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<PaginationResult<Product>> GetPaginated(int pageSize, int pageNumber)
        {
            throw new NotImplementedException();
        }
    }
}
