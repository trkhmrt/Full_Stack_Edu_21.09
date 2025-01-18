using Microsoft_WebSite.DataAccess;
using Microsoft_WebSite.DataAccess.Entities;
using MicrosoftWebSite.Business.Interfaces;

namespace MicrosoftWebSite.Business.Services;

public class AboutUsService : IAboutUsService
{
    private Microsoft_Website_Context _microsoftWebsiteContext;

    public AboutUsService(Microsoft_Website_Context microsoftWebsiteContext)
    {
        _microsoftWebsiteContext = microsoftWebsiteContext;
    }
    
    public AboutUs getAboutUs()
    {
        return _microsoftWebsiteContext.AboutUsTable.FirstOrDefault();
    }
    
    
}