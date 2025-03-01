using E_Commerce.Business.Dto.requestDtos;
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
        
        [HttpGet("getProductDetails/{productId}")]
        public IActionResult GetProductById(int productId)
        {
            return Ok(_productService.GetProductById(productId));
        }
        
        [HttpPost("createNewProduct")]
        public IActionResult createNewProduct(createNewProductDto newProduct)
        {
            
            if (_productService.createNewProduct(newProduct))
            {
                return Ok("Product created");
            }
            else
            {
                return BadRequest("Product not created");
            }
            
        }

        
        
    }
}
