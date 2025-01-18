using Microsoft_WebSite.DataAccess.Entities;

namespace MicrosoftWebSite.Business.Interfaces;

public interface IOurServiceService
{
    List<Service> getServices();
}