using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaApp.Core.Models;

namespace SistemaApp.Core.Data.Mappings
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories");
            //Id Configuration
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .HasColumnName("CategoryId")
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();
            
            //Name Configuration
            builder.Property(x => x.Name)
                .HasColumnName("CategoryName")
                .HasDefaultValue(null);

            //DescriptionConfiguration
            builder.Property(x => x.Description)
                .HasDefaultValue(null);
        }
    }
}
