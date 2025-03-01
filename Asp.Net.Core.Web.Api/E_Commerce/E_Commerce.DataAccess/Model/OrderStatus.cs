namespace E_Commerce.DataAccess.Model;

public class OrderStatus
{
    public int orderStatusId { get; set; }
    
    public string orderStatusName { get; set; }

    public ICollection<Order> orders { get; set; }
}