using Microsoft.AspNetCore.Mvc;

namespace Microsoft_WebSite.Controllers;

public class ContactController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}