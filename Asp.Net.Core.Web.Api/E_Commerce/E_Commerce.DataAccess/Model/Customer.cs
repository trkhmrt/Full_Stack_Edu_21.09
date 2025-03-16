namespace E_Commerce.DataAccess.Model;

public class Customer
{
    public int customerId { get; set; }
    public string customerUserName { get; set; }
    
    public string customerPassword { get; set; }
    public string customerFirstName { get; set; }
    public string customerLastName { get; set; }
    public string customerAddress { get; set; }
    public string customerPhoneNumber { get; set; }
    public string customerEmail { get; set; }

    public int roleId { get; set; }
    public Role Role { get; set; }
    
    
    //[JsonIgnore]
    public ICollection<Order> orders { get; set; }
    //[JsonIgnore]
    public ICollection<Basket> baskets { get; set; }
    
    public ICollection<Payment> Payments { get; set; }
}