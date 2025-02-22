namespace E_Commerce.DataAccess.Model;

public class Basket
{
    public int basketId { get; set; }
    public int userId { get; set; }
    
    public ICollection<BasketDetail> BasketDetails { get; set; }
}