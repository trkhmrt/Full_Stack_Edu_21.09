using E_Commerce.DataAccess.Model;

namespace E_Commerce.Business.Dto;

public class OrderResponseDto
{
    public int orderId { get; set; }
    public string userName { get; set; }
    public DateTime orderDate { get; set; }
    public int totalAmount { get; set; }
    public string orderStatusName { get; set; }
    
    public ICollection<OrderDetailsResponseDto> orderDetails { get; set; }
    
}