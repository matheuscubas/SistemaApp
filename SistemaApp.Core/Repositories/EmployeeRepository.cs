using Dapper;
using SistemaApp.Core.Data;
using SistemaApp.Core.Extensions;
using SistemaApp.Core.Models;
using SistemaApp.Core.Services.ConnectionService;

namespace SistemaApp.Core.Repositories
{
    public class EmployeeRepository : RepositoryCud<Employee>, IRepositoryCud<Employee>, IRepositoryRead<Employee>
    {
        private const string GetAllEmployeesQuery = @"
                                                    SELECT Employees.EmployeeId AS Id,
                                                    Employees.FirstName,
                                                    Employees.LastName,
                                                    Employees.BirthDate,
                                                    Employees.Photo,
                                                    Employees.Notes
                                                    FROM Employees";
        private readonly IConnectionService _connection;
        public EmployeeRepository(SistemaAppDbContext context, IConnectionService connection) : base(context)
        {
            _connection = connection;
        }

        public async Task<IEnumerable<Employee>> GetAllAsync()
        {
            using var connection = _connection.Connection();
            return await connection.QueryAsync<Employee>(GetAllEmployeesQuery);
        }

        public async Task<Employee?> GetById(int id)
        {
            var query = @"
                        SELECT Employees.EmployeeId AS Id,
                        Employees.FirstName,
                        Employees.LastName,
                        Employees.BirthDate,
                        Employees.Photo,
                        Employees.Notes
                        FROM Employees
                        WHERE Employees.EmployeeId = @Id";

            using var connection = _connection.Connection();
            return await connection.QueryFirstAsync<Employee>(query, new { Id = id });
        }

        public async Task<PaginationResult<Employee>> GetPaginated(int pageSize, int pageNumber)
        {
            using var connection = _connection.Connection();
            var result = await connection.GetUsingSqlServerNativePagination<Employee, object>(GetAllEmployeesQuery, new { }, pageSize, pageNumber);

            return result;
        }
    }
}
