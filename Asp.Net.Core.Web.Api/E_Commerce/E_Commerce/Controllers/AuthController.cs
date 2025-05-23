using E_Commerce.Business.Dto.requestDtos;
using E_Commerce.Business.Interface;
using E_Commerce.DataAccess.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BadHttpRequestException = Microsoft.AspNetCore.Http.BadHttpRequestException;

namespace E_Commerce.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        IJwtGenerator _jwtGenerator;
        IAuthService _authService;
        
        public AuthController(IJwtGenerator jwtGenerator,IAuthService authService)
        {
            _authService = authService;
            _jwtGenerator = jwtGenerator;
        }
        
        
        [HttpPost("login")]
        public IActionResult Login(AuthLoginRequest authLoginRequest)
        { 
            try
            {
                var responseLogin = _authService.login(authLoginRequest);
                return Ok(responseLogin);
                
            }
            catch (Exception e)
            {
               return BadRequest(e.Message);
            }
        }
        
        [HttpPost("customerLogin")]
        public IActionResult customerLogin(AuthLoginRequest authLoginRequest)
        {
            try
            {
                var responseLogin = _authService.customerLogin(authLoginRequest);
                return Ok(responseLogin);

            }
            catch (UnauthorizedAccessException e)
            {
                return Unauthorized(e.Message);
            }
            catch (BadHttpRequestException e)
            {
                return BadRequest(e.Message);
            }
            
        }
        
        
    }
}
