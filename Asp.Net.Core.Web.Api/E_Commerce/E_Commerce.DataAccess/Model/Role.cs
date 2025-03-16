using System.Text.Json.Serialization;

namespace E_Commerce.DataAccess.Model;

public class Role
{
    public int roleId { get; set; }
    public string roleName { get; set; }
    
    //[JsonIgnore]
    public  ICollection<UserRole> UserRoles { get; set; }

    public ICollection<Customer> Customers { get; set; }
    
}


