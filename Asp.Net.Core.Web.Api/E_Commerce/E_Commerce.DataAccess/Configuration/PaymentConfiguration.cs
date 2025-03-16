using E_Commerce.DataAccess.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E_Commerce.DataAccess.Configuration;

public class PaymentConfiguration:IEntityTypeConfiguration<Payment>
{
    public void Configure(EntityTypeBuilder<Payment> builder)
    {
        builder.HasKey(payment => payment.paymentId);

        builder.HasOne(p => p.Basket)
            .WithMany(b => b.Payments)
            .HasForeignKey(p => p.basketId)
            .OnDelete(DeleteBehavior.Restrict);
        
        builder.HasOne(p => p.PaymentStatus)
            .WithMany(p => p.Payments)
            .HasForeignKey(p => p.paymentStatusId)
            .OnDelete(DeleteBehavior.Restrict);
        
        builder.HasOne(p => p.Customer)
            .WithMany(p => p.Payments)
            .HasForeignKey(p => p.customerId)
            .OnDelete(DeleteBehavior.Restrict);
        
    }
}