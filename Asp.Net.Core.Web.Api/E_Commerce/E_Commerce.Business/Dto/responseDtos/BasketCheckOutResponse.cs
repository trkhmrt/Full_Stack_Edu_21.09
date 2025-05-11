namespace E_Commerce.Business.Dto;

public class BasketCheckOutResponse
{
    public BasketResponseDto basketResponseDto { get; set; }
    public CustomerCheckOutInfo customerCheckOutInfo { get; set; }
}