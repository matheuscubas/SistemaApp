﻿using SistemaApp.Core.Data;
using SistemaApp.Core.Models;
using SistemaApp.Core.Services.ConnectionService;
using Dapper;
using SistemaApp.Core.Services.PasswordService;
using SistemaApp.Core.Dtos;

namespace SistemaApp.Core.Repositories
{
    public class UserRepository : RepositoryCud<User>, IRepositoryCud<User>, IRepositoryRead<User>
    {
        private readonly IConnectionService _connection;
        private readonly IPasswordService _passwordService;
        public UserRepository(SistemaAppDbContext context,IConnectionService connection, IPasswordService passwordService) 
            : base(context)
        {
            _connection = connection;
            _passwordService = passwordService;
        }

        public async Task<UserWithRole> GetUserAsync(string username)
        {
            var query = @$"
                        SELECT 
                        Users.Id AS Id,
                        Users.Username AS Username,
                        Users.Password AS Password,
                        Users.RoleId AS RoleId,
                        Roles.Name AS Rolename
                        FROM Users
                        INNER JOIN Roles
                        ON Users.RoleId = Roles.Id
                        WHERE
                        Users.Username = @Username";

            using var connection = _connection.Connection();
            var user = await connection.QueryFirstOrDefaultAsync<UserWithRole>(query, new { Username = username });

            return user;
        }

        public async Task<User> CreateUserAsync(CrateUserDto model)
        {
            if (model.Password == null)
                model.Password = _passwordService.GeneratePassword();

            var user = new User()
            {
                Username = model.Username,
                Password = _passwordService.EncryptPassword(model.Password),
                RoleId = model.RoleId
            };

            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public Task<IEnumerable<User>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<User?> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<PaginationResult<User>> GetPaginated(int pageSize, int pageNumber)
        {
            throw new NotImplementedException();
        }
    }
}
