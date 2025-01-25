using Microsoft_WebSite.DataAccess;
using Microsoft_WebSite.DataAccess.Entities;
using MicrosoftWebSite.Business.Interfaces;

namespace MicrosoftWebSite.Business.Services;

public class AboutUsService : IAboutUsService
{
    private Microsoft_Website_Context _context;

    public AboutUsService(Microsoft_Website_Context microsoftWebsiteContext)
    {
        _context = microsoftWebsiteContext;
    }
    
    public AboutUs getAboutUs()
    {
        return _context.AboutUsTable.FirstOrDefault();
    }

    public bool updateAboutus(AboutUs aboutUs)
    {
        if (aboutUs != null)
        {
            _context.AboutUsTable.Update(aboutUs);
            _context.SaveChanges();
            return true;
        }

        return false;
    }
}