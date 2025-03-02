using E_Commerce.Business.Dto;
using E_Commerce.DataAccess.Model;

namespace E_Commerce.Business.Interface;

public interface IOrderService
{
    ICollection<OrderResponseDto> getAllOrders();
    
    ICollection<OrderResponseDto> getAllOrdersByUserId(int userId);
    
    OrderResponseDto getOrderByOrderId(int orderId);
    
    
    
}