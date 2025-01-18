using Microsoft_WebSite.DataAccess;
using Microsoft_WebSite.DataAccess.Entities;
using MicrosoftWebSite.Business.Interfaces;

namespace MicrosoftWebSite.Business.Services;

public class OurServiceService : IOurServiceService
{
    private Microsoft_Website_Context _microsoftWebsiteContext;
    
    public OurServiceService(Microsoft_Website_Context microsoftWebsiteContext)
    {
        _microsoftWebsiteContext = microsoftWebsiteContext;
    }
    
    
    public List<Service> getServices()
    {
        return _microsoftWebsiteContext.Services.ToList();
    }
}