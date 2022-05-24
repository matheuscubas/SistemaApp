using Dapper;
using SistemaApp.Core.Data;
using SistemaApp.Core.Extensions;
using SistemaApp.Core.Models;
using SistemaApp.Core.Services.ConnectionService;

namespace SistemaApp.Core.Repositories
{
    public class CategoryRepository : RepositoryCud<Category>, IRepositoryRead<Category>, IRepositoryCud<Category>
    {
        private readonly ConnectionService _connection;
        private const string GetAllCategoriesQuery = @"
                        SELECT Categories.CategoryId AS Id,
                        Categories.CategoryName AS Name,
                        Categories.Description AS Description
                        FROM Categories";
        public CategoryRepository(SistemaAppDbContext context, ConnectionService connection)
            : base(context)
        {
            _connection = connection;
        }

        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            using var connection = _connection.Connection();
            var categories = await connection.QueryAsync<Category>(GetAllCategoriesQuery);

            return categories;
        }

        public async Task<Category?> GetById(int id)
        {
            var query = @"
                        SELECT Categories.CategoryId AS Id,
                        Categories.CategoryName AS Name,
                        Categories.Description AS Description
                        FROM Categories
                        WHERE Categories.CategoryId = @CategoryId";

            using var connection = _connection.Connection();
            var category = await connection.QueryFirstAsync<Category>(query, new { CategoryId = id });

            return category;
        }

        public async Task<PaginationResult<Category>> GetPaginated(int pageSize, int pageNumber)
        {
            using var connection = _connection.Connection();
            var result = await connection.GetUsingSqlServerNativePagination<Category, object>(GetAllCategoriesQuery, new { }, pageSize, pageNumber);

            return result;
        }
    }
}
