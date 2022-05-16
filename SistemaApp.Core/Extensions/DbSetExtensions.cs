//using Microsoft.EntityFrameworkCore;
//using SistemaApp.Core.Data;
//using System.Reflection;

//namespace SistemaApp.Core.Extensions
//{
//    public static class DbSetExtensions
//    {
//        public static List<PropertyInfo> GetDbSetProperties(this SistemaAppDbContext context)
//        {
//            var dbSetProperties = new List<PropertyInfo>();
//            var properties = context.GetType().GetProperties();

//            foreach (var property in properties)
//            {
//                var setType = property.PropertyType;

//                var isDbSet = setType.IsGenericType && (typeof(DbSet<>).IsAssignableFrom(setType.GetGenericTypeDefinition()) || setType.GetInterface(typeof(DbSet<>).FullName) != null);

//                if (isDbSet)
//                {
//                    dbSetProperties.Add(property);
//                }
//            }

//            return dbSetProperties;

//        }
//    }
//}
