using Microsoft_WebSite.DataAccess.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MicrosoftWebSite.Business.Interfaces;

namespace Microsoft_WebSite.Areas.Admin.Controllers;

[Authorize(Roles = "Admin")]
[Area("Admin")]
public class PricingController : Controller
{
    IPricingService _pricingService;


    public PricingController(IPricingService pricingService)
    {
        _pricingService = pricingService;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public IActionResult PricingDetails(string productTitle)
    {
        var route_Value = HttpContext.Request.RouteValues;
        ViewBag.PackageProductUnitTitle = productTitle;
        ViewBag.AreaName = route_Value["area"].ToString();
        ViewBag.ControllerName = route_Value["controller"].ToString();
        ViewBag.ActionName = route_Value["action"].ToString();
        
       
        
        var product_units = _pricingService.getAllPackageProductUnits(productTitle);

        return View(product_units);
    }

    [HttpPost]
    public IActionResult PrcingDetailsUpdate(PackageProductUnit packageProductUnit)
    {
      
       
        
        _pricingService.updatePackageProductUnit(packageProductUnit);
        
        return RedirectToAction("PricingDetails", new { productTitle = packageProductUnit.PackageProductUnitTitle });
        
        
    }
    
}