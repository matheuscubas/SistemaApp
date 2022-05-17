using System.Data;

namespace SistemaApp.Core.Services.ConnectionService
{
    public interface IConnectionService
    {
        public IDbConnection Connection();
    }
}