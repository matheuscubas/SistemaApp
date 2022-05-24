using SistemaApp.Core.Dtos;

namespace SistemaApp.Core.Services.TokenService
{
    public interface ITokenService
    {
        public string GenerateToken(UserWithRole user);
    }
}
