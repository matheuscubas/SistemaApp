using SistemaApp.Core.Models;
using Encrypt = BCrypt.Net.BCrypt;

namespace SistemaApp.Core.Services.PasswordService
{

    public class PasswordService : IPasswordService
    {
        public string GeneratePassword()
        {
            var guid = Guid.NewGuid();
            var password = guid.ToString().Replace("-", "")[..25];
            return password;
        }

        public string EncryptPassword(string password)
            => Encrypt.HashPassword(password);

        public bool IsCorrectPassword(string password, User user)
            => Encrypt.Verify(password, user.Password);
    }
}
