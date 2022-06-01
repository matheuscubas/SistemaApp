using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using SistemaApp.Core.Data;

namespace SistemaApp.Core.Extensions
{
    public static class EntityFrameworkExtensions
    {
        public static List<Type> GetDbSetProperties(this SistemaAppDbContext context)
        {
            var dbSetProperties = new List<Type>();
            var properties = context.GetType().GetProperties();

            foreach (var property in properties)
            {
                var setType = property.PropertyType;

                var isDbSet = setType.IsGenericType && 
                              (typeof(DbSet<>).IsAssignableFrom(setType.GetGenericTypeDefinition()) || 
                              setType.GetInterface(typeof(DbSet<>).FullName!) != null);

                if (isDbSet)
                {
                    dbSetProperties.Add(property.PropertyType.GetGenericArguments()
                        .First());
                }
            }

            return dbSetProperties;

        }

        public static IEntityType GetEntityType<TType>(this SistemaAppDbContext context)
            where TType : class
        {
            var entityType = context.Model.FindEntityType(typeof(TType));

            if (entityType is null)
            {
                throw new InvalidOperationException($"Not able to get type from {typeof(TType)}");
            }

            return entityType;
        }
    }
}
