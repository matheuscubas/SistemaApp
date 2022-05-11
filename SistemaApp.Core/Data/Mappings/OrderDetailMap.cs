using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaApp.Core.Models;
using System.Security.Cryptography.X509Certificates;

namespace SistemaApp.Core.Data.Mappings
{
    public class OrderDetailMap : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.ToTable("OrderDetails");
            
            //Id
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .HasColumnName("OrderDetailId")
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            //OderId
            builder.Property(x => x.OrderId)
                .HasDefaultValue(null);

            //ProductId
            builder.Property(x => x.ProductId)
                .HasDefaultValue(null);

            //OderId
            builder.Property(x => x.Quantity)
                .HasDefaultValue(null);

            //Relations
            builder.HasOne(x => x.Order)
                .WithMany()
                .HasForeignKey(x => x.OrderId)
                .OnDelete(DeleteBehavior.NoAction)
                .IsRequired();

            builder.HasOne(x => x.Product)
                .WithMany()
                .HasForeignKey(x => x.ProductId)
                .OnDelete(DeleteBehavior.NoAction)
                .IsRequired();
        }
    }
}
