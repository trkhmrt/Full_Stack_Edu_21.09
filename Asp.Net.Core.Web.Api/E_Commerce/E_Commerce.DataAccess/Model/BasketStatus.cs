namespace E_Commerce.DataAccess.Model;

public class BasketStatus
{
    public int basketStatusId { get; set; }
    
    public string basketStatusName { get; set; }

    public ICollection<Basket> baskets  { get; set; }
    
   
 
}