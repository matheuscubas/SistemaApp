using Microsoft.Extensions.DependencyInjection;
using SistemaApp.Core.Data;
using SistemaApp.Core.Data.Seed;
using System.Reflection;

namespace SistemaApp.Core.Extensions
{
    public static class SeederExtensions
    {
        public static IServiceCollection AddHandlerSeeder(this IServiceCollection collection)
        {
            var serviceProvider = collection.BuildServiceProvider();
            var context = serviceProvider.GetService<SistemaAppDbContext>();

            var sets = context?.GetDbSetProperties();

            if (sets is not null)
            {
                foreach (var set in sets)
                {
                    MethodInfo? method = typeof(SeederExtensions).GetMethod(nameof(Seed), BindingFlags.NonPublic|BindingFlags.Static);
                    MethodInfo? generic = method?.MakeGenericMethod(set.PropertyType.GetGenericArguments().First());
                    generic?.Invoke(set, new object?[] { context });
                }
            }

            return collection;
        }

        private static void Seed<T>(SistemaAppDbContext context)
            where T : class
        {
            var type = typeof(ISeeder<T>);

            var seeder = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(x => x.GetTypes())
                .Where(x => type.IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract)
                .Select(x => Activator.CreateInstance(x))
                .Cast<ISeeder<T>>()
                .First();

            if (!context.Set<T>().Any())
            {
                seeder.SeedData(context);
            }
        }
    }
}
