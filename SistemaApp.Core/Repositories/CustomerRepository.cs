using Dapper;
using SistemaApp.Core.Data;
using SistemaApp.Core.Extensions;
using SistemaApp.Core.Models;
using SistemaApp.Core.Services.ConnectionService;

namespace SistemaApp.Core.Repositories
{
    public class CustomerRepository : RepositoryCud<Customer>, IRepositoryRead<Customer>, IRepositoryCud<Customer>
    {
        private readonly ConnectionService _connection;
        private const string GetAllCustomersQuery = @"
                                                    SELECT Customers.CustomerId AS Id,
                                                    Customers.CustomerName AS Name,
                                                    Customers.ContactName AS ContactName,
                                                    Customers.Address AS Address,
                                                    Customers.City AS City,
                                                    Customers.PostalCode AS PostalCode,
                                                    Customers.Country AS Country
                                                    FROM Customers";
        public CustomerRepository(SistemaAppDbContext context, ConnectionService connection) 
            : base(context)
        {
            _connection = connection;
        }

        public async Task<IEnumerable<Customer>> GetAllAsync()
        {
            using var connection = _connection.Connection();
            var customers = await connection.QueryAsync<Customer>(GetAllCustomersQuery);

            return customers;
        }

        public async Task<Customer?> GetById(int id)
        {
            var query = @"
                        SELECT Customers.CustomerId AS Id,
                        Customers.CustomerName AS Name,
                        Customers.ContactName AS ContactName,
                        Customers.Address AS Address,
                        Customers.City AS City,
                        Customers.PostalCode AS PostalCode,
                        Customers.Country AS Country
                        FROM Customers
                        WHERE Customers.CustomerId = @Id";

            using var connection = _connection.Connection();
            var customer = await connection.QueryFirstAsync<Customer>(query, new { Id = id });

            return customer;
        }

        public async Task<PaginationResult<Customer>> GetPaginated(int pageSize, int pageNumber)
        {
            using var connection = _connection.Connection();
            var result = await connection.GetUsingSqlServerNativePagination<Customer, object>(GetAllCustomersQuery, new { }, pageSize, pageNumber);

            return result;
        }
    }
}
