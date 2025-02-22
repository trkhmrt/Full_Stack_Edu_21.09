using E_Commerce.DataAccess.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E_Commerce.DataAccess.Configuration;

public class SubCategoryConfiguration:IEntityTypeConfiguration<SubCategory>
{
    public void Configure(EntityTypeBuilder<SubCategory> builder)
    {
        builder.HasKey(sc => sc.subCategoryId);
        
        builder.HasMany(sc=>sc.Products)
            .WithOne(p=>p.SubCategory)
            .HasForeignKey(p=>p.subCategoryId)
            .OnDelete(DeleteBehavior.Cascade);
        
        
    }
}