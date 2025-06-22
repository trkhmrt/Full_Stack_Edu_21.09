namespace E_Commerce.DataAccess.Model;

public class ProductImage
{
    public int productImageId { get; set; }
    public string productImageUrl { get; set; }
    public int productId  { get; set; }
    public Product Product { get; set; }
    
}