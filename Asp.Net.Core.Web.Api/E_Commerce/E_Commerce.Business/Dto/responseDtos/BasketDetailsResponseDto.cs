namespace E_Commerce.Business.Dto;

public class BasketDetailsResponseDto
{
    public int basketDetailId { get; set; }
    public int basketQuantity { get; set; }
    public string productName { get; set; }
    public string productDescription { get; set; }
    public string subCategoryName { get; set; }

    public int productId { get; set; }
    public int productPrice { get; set; }
    
}