using Microsoft.AspNetCore.Mvc;
using MicrosoftWebSite.Business.Interfaces;

namespace Microsoft_WebSite.Controllers;

public class ContactController : Controller
{
    IAboutUsService _aboutUsService;

    public ContactController(IAboutUsService aboutUsService)
    {
        _aboutUsService = aboutUsService;
    }
    
    // GET
    public IActionResult Index()
    {
        var aboutUs = _aboutUsService.getAboutUs();
        
        return View();
    }
}