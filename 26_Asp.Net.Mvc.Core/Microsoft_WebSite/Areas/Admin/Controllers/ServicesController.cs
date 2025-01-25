using Microsoft.AspNetCore.Mvc;

namespace Microsoft_WebSite.Areas.Admin.Controllers;

[Area("Admin")]
public class ServicesController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}