using Microsoft_WebSite.DataAccess.Entities;

namespace MicrosoftWebSite.Business.Interfaces;

public interface IAboutUsService
{
    AboutUs getAboutUs();
    
    bool updateAboutus(AboutUs aboutUs);
}