using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaApp.Core.Models;

namespace SistemaApp.Core.Data.Mappings
{
    public class ShipperMap : IEntityTypeConfiguration<Shipper>
    {
        public void Configure(EntityTypeBuilder<Shipper> builder)
        {
            builder.ToTable("Shippers");

            //Id
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .HasColumnName("ShipperId")
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            //Name
            builder.Property(x => x.Name)
                .HasColumnName("ShipperName")
                .HasDefaultValue(null);

            //Phone
            builder.Property(x => x.Phone)
                .HasDefaultValue(null);
        }
    }
}
