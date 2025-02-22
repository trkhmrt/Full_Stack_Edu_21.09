using E_Commerce.DataAccess.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E_Commerce.DataAccess.Configuration;

public class OrderDetailConfiguration:IEntityTypeConfiguration<OrderDetail>
{
    public void Configure(EntityTypeBuilder<OrderDetail> builder)
    {
        builder.HasKey(od => od.orderDetailId);
        
        builder.HasOne(od => od.Order)
            .WithMany(od => od.OrderDetails)
            .HasForeignKey(od => od.orderId);
        
        builder.HasOne(od => od.Product)
            .WithMany(p => p.OrderDetails)
            .HasForeignKey(od => od.productId)
            .OnDelete(DeleteBehavior.Cascade);
        
        
        
        
    }
}