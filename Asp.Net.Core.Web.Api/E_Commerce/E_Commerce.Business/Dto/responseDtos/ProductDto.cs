namespace E_Commerce.Business.Dto;

public class ProductDto
{
    public int productId { get; set; }
    public string productName { get; set; }
    public string productDescription { get; set; }
    public int subcategoryId { get; set; }
    public string subcategoryName { get; set; }
    public int categoryId { get; set; }
    public string categoryName { get; set; }
    public int productUnitPrice { get; set; }
    
    public bool isProductActive { get; set; }
}