using Microsoft_WebSite.DataAccess.Entities;

namespace MicrosoftWebSite.Business.Interfaces;

public interface IOurServiceService
{
    Service getServiceById(int serviceId);
    List<Service> getServices();
    
    void updateService(Service service);
}