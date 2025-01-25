using Microsoft_WebSite.DataAccess;
using Microsoft_WebSite.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using MicrosoftWebSite.Business.Dtos;
using MicrosoftWebSite.Business.Interfaces;

namespace MicrosoftWebSite.Business.Services;

public class HomeService : IHomeService
{
    private Microsoft_Website_Context _microsoftWebsiteContext;


    public HomeService(Microsoft_Website_Context microsoftWebsiteContext)
    {
        _microsoftWebsiteContext = microsoftWebsiteContext;
    }


    public HomeDto getHomeInfo()
    {
        HomeDto homeDto = new HomeDto();
        
        var PackageData = _microsoftWebsiteContext.Packages.Include(p=>p.PackageProductUnits).Include(pf=>pf.PackageFeatures).ToList();

        var aboutUsData = _microsoftWebsiteContext.AboutUsTable.FirstOrDefault();
        
        var packageFeatures = _microsoftWebsiteContext.PackageFeatures.Include(p=>p.Packages).ToList();
        
        
        
        
        
        
        homeDto.Package = PackageData;
        homeDto.aboutUs = aboutUsData;
        homeDto.PackageFeature = packageFeatures;
       
            
        
        
        
    
        
        return homeDto;
    }
}