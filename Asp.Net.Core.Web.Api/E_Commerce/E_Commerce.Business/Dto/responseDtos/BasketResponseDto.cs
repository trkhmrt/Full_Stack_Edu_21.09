namespace E_Commerce.Business.Dto;

public class BasketResponseDto
{
    public int basketId { get; set; }
    
    public int basketStatusId { get; set; }
    
    public string basketStatusName { get; set; }

    public int basketCustomerId { get; set; }
    
    public string basketUserName { get; set; }
    
    public ICollection<BasketDetailsResponseDto> basketDetails { get; set; }
}