using Microsoft_WebSite.DataAccess.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using MicrosoftWebSite.Business.Interfaces;

namespace Microsoft_WebSite.Areas.Admin.Controllers;

[Authorize(Roles = "Admin")]
[Area("Admin")]
public class AboutUsController : Controller
{
    private IAboutUsService _aboutUsService;
    
    
    public AboutUsController(IAboutUsService aboutUsService)
    {
        _aboutUsService = aboutUsService;
    }

    
    public IActionResult Index()
    {
        var aboutUsData = _aboutUsService.getAboutUs();
        
        return View(aboutUsData);
    }


    [HttpPost]
    public IActionResult updateAboutUs(AboutUs aboutUs)
    {
        
        if (_aboutUsService.updateAboutus(aboutUs))
        {
            return RedirectToAction("Index");
        }

        return BadRequest();
    }
    
}