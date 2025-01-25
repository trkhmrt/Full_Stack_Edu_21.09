using Microsoft_WebSite.DataAccess.Configuration;
using Microsoft_WebSite.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace Microsoft_WebSite.DataAccess;

public class Microsoft_Website_Context:DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //optionsBuilder.UseSqlServer("");
        
        optionsBuilder.UseNpgsql(@"Host=localhost;Database=Microsoft_WebsiteDB;Username=postgres;Password=123456;Search Path=public");
    }
    
    public DbSet<User> Users { get; set; }
    
    public DbSet<AboutUs> AboutUsTable { get; set; }
    
    public DbSet<ContactUs> ContactUsTable { get; set; }

    public DbSet<Package> Packages { get; set; }

    public DbSet<PackageFeature> PackageFeatures { get; set; }
    
    public DbSet<PackageProductUnit> PackageProductUnits { get; set; }
    
    public DbSet<Service> Services { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new PackageFeatureConfiguration());
        modelBuilder.ApplyConfiguration(new PackageProductUnitConfiguration());
        
        modelBuilder.SeedDataCreate();
        
        base.OnModelCreating(modelBuilder);
    }
}