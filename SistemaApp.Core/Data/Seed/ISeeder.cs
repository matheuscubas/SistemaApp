using Microsoft.EntityFrameworkCore;

namespace SistemaApp.Core.Data.Seed
{
    public interface ISeeder<T>
        where T : class
    {
        //Transformar em um task para poder realizar de forma Assincrona dps.
        public void SeedData(ModelBuilder builder); //SistemaAppDbContext context);
    }
}
