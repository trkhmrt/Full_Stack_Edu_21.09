using Microsoft_WebSite.DataAccess.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Microsoft_WebSite.Areas.Admin.Controllers;


[Authorize(Roles = "Admin")]
[Area("Admin")]
public class DashboardController : Controller
{
    // GET
    public IActionResult Index()
    {
      
        return View();
    }
}