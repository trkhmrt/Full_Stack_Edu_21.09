namespace E_Commerce.DataAccess.Model;

public class Role
{
    public int roleId { get; set; }
    public string roleName { get; set; }
    
    public ICollection<UserRole> userRoles { get; set; }
}


