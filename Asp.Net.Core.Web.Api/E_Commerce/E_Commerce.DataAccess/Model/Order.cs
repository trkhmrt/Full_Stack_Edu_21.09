namespace E_Commerce.DataAccess.Model;

public class Order
{
    public int orderId { get; set; }
    
    public int userId { get; set; }
    
    public User User { get; set; }

    public DateTime orderDate { get; set; }

    public int totalAmount { get; set; }

    public int basketId { get; set; }
    public Basket Basket { get; set; }

    public int orderStatusId { get; set; }
    
    public OrderStatus OrderStatus { get; set; }
   
    
    public ICollection<OrderDetail> OrderDetails { get; set; }
    
    
   
   
    
}



