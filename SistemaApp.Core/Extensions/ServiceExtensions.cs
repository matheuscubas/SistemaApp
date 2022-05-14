﻿using Microsoft.Extensions.DependencyInjection;
using SistemaApp.Core.Data;
using SistemaApp.Core.Data.Seed;

namespace SistemaApp.Core.Extensions
{
    public static class ServiceExtensions
    {
       public static IServiceCollection AddSeeder(
           this IServiceCollection collection)
        {
            var serviceProvider = collection.BuildServiceProvider();
            var context = serviceProvider.GetService<SistemaAppDbContext>();
            var type = typeof(ISeeder<object>);

            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(x => x.GetTypes())
                .Where(x => type.IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract)
                .Select(x => Activator.CreateInstance(x))
                .Cast<ISeeder<object>>();

            foreach (var seeder in types)
                seeder.SeedData(context);

            return collection;
        }
    }
}
