using E_Commerce.DataAccess.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E_Commerce.DataAccess.Configuration;

public class CategoryConfiguration :IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.HasKey(c => c.categoryId);
        
        builder.HasMany(c=>c.subCategories)
            .WithOne(sc=>sc.Category)
            .HasForeignKey(sc=>sc.categoryId)
            .OnDelete(DeleteBehavior.Cascade);
        
        
        
    }
}