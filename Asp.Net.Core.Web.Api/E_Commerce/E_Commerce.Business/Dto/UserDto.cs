namespace E_Commerce.Business.Dto;

public class UserDto
{
    public int userId { get; set; }
    public string userName { get; set; }
    public string email { get; set; }
    public string firstName { get; set; }
    public List<RoleDto> kullaniciRolu { get; set; }
}