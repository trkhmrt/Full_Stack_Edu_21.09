namespace E_Commerce.DataAccess.Model;

public class OrderDetail
{
    public int orderDetailId { get; set; }
    
    public int productId { get; set; }
    
    public Product Product { get; set; }
    public int orderId { get; set; }
    public Order Order { get; set; }
    
    public int order_product_quantity { get; set; }
    
    public int order_product_totalPrice { get; set; }
    
    
    
    
}

