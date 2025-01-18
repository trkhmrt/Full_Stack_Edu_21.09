using Microsoft_WebSite.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Microsoft_WebSite.DataAccess.Configuration;

public class PackageFeatureConfiguration:IEntityTypeConfiguration<PackageFeature>
{
    public void Configure(EntityTypeBuilder<PackageFeature> builder)
    {
        builder.HasMany(p=>p.Packages).WithMany(p=>p.PackageFeatures);
        
    }
}