using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Serilog;
using SistemaApp.Core.Data;
using SistemaApp.Core.Repositories;
using SistemaApp.Core.Services.ConnectionService;
using SistemaApp.Core.Services.PasswordService;
using SistemaApp.Core.Services.TokenService;
using System.Text;
using Logger = Serilog.ILogger;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var logger = new LoggerConfiguration()
    .ReadFrom.Configuration(builder.Configuration)
    .CreateLogger();

builder.Logging.ClearProviders();
builder.Logging.AddSerilog(logger);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<SistemaAppDbContext>(x => x
.UseSqlServer(
    builder
    .Configuration
    .GetConnectionString("DefaultConnection")!
    ));
builder.Services.AddScoped<ConnectionService>();
builder.Services.AddScoped<OrderRepository>();
builder.Services.AddTransient<TokenService>();
builder.Services.AddScoped<PasswordService>();
builder.Services.AddSingleton<Logger>(logger);
AuthConfiguration(builder);

//builder.Services.AddHandlerSeeder();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();

void AuthConfiguration(WebApplicationBuilder builder)
{
    var key = Encoding.ASCII.GetBytes("ZmVkYWY3ZDg4NjNiNDhlMTk3YjkyODdkNDkyYjcwOGU=");
    builder.Services.AddAuthentication(x =>
    {
        x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    }).AddJwtBearer(x =>
    {
        x.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(key),
            ValidateIssuer = false,
            ValidateAudience = false
        };
    });
}