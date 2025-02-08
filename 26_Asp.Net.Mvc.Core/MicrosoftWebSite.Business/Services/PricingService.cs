using Microsoft_WebSite.DataAccess;
using Microsoft_WebSite.DataAccess.Entities;
using MicrosoftWebSite.Business.Interfaces;

namespace MicrosoftWebSite.Business.Services;

public class PricingService:IPricingService
{
    Microsoft_Website_Context _context;

    public PricingService(Microsoft_Website_Context context)
    {
        _context = context;
    }
        
    
    public List<PackageProductUnit> getAllPackageProductUnits(string productTitle)
    {
        return _context.PackageProductUnits.Where(pu=>pu.PackageProductUnitTitle.Contains(productTitle)).OrderBy(p=>p.PackageProductUnitID).ToList();
        
    }

    public void updatePackageProductUnit(PackageProductUnit packageProductUnit)
    {
        _context.PackageProductUnits.Update(packageProductUnit);
        _context.SaveChanges();
    }
}