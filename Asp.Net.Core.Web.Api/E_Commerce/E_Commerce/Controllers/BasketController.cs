using E_Commerce.Business.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BasketController : ControllerBase
    {
        IBasketService _basketService;


        public BasketController(IBasketService basketService)
        {
            _basketService = basketService;
        }

        [HttpGet("getAllBaskets")]
        public IActionResult GetAllBaskets()
        {
            return Ok(_basketService.getAllBaskets());
        }

        [HttpGet("getBasketByBasketId/{basketId}")]
        public IActionResult GetBasketByBasketId(int basketId)
        {
            return Ok(_basketService.getBasketByBasketId(basketId));
        }
        
        [HttpGet("getBasketByUserId/{userId}")]
        public IActionResult getBasketByUserId(int userId)
        {
            return Ok(_basketService.getBasketByUserId(userId));
        }
        
        [HttpGet("getBasketByBasketStatusId/{basketStatusId}")]
        public IActionResult getBasketByBasketStatusId(int basketStatusId)
        {
            return Ok(_basketService.getBasketByBasketStatusId(basketStatusId));
        }
        
        
        
        
    }
}
