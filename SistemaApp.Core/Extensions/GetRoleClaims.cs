using SistemaApp.Core.Dtos;
using System.Security.Claims;

namespace SistemaApp.Core.Extensions
{
    public static class GetRoleClaims
    {
        public static IEnumerable<Claim> GetClaims(this UserWithRole user)
        {
            var result = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.Username),
                new Claim(ClaimTypes.Role, user.Rolename)
            };
            return result;
        }
    }
}
