namespace E_Commerce.DataAccess.Model;

public class Product
{
    public int productId { get; set; }
    
    public string productName { get; set; }
    
    public string productDescription { get; set; }
    
    public int productUnitPrice { get; set; }

    public bool isProductActive { get; set; }
    public int subCategoryId { get; set; }
    
    public SubCategory SubCategory { get; set; }

    public ICollection<OrderDetail> OrderDetails { get; set; }
    public ICollection<BasketDetail> BasketDetails { get; set; }
}