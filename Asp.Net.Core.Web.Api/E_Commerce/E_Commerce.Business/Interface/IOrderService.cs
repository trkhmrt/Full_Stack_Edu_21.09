using E_Commerce.Business.Dto;
using E_Commerce.DataAccess.Model;

namespace E_Commerce.Business.Interface;

public interface IOrderService
{
    ICollection<OrderResponseDto> getAllOrders();
    
    ICollection<OrderResponseDto> getAllOrdersByCustomerId(int customerId);
    
    OrderResponseDto getOrderByOrderId(int orderId);
    
    
    
}