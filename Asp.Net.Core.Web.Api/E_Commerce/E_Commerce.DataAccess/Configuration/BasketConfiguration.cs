using E_Commerce.DataAccess.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E_Commerce.DataAccess.Configuration;

public class BasketConfiguration:IEntityTypeConfiguration<Basket>
{
    public void Configure(EntityTypeBuilder<Basket> builder)
    {
        builder.HasKey(b => b.basketId);

        builder.HasOne(b => b.User)
            .WithMany(u => u.baskets)
            .HasForeignKey(u => u.userId)
            .OnDelete(DeleteBehavior.Restrict);
        
        
    }
}