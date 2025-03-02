namespace E_Commerce.DataAccess.Model;

public class Basket
{
    public int basketId { get; set; }
    
    public int userId { get; set; }
    
    public User User { get; set; }

    public int basketStatusId { get; set; }
    
    public BasketStatus BasketStatus { get; set; }
    
    public Order Order { get; set; }
    public ICollection<BasketDetail> BasketDetails { get; set; }
    public ICollection<Payment> Payments { get; set; }
    
    
    
    
}