namespace E_Commerce.Business.Dto.requestDtos;

public class AddProductToBasketRequestDto
{
    public int productId { get; set; }
    public int userId { get; set; }

    public int quantity { get; set; }
}