using Microsoft.EntityFrameworkCore;
using SistemaApp.Core.Models;
using SistemaApp.Core.Services.CsvReader;

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

            context.Roles.AddRange(roles);
            context.SaveChanges();
        }
    }
}
