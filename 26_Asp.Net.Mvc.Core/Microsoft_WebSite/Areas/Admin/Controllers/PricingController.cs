using Microsoft.AspNetCore.Mvc;

namespace Microsoft_WebSite.Areas.Admin.Controllers;

public class PricingController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}