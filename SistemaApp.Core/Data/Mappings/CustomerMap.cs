using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaApp.Core.Models;

namespace SistemaApp.Core.Data.Mappings
{
    public class CustomerMap : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customers");

            //Id
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .HasColumnName("CustomerId")
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            //Name
            builder.Property(x => x.Name)
                .HasColumnName("CustomerName")
                .HasDefaultValue(null);

            //ContractName
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
        }
    }
}
