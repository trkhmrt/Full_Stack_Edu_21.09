using E_Commerce.DataAccess.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E_Commerce.DataAccess.Configuration;

public class ProductConfiguration:IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasKey(product => product.productId);

        builder.HasMany(p => p.ProductImages)
            .WithOne(b => b.Product)
            .HasForeignKey(p => p.productId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}