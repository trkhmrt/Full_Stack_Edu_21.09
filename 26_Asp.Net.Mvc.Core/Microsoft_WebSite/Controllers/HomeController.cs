using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft_WebSite.Models;
using MicrosoftWebSite.Business.Dtos;
using MicrosoftWebSite.Business.Interfaces;

namespace Microsoft_WebSite.Controllers;

public class HomeController : Controller
{
  IHomeService _homeService;
  public HomeController(IHomeService homeService)
  {
    _homeService = homeService;
  }
  
  public IActionResult Index()
  {

    HomeDto homeData = _homeService.getHomeInfo();
      
    
    return View(homeData);
  }
  
  public IActionResult Error(int code)
  {
    ViewBag.Code = code;
    ViewBag.Message = "404 Hatası alınmıştır.Aradığınız sayfa bulunamadı.";
    return View();
  }


  
  
}