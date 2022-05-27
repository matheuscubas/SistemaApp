using Microsoft.EntityFrameworkCore;
using SistemaApp.Core.Models;

namespace SistemaApp.Core.Data.Seed
{
    public class RoleSeeder : ISeeder<Role>
    {
        public void SeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(
                new Role
                {
                    Id = 1,
                    Name = "Admin"
                },
                new Role
                {
                    Id = 2,
                    Name = "Client"
                }
                );
        }

        public void SeedData(SistemaAppDbContext context)
        {
            Role[] roles = 
                {
                    new Role
                    {
                        Id = 1,
                        Name = "Admin"
                    },
                    new Role
                    {
                        Id = 2,
                        Name = "Client"
                    } 
                };

            using var transaction = context.Database.BeginTransaction();
            var table = context.Model.FindEntityType(typeof(Role)).GetSchemaQualifiedTableName();
            context.Roles.AddRange(roles);
            context.Database.ExecuteSqlRaw($"SET IDENTITY_INSERT {table} ON");
            context.SaveChanges();
            transaction.Commit();
        }
    }
}
