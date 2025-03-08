using E_Commerce.Business.Dto;
using E_Commerce.Business.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        IPaymentService _paymentService;


        public PaymentController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        [HttpGet("createPayment/{basketId}")]
        public IActionResult createPayment(int basketId)
        {
            PaymentResponseDto responseDto = _paymentService.createPayment(basketId);
            return Ok(responseDto);
        }
        
        
        
        
    }
}
