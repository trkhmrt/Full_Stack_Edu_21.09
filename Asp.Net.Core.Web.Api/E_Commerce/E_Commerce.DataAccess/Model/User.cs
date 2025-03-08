using System.Text.Json.Serialization;

namespace E_Commerce.DataAccess.Model;

public class User
{
    public int userId { get; set; }
    public string userName { get; set; }
    public string password { get; set; }
    public string email { get; set; }
    public string firstName { get; set; }
    
    public  ICollection<UserRole> UserRoles { get; set; }

    //[JsonIgnore]
    public ICollection<Order> orders { get; set; }
    //[JsonIgnore]
    public ICollection<Basket> baskets { get; set; }
    
    public ICollection<Payment> Payments { get; set; }
    
}