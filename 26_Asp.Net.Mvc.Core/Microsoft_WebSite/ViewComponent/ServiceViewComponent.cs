using Microsoft.AspNetCore.Mvc;
using MicrosoftWebSite.Business.Interfaces;

namespace Microsoft_WebSite.ViewComponent;

public class ServiceViewComponent:Microsoft.AspNetCore.Mvc.ViewComponent
{
    private IOurServiceService _ourServiceService;
    
    public ServiceViewComponent(IOurServiceService ourServiceService)
    {
        _ourServiceService = ourServiceService;
    }
    
    
    public async Task<IViewComponentResult> InvokeAsync()
    {
        var services = _ourServiceService.getServices();
        return View(services);
    }
}