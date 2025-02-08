using Microsoft_WebSite.DataAccess.Entities;

namespace MicrosoftWebSite.Business.Interfaces;

public interface IPricingService
{
    List<PackageProductUnit> getAllPackageProductUnits(string productTitle);
    
    void updatePackageProductUnit(PackageProductUnit packageProductUnit);
    
}