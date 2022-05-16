using System.Data;

namespace DesafioDesafiante.Services
{
    public interface IConnectionService
    {
        public IDbConnection Connection();
    }
}