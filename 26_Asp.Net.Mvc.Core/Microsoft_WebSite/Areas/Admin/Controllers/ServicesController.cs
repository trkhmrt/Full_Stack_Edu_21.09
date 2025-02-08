using Microsoft_WebSite.DataAccess.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MicrosoftWebSite.Business.Interfaces;


namespace Microsoft_WebSite.Areas.Admin.Controllers;

[Authorize(Roles = "Admin")]
[Area("Admin")]
public class ServicesController : Controller
{
    
    IOurServiceService _services;
    
    public ServicesController(IOurServiceService services)
    {
        _services = services;
    }

    public IActionResult Index()
    {
        var services = _services.getServices();
        return View(services);
    }
    
    [HttpGet]
    public IActionResult ServiceDetail(int id)
    {
        var service = _services.getServiceById(id);
        return View(service);
    }
    
    [HttpPost]
    public IActionResult ServiceDetailUpdate(Service service)
    {
        _services.updateService(service);
        return RedirectToAction("Index");
    
    }
}