using Microsoft_WebSite.DataAccess.Entities;

namespace MicrosoftWebSite.Business.Dtos;

public class HomeDto
{
    public List<Package> Package { get; set; }
    public List<PackageFeature> PackageFeature { get; set; }
    public List<PackageProductUnit> PackageProductUnit { get; set; }
    
    public AboutUs aboutUs { get; set; }
}