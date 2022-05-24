using SistemaApp.Core.Models;

namespace SistemaApp.Core.Services.PasswordService
{
    using BCrypt.Net;

    public class PasswordService : IPasswordService
    {
        public string GeneratePassword()
        {
            var guid = Guid.NewGuid();
            var password = guid.ToString().Replace("-", "")[..25];
            return password;
        }

        public string EncryptPassword(string password)
            => BCrypt.HashPassword(password);

        public bool IsCorrectPassword(string password, User user)
            => BCrypt.Verify(password, user.Password);
    }
}
