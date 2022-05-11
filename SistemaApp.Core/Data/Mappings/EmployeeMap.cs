using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaApp.Core.Models;

namespace SistemaApp.Core.Data.Mappings
{
    public class EmployeeMap : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employees");

            //Id
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .HasColumnName("EmployeeId")
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            //FirstName
            builder.Property(x => x.FirstName)
                .HasDefaultValue(null);

            //LastName
            builder.Property(x => x.LastName)
                .HasDefaultValue(null);

            //BirthDate
            builder.Property(x => x.BirthDate)
                .HasDefaultValue(null);

            //Photo
            builder.Property(x => x.Photo)
                .HasDefaultValue(null);

            //Notes
            builder.Property(x => x.Notes)
                .HasColumnType("ntext")
                .HasDefaultValue(null);
        }
    }
}
