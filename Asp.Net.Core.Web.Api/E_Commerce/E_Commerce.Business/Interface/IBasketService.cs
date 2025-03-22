using E_Commerce.Business.Dto;
using E_Commerce.Business.Dto.requestDtos;
using E_Commerce.DataAccess.Model;

namespace E_Commerce.Business.Interface;

public interface IBasketService
{
    BasketResponseDto addProductToBasket(AddProductToBasketRequestDto addProductToBasketRequestDto);
    ICollection<BasketResponseDto> getAllBaskets();
    BasketResponseDto getBasketByBasketId(int basketId);
    BasketResponseDto getActiveBasketByCustomerId(int customerId);
    ICollection<BasketResponseDto> getBasketByBasketStatusId(int basketStatusId);
    ICollection<BasketResponseDto> getBasketByCustomerId(int customerId);

    void approveBasket(int basketId);

    void continueShopping(int basketId);
    
    bool statusBasketToOrder(int basketId);
    BasketResponseDto removeProductToBasket(RemoveProductToBasketDto removeProductToBasketDto);
}