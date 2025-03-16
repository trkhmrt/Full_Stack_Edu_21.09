using E_Commerce.Business.Dto.requestDtos;
using E_Commerce.Business.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        
        [HttpPost]
        [Route("createCustomer")]
        public IActionResult createCustomer(CreateCustomerRequest request)
        {
            try
            {
                return Ok(_customerService.createCustomer(request));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }
        
        
        
        
        
    }
}
