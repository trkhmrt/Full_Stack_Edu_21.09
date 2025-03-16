using E_Commerce.DataAccess.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E_Commerce.DataAccess.Configuration;

public class OrderConfiguration:IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.HasKey(o => o.orderId);

        builder.HasOne(o => o.Customer)
            .WithMany(u => u.orders)
            .HasForeignKey(o => o.customerId)
            .OnDelete(DeleteBehavior.Restrict);
        
        builder.HasOne(o=>o.Basket)
            .WithOne(b=>b.Order)
            .HasForeignKey<Order>(o=>o.basketId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(o => o.OrderStatus)
            .WithMany(o=>o.orders)
            .HasForeignKey(o => o.orderStatusId)
            .OnDelete(DeleteBehavior.Restrict);

    }
}