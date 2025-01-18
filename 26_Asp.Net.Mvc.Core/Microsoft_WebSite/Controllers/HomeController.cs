using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft_WebSite.Models;
using MicrosoftWebSite.Business.Interfaces;

namespace Microsoft_WebSite.Controllers;

public class HomeController : Controller
{
  IAboutUsService _aboutUsService;
  public HomeController(IAboutUsService aboutUsService)
  {
    _aboutUsService = aboutUsService;
  }
  
  public IActionResult Index()
  {

    var aboutUs = _aboutUsService.getAboutUs();
    
    
    return View(aboutUs);
  }
  
  
  
  
}