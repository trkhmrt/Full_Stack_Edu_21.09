using Microsoft_WebSite.DataAccess;
using Microsoft_WebSite.DataAccess.Entities;
using MicrosoftWebSite.Business.Interfaces;

namespace MicrosoftWebSite.Business.Services;

public class OurServiceService : IOurServiceService
{
    private Microsoft_Website_Context _context;
    
    public OurServiceService(Microsoft_Website_Context microsoftWebsiteContext)
    {
        _context = microsoftWebsiteContext;
    }


    public Service getServiceById(int serviceId)
    {
        return _context.Services.FirstOrDefault(s => s.ServiceId == serviceId);
    }

    public List<Service> getServices()
    {
        return _context.Services.OrderBy(o=>o.ServiceId).ToList();
    }

    public void updateService(Service service)
    {
        _context.Services.Update(service);
        _context.SaveChanges();
    }
}