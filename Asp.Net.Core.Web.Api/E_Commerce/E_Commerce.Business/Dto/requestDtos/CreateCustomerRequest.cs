using System.ComponentModel.DataAnnotations;
using Microsoft.SqlServer.Server;

namespace E_Commerce.Business.Dto.requestDtos;

public class CreateCustomerRequest
{
    [Required(ErrorMessage = "First Name is required")]
    public string customerUserName { get; set; }
    
    [Required(ErrorMessage = "Password is required")] 
    [MaxLength(20, ErrorMessage = "Password length cannot be longer than 20 characters")]
    [MinLength(6, ErrorMessage = "Password length cannot be smaller than 6 characters")]
    [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&.])[A-Za-z\d@$!%*?&.]{6,20}$",
        ErrorMessage = "Password must be 6-20 characters long, include at least one uppercase letter, one lowercase letter, one number, and one special character.")]
    public string customerPassword { get; set; }
    
    [Required(ErrorMessage = "Password is required")]
    [Compare("customerPassword",ErrorMessage = "Şifreler aynı değil.")]
    public string confirmCustomerPassword { get; set; }
    public string customerFirstName { get; set; }
    public string customerLastName { get; set; }
    public string customerAddress { get; set; }
    
    public string customerPhoneNumber { get; set; }
    [Required(ErrorMessage = "Email is required")]
    [EmailAddress(ErrorMessage = "Invalid Email Address")]
    public string customerEmail { get; set; }
}