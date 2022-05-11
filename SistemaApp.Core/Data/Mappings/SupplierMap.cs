using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaApp.Core.Models;

namespace SistemaApp.Core.Data.Mappings
{
    public class SupplierMap : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            builder.ToTable("Suppliers");

            //Id
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .HasColumnName("SupplierId")
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            //Name
            builder.Property(x => x.Name)
                .HasColumnName("SupplierName")
                .HasDefaultValue(null);

            //Contact
            builder.Property(x => x.ContactName)
                .HasDefaultValue(null);

            //Address
            builder.Property(x => x.Address)
                .HasDefaultValue(null);

            //City
            builder.Property(x => x.City)
                .HasDefaultValue(null);

            //PostalCode
            builder.Property(x => x.PostalCode)
                .HasDefaultValue(null);

            //Country
            builder.Property(x => x.Country)
                .HasDefaultValue(null);

            //Phone
            builder.Property(x => x.Phone)
                .HasDefaultValue(null);
        }
    }
}
