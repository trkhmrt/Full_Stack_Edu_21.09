using E_Commerce.Business.Dto.requestDtos;
using E_Commerce.Business.Interface;
using Microsoft.AspNetCore.Authorization;
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
        
        [HttpGet("getBasketByCustomerId/{customerId}")]
        public IActionResult getBasketByCustomerId(int customerId)
        {
            return Ok(_basketService.getBasketByCustomerId(customerId));
        }
        
        [HttpGet("getActiveBasketByCustomerId/{customerId}")]
        public IActionResult getActiveBasketByCustomerId(int customerId)
        {
            return Ok(_basketService.getActiveBasketByCustomerId(customerId));
        }
        
        [HttpGet("getBasketByBasketStatusId/{basketStatusId}")]
        public IActionResult getBasketByBasketStatusId(int basketStatusId)
        {
            return Ok(_basketService.getBasketByBasketStatusId(basketStatusId));
        }
        
        
        [HttpGet("approveBasket/{basketId}")]
        public IActionResult approveBasket(int basketId)
        {
            _basketService.approveBasket(basketId);
            return Ok("Basket approved");
        }
        
        [HttpGet("continueShopping/{basketId}")]
        public IActionResult continueShopping(int basketId)
        {
            _basketService.continueShopping(basketId);
            return Ok("You can continue to shopping");
        }

        [HttpPost("addProductToBasket")]
        public IActionResult addProductToBasket(AddProductToBasketRequestDto addProductToBasketRequestDto)
        {
            
            return Ok(_basketService.addProductToBasket(addProductToBasketRequestDto));
        }
        
        [HttpPost("removeBasket")]
        public IActionResult removeBasket(RemoveProductToBasketDto removeProductToBasketDto)
        {
            
            return Ok(_basketService.removeProductToBasket(removeProductToBasketDto));
        }
        
        
        
    }
}
