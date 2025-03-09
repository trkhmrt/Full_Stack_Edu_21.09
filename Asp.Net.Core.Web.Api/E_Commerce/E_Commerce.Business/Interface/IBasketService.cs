using E_Commerce.Business.Dto;
using E_Commerce.Business.Dto.requestDtos;
using E_Commerce.DataAccess.Model;

namespace E_Commerce.Business.Interface;

public interface IBasketService
{
    BasketResponseDto addProductToBasket(AddProductToBasketRequestDto addProductToBasketRequestDto);
    ICollection<BasketResponseDto> getAllBaskets();
    BasketResponseDto getBasketByBasketId(int basketId);
    ICollection<BasketResponseDto> getBasketByBasketStatusId(int basketStatusId);
    BasketResponseDto getBasketByUserId(int userId);

    void approveBasket(int basketId);

    void continueShopping(int basketId);
    
    bool statusBasketToOrder(int basketId);
    BasketResponseDto removeProductToBasket(RemoveProductToBasketDto removeProductToBasketDto);
}