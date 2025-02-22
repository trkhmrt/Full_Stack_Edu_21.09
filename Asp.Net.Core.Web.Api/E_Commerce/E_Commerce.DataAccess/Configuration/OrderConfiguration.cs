using E_Commerce.DataAccess.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E_Commerce.DataAccess.Configuration;

public class OrderConfiguration:IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.HasKey(o => o.orderId);

        builder.HasOne(o => o.User)
            .WithMany(u => u.orders)
            .HasForeignKey(o => o.userId)
            .OnDelete(DeleteBehavior.Cascade);


    }
}