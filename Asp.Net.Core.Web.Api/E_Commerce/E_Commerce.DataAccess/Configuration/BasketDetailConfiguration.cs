using E_Commerce.DataAccess.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E_Commerce.DataAccess.Configuration;

public class BasketDetailConfiguration:IEntityTypeConfiguration<BasketDetail>
{
    public void Configure(EntityTypeBuilder<BasketDetail> builder)
    {
        builder.HasKey(bd => bd.basketDetailId);

        builder.HasOne(bd => bd.Basket)
            .WithMany(p => p.BasketDetails)
            .HasForeignKey(bd => bd.basketId)
            .OnDelete(DeleteBehavior.Cascade);
        
        builder.HasOne(bd => bd.Product)
            .WithMany(p => p.BasketDetails)
            .HasForeignKey(bd => bd.productId)
            .OnDelete(DeleteBehavior.Cascade);
        
        


    }
}