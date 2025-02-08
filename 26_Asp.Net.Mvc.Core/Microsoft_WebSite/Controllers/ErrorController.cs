using Microsoft.AspNetCore.Mvc;

namespace Microsoft_WebSite.Controllers;

public class ErrorController : Controller
{
    [Route("{statusCode}")]
    public IActionResult ErrorPages(int statusCode)
    {
        
        return View();
    }
}