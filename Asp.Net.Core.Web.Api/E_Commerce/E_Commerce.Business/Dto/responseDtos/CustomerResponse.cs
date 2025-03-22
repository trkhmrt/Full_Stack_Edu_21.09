namespace E_Commerce.Business.Dto;

public class CustomerResponse
{
    public int customerId { get; set; }
    public string customerUserName { get; set; }
    public string customerMail { get; set; }
    public string customerFirstname { get; set; }
    public CustomerRoleDto customerRolu { get; set; }
}