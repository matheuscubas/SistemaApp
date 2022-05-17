using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace SistemaApp.Core.Services.ConnectionService
{
    public class ConnectionService : IConnectionService
    {
        private readonly IConfiguration _configuration;

        public ConnectionService(IConfiguration configuration)
            => _configuration = configuration;

        public IDbConnection Connection()
            => new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
    }
}
