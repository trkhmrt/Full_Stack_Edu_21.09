using Microsoft_WebSite.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace Microsoft_WebSite.DataAccess;

public static class SeedDataCreator
{

    public static void SeedDataCreate(this ModelBuilder modelBuilder)
    {
        #region User

        modelBuilder.Entity<User>().HasData(
            new User
            {
                UserID = 1,
                UserUsername = "trkhamarat",
                UserEmail = "trkhamarat@gmail.com",
                UserPassword = "123456",
                userRole = "Admin"
            }
        );


        #endregion
        #region Package

        modelBuilder.Entity<Package>().HasData(
            new Package
            {
               PackageID = 1,
               PackageTitle = "Free",
               PackageContent = "Free Plan",
            
               
            },
            new Package
            {
               PackageID = 2,
               PackageTitle = "Pro",
              PackageContent = "Pro Plan",
    
            },
            new Package
            {
                PackageID = 3,
                PackageTitle = "Enterprise",
                PackageContent = "Enterprise Plan"
            }
        );


        #endregion
        #region PackageFeature

        modelBuilder.Entity<PackageFeature>().HasData(new PackageFeature
            {
                PackageFeatureID = 1,
                PackageFeatureTitle = "Public",
            },
            new PackageFeature
            {
                PackageFeatureID = 2,
                PackageFeatureTitle = "Private",
            },
            new PackageFeature
            {
                PackageFeatureID = 3,
                PackageFeatureTitle = "Permissions",
            },
            new PackageFeature
            {
                PackageFeatureID = 4,
                PackageFeatureTitle = "Sharing",
            },
            new PackageFeature
            {
                PackageFeatureID = 5,
                PackageFeatureTitle = "Unlimited members",
            },
            new PackageFeature
            {
                PackageFeatureID = 6,
                PackageFeatureTitle = "Extra security",
            }
            
            

        );

        #endregion
        #region PackageProductUnit

        modelBuilder.Entity<PackageProductUnit>().HasData(
            new PackageProductUnit
            {
                PackageProductUnitID = 1,
                PackageProductUnitTitle = "users included",
                PackageProductUnitContent = "10 users included",
                PackageProductUnitPrice = "100",
            },
            new PackageProductUnit
            {
                PackageProductUnitID = 2,
                PackageProductUnitTitle = "GB of storage",
                PackageProductUnitContent = "2 GB of storage",
                PackageProductUnitPrice = "10"
            }
        );

        #endregion
        
    }
}