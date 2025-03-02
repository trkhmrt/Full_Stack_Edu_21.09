using E_Commerce.DataAccess.Model;

namespace E_Commerce.Business.Dto;

public class OrderDetailsResponseDto
{
    public int  orderProductTotalPrice { get; set; }

    public string userName { get; set; }
    public int  orderProductQuantity { get; set; }
    public string productName { get; set; }

}