using E_Commerce.Business.Interface;
using Microsoft.AspNetCore.Authorization;
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
        
        [HttpGet("cancelOrderByOrderId/{orderId}")]
        public IActionResult cancelOrderByOrderId(int orderId)
        {
            try
            {
                _orderService.cancelOrderByOrderId(orderId);
                return Ok("Sipariş iptal edildi.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
           
        }
        
        [HttpGet("completeOrderByOrderId/{orderId}")]
        public IActionResult completeOrderByOrderId(int orderId)
        {
            try
            {
                _orderService.completeOrderByOrderId(orderId);
                return Ok("Sipariş iptal edildi.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        
        [HttpGet("toCargoOrderByOrderId/{orderId}")]
        public IActionResult toCargoOrderByOrderId(int orderId)
        {
            try
            {
                _orderService.toCargoOrderByOrderId(orderId);
                return Ok("Sipariş kargoya verildi.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        
        [HttpGet("approveOrderByOrderId/{orderId}")]
        public IActionResult approveOrderByOrderId(int orderId)
        {
            try
            {
                _orderService.approveOrderByOrderId(orderId);
                return Ok("Sipariş onaylandı.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        
        [HttpGet("deliveredOrderByOrderId/{orderId}")]
        public IActionResult deliveredOrderByOrderId(int orderId)
        {
            try
            {
                _orderService.deliveredOrderByOrderId(orderId);
                return Ok("Sipariş Teslim edildi.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        
    }
}
