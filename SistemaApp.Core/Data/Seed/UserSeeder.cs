using Microsoft.EntityFrameworkCore;
using SistemaApp.Core.Models;
using SistemaApp.Core.Services.PasswordService;

namespace SistemaApp.Core.Data.Seed
{   
    public class UserSeeder : ISeeder<User>
    {
        private readonly PasswordService _passwordService = new PasswordService();
        public void SeedData(SistemaAppDbContext context)
        {
            User[] users = {
            new User
            {
                Id = 1,
                Username = "Matheus",
                Password = _passwordService.EncryptPassword("teste123"),
                RoleId = 1
            },
            new User
            {
                Id = 2,
                Username = "PrimeiroCliente",
                Password = _passwordService.EncryptPassword("secreto123"),
                RoleId = 2
            }
            };

            using var transaction = context.Database.BeginTransaction();
            var table = context.Model.FindEntityType(typeof(User)).GetSchemaQualifiedTableName();
            context.Users.AddRange(users);
            context.Database.ExecuteSqlRaw($"SET IDENTITY_INSERT {table} ON");
            context.SaveChanges();
            transaction.Commit();
        }

        public void SeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
               new User
               {

                   Id = 1,
                   Username = "Matheus",
                   Password = _passwordService.EncryptPassword("teste123"),
                   RoleId = 1
               },
               new User
               {
                   Id = 2,
                   Username = "PrimeiroCliente",
                   Password = _passwordService.EncryptPassword("secreto123"),
                   RoleId = 2
               }
               );
        }
    }
}
