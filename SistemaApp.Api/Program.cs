using Microsoft.EntityFrameworkCore;
using Serilog;
using SistemaApp.Core.Data;
using SistemaApp.Core.Extensions;
using SistemaApp.Core.Repositories;
using SistemaApp.Core.Services.ConnectionService;
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
builder.Services.AddSingleton<Logger>(logger);

//builder.Services.AddHandlerSeeder();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
