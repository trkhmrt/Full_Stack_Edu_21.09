using System.Text.Json.Serialization;

namespace E_Commerce.DataAccess.Model;

public class UserRole
{

    //[JsonIgnore]
    public int userId { get; set; }
    //[JsonIgnore]
    public User User { get; set; }

    //[JsonIgnore]
    public int roleId { get; set; }
    public Role Role { get; set; }
    
}