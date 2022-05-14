using SistemaApp.Core.Services.CsvReader;

namespace SistemaApp.Core.Data.Seed
{
    public interface ISeeder<T>
        where T : class
    {
        //Transformar em um task para poder realizar de forma Assincrona dps.
        public void SeedData(SistemaAppDbContext context);
    }
}
