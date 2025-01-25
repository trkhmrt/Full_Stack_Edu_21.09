namespace Microsoft_WebSite.DataAccess.Entities;

public class PackageProductUnit
{
    public int PackageProductUnitID { get; set; }

    public string PackageProductUnitTitle { get; set; }
    
    public string PackageProductUnitContent { get; set; }
    
    public string PackageProductUnitPrice { get; set; }
    
    public virtual List<Package> Packages { get; set; }
    
    
    
}