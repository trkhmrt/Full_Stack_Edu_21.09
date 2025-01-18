namespace Microsoft_WebSite.DataAccess.Entities;

public class PackageFeature
{
    public int PackageFeatureID { get; set; }
    
    public string PackageFeatureTitle { get; set; }
    
    public List<Package> Packages { get; set; }
    
}