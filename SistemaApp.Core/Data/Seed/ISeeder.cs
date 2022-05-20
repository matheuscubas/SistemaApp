using Microsoft.EntityFrameworkCore;

namespace SistemaApp.Core.Data.Seed
{
    public interface ISeeder<T>
        where T : class
    {

        //É realmente necessário o ISeeder ser <T> genérico????
        //Tentar ver isso sem dps.

        //Transformar em um task para poder realizar de forma Assincrona dps.
        public void SeedData(SistemaAppDbContext context);
        public void SeedData(ModelBuilder modelBuilder);
    }
}
