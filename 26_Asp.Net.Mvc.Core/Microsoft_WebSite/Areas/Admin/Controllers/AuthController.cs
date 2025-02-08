using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MicrosoftWebSite.Business.Dtos;
using MicrosoftWebSite.Business.Interfaces;

namespace Microsoft_WebSite.Areas.Admin.Controllers;


[Area("Admin")]
public class AuthController : Controller
{
    IAuthService _authService;

    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }

    public IActionResult SignIn(LoginDto loginDto)
    {
        if (Request.Method == "GET")
        {
            return View();
        }
        else
        {
            if (loginDto != null)
            {
                var founded_user = _authService.SignIn(loginDto);
                
                if (founded_user != null)
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name,loginDto.userName),
                        new Claim(ClaimTypes.Role,founded_user.userRole)
                    };
                    
                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                    var authProp = new AuthenticationProperties
                    {
                         IsPersistent = true,
                         ExpiresUtc = DateTime.UtcNow.AddMinutes(1),
                    };

                    HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), authProp);

                    HttpContext.Session.SetString("userName", founded_user.UserUsername);
                  

                    return RedirectToAction("Index", "Dashboard");
                }
                
                
                
                
                
            }
        }

        return null;
    }
    
    public IActionResult SignOut()
    {
        return null;
    }
    
    public IActionResult SignUp()
    {
        return View();
    }

    public IActionResult AccessDenied()
    {
        return View();
    }
    
}