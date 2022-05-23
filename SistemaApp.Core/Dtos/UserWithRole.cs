using SistemaApp.Core.Models;

namespace SistemaApp.Core.Dtos
{
    public class UserWithRole : User
    {
        public string Rolename { get; set; }
    }
}
