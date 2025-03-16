namespace E_Commerce.Business.Dto.requestDtos;

public class AddProductToBasketRequestDto
{
    public int productId { get; set; }
    public int customerId { get; set; }

    public int quantity { get; set; }
}