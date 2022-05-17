//using Microsoft.EntityFrameworkCore.Metadata.Internal;
//using Microsoft.Extensions.DependencyInjection;
//using SistemaApp.Core.Data;
//using System.Reflection;

//namespace SistemaApp.Core.Extensions
//{
//    public static class SeederExtensions
//    {

//        //Possivel solução para o Seeder?
//        //Mesmo tendo que rodar reflection 2x só vai ser usado se o banco não estiver populado no launch
//        public static IServiceCollection AddHandlerSeeder(this IServiceCollection collection)
//        {
//            var serviceProvider = collection.BuildServiceProvider();
//            var context = serviceProvider.GetService<SistemaAppDbContext>();

//            var sets = context?.GetDbSetProperties();

//            if (sets is not null)
//            {
//                foreach (var set in sets)
//                {
//                    MethodInfo? method = typeof(SeederExtensions).GetMethod(nameof(SeedAll))?.MakeGenericMethod(set.GetType()); ;
//                    method?.Invoke(set, new object?[] { context });
//                }
//            }

//            return collection;
//        }

//        private static void SeedAll<T>(SistemaAppDbContext context)
//            where T : Model
//        {
//            //var type = typeof(ISeeder<>);
//            //var types = AppDomain.CurrentDomain.GetAssemblies()
//            //    .SelectMany(x => x.GetTypes())
//            //    .Where(x => type.IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract)
//            //    .Select(x => Activator.CreateInstance(x))
//            //    .Cast<ISeeder<>>();

//            Console.WriteLine(context.Set<T>().Count());
//        }
//    }
//}
