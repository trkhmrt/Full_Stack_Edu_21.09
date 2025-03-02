using E_Commerce.Business.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.Controllers
{
    [Route("[controller]")]
    [ApiController]
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
        
        [HttpGet("getAllOrdersByUserId/{userId}")]
        public IActionResult getAllOrdersByUserId(int userId)
        {
            return Ok(_orderService.getAllOrdersByUserId(userId));
        }

        [HttpGet("getOrderByOrderId/{orderId}")]
        public IActionResult getOrderByOrderId(int orderId)
        {
            return Ok(_orderService.getOrderByOrderId(orderId));
        }
        
        
        
        
    }
}
