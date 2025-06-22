namespace E_Commerce.Business.Dto.requestDtos;

public class CheckoutRequest
{
    public int customerId { get; set; }
    public int basketId { get; set; }
    public int amount { get; set; }
}