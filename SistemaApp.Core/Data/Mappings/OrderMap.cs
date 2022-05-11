using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaApp.Core.Models;

namespace SistemaApp.Core.Data.Mappings
{
    internal class OrderMap : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Orders");

            //Id
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .HasColumnName("OrderId")
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            //CustomerId
            builder.Property(x => x.CustomerId)
                .HasDefaultValue(null);

            //EmployeeId
            builder.Property(x => x.EmployeeId)
                .HasDefaultValue(null);

            //CustomerId
            builder.Property(x => x.OrderDate)
                .HasDefaultValue(null);

            //CustomerId
            builder.Property(x => x.ShipperId)
                .HasDefaultValue(null);

            builder.Property(x => x.Customer);
            builder.Property(x => x.Employee);
            builder.Property(x => x.Shipper);
        }
    }
}
