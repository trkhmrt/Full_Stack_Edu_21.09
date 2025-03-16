using E_Commerce.Business.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [Authorize(Roles = "Admin,IT")]
    public class OrderController : ControllerBase
    {
        private IOrderService _orderService;


        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet("getAllOrders")]
        public IActionResult GetAllOrders()
        {
            return Ok(_orderService.getAllOrders());
        }
        
        [AllowAnonymous]
        [HttpGet("getAllOrdersByCustomerId/{customerId}")]
        public IActionResult getAllOrdersByCustomerId(int customerId)
        {
            return Ok(_orderService.getAllOrdersByCustomerId(customerId));
        }

        [HttpGet("getOrderByOrderId/{orderId}")]
        public IActionResult getOrderByOrderId(int orderId)
        {
            return Ok(_orderService.getOrderByOrderId(orderId));
        }
        
        
        
        
    }
}
