using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaApp.Core.Models;

namespace SistemaApp.Core.Data.Mappings
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");

            //Id
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .HasColumnName("ProductId")
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            //SupplierId
            builder.Property(x => x.SupplierId)
                .HasDefaultValue(null);

            //CategoryId
            builder.Property(x => x.CategoryId)
                .HasDefaultValue(null);

            //Unit
            builder.Property(x => x.Unit)
                .HasDefaultValue(null);

            //Price
            builder.Property(x => x.Price)
                .HasPrecision(18,2)
                .HasDefaultValue(null);


            //Relations
            builder.HasOne(x => x.Supplier)
                .WithMany(x => x.Products)
                .HasForeignKey(x => x.SupplierId)
                .OnDelete(DeleteBehavior.NoAction)
                .IsRequired();

            builder.HasOne(x => x.Category)
                .WithMany(x => x.Products)
                .HasForeignKey(x => x.CategoryId)
                .OnDelete(DeleteBehavior.NoAction)
                .IsRequired();

            builder.Navigation(x => x.Supplier);
            builder.Navigation(x => x.Category);
        }
    }
}
