namespace Microsoft_WebSite.DataAccess.Entities;

public class Package
{
    public int PackageID { get; set; }

    public string PackageTitle { get; set; }
    
    public string PackageContent { get; set; }

    public List<PackageProductUnit> PackageProductUnits { get; set; }
    
    public List<PackageFeature> PackageFeatures { get; set; }
    
    
}