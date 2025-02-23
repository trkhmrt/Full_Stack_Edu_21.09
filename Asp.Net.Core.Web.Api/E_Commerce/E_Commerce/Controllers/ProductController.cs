using E_Commerce.Business.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        IProductService _productService;


        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("getAllProducts")]
        public IActionResult GetAllProducts()
        {
            return Ok(_productService.GetAllProducts());
        }
        
        
        
    }
}
