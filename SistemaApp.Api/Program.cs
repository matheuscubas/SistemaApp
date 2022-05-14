using Microsoft.EntityFrameworkCore;
using Serilog;
using SistemaApp.Core.Data;

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

//Regra para ver se o banco est� vazio
//if(DbSet<T>.Any())
//chamar o CsvReader pra gerar o Csv
//chamar o seed u

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
