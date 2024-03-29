﻿using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Serilog;
using SistemaApp.Core.Data;
using SistemaApp.Core.Extensions;
using SistemaApp.Core.Repositories;
using SistemaApp.Core.Services.ConnectionService;
using SistemaApp.Core.Services.PasswordService;
using SistemaApp.Core.Services.TokenService;
using System.Text;
using Logger = Serilog.ILogger;

namespace SistemaApp.Api.Configuration
{
    public static class Configuration
    {
        public static void AddServices(this WebApplicationBuilder builder)
        {
            var logger = new LoggerConfiguration()
                .ReadFrom.Configuration(builder.Configuration)
                .CreateLogger();

            var key = Encoding.ASCII.GetBytes(builder.Configuration.GetValue<string>("Secrets:JwtKeySecret"));

            builder.Logging.ClearProviders();
            builder.Logging.AddSerilog(logger);
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<SistemaAppDbContext>(options => options
            .UseSqlServer(
                builder
                .Configuration
                .GetConnectionString("DefaultConnection")!
                ));
            builder.Services.AddScoped<IConnectionService, ConnectionService>();
            builder.Services.AddScoped<ITokenService, TokenService>();
            builder.Services.AddScoped<IPasswordService, PasswordService>();
            builder.Services.AddSingleton<Logger>(logger);
            builder.Services.AddScoped<UserRepository>();
            builder.Services.AddScoped<OrderRepository>();
            builder.Services.AddScoped<CategoryRepository>();
            builder.Services.AddScoped<CustomerRepository>();
            builder.Services.AddScoped<EmployeeRepository>();
            builder.Services.AddScoped<ProductRepository>();
            builder.Services.AddScoped<ShipperRepository>();
            builder.Services.AddScoped<SupplierRepository>();
            builder.Services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });
            builder.Services.AddAuthorization();
            builder.Services.AddHandlerSeeder();
            builder.Services.AddControllers();
        }
    }
}
