using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft_WebSite.Models;

namespace Microsoft_WebSite.Controllers;

public class HomeController : Controller
{
  
  
  public IActionResult Index()
  {
    return View();
  }
  
  
  
}