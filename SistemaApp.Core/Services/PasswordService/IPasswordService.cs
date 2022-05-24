using SistemaApp.Core.Models;

namespace SistemaApp.Core.Services.PasswordService
{
    public interface IPasswordService 
    {
        public string GeneratePassword();

        public string EncryptPassword(string password);

        public bool IsCorrectPassword(string password, User user);
    }
}
