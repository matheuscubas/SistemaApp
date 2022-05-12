using SistemaApp.Core.Data;
using SistemaApp.Core.Data.Seed;

namespace SistemaApp.Core.Extensions
{
    public class ServiceExtensions
    {
       public void AddSeeder(SistemaAppDbContext context)
        {
            var type = typeof(ISeeder);

            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(x => x.GetTypes())
                .Where(x => type.IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract)
                .Select(x => Activator.CreateInstance(x))
                .Cast<ISeeder>();

            foreach (var seeder in types)
                seeder.SeedData(context);
        }
    }
}
