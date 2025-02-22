using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace E_Commerce.DataAccess.Model;

public class BasketDetail
{
    public int basketDetailId { get; set; }
    
    public int basketId { get; set; }
    public Basket Basket { get; set; }
    
    public int productId { get; set; }
    public Product Product { get; set; }
    
    public int basket_quantity { get; set; }
    
    
    
}

