﻿using Microsoft.EntityFrameworkCore;
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

            //OrderDate
            builder.Property(x => x.OrderDate)
                .HasDefaultValue(null);

            //ShipperId
            builder.Property(x => x.ShipperId)
                .HasDefaultValue(null);

            //Relations
            builder.HasOne(x => x.Customer)
                .WithMany(x => x.Orders)
                .HasForeignKey(x => x.CustomerId)
                .OnDelete(DeleteBehavior.NoAction)
                .IsRequired();

            builder.HasOne(x => x.Employee)
                .WithMany(x => x.Orders)
                .HasForeignKey(x => x.EmployeeId)
                .OnDelete(DeleteBehavior.NoAction)
                .IsRequired();

            builder.HasOne(x => x.Shipper)
                .WithMany()
                .HasForeignKey(x => x.ShipperId)
                .OnDelete(DeleteBehavior.NoAction)
                .IsRequired();

            builder.HasMany(x => x.OrdersDetails)
                .WithOne(x => x.Order)
                .HasForeignKey(x => x.OrderId)
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();


            builder.Navigation(x => x.Customer);
            builder.Navigation(x => x.Employee);
            builder.Navigation(x => x.Shipper);
            builder.Navigation(x => x.OrdersDetails);
        }
    }
}
