using Microsoft_WebSite.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Microsoft_WebSite.DataAccess.Configuration;

public class PackageProductUnitConfiguration:IEntityTypeConfiguration<PackageProductUnit>
{
    public void Configure(EntityTypeBuilder<PackageProductUnit> builder)
    {
        builder.HasMany(pu => pu.Packages).WithMany(pu=>pu.PackageProductUnits);
    }
}