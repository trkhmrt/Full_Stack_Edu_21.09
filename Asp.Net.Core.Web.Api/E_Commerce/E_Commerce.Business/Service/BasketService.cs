using E_Commerce.Business.Dto;
using E_Commerce.Business.Interface;
using E_Commerce.DataAccess.Context;
using E_Commerce.DataAccess.Model;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce.Business.Service;

public class BasketService: IBasketService
{
    ProjectContext _context;


    public BasketService(ProjectContext context)
    {
        _context = context;
    }

    public ICollection<BasketResponseDto> getAllBaskets()
    {
        return _context.Baskets
            .Include(b => b.User)
            .Include(b => b.BasketStatus)
            .Include(b => b.BasketDetails)
            .Select(b => new BasketResponseDto
            {
                basketId = b.basketId,
                baskeUserId = b.User.userId,
                basketUserName = b.User.userName,
                basketStatusId = b.basketStatusId,
                basketStatusName = b.BasketStatus.basketStatusName,
                basketDetails = b.BasketDetails.Select(b=> new BasketDetailsResponseDto
                {
                    productDescription = b.Product.productDescription,
                    productName = b.Product.productName,
                    basketQuantity = b.basket_quantity,
                    subCategoryName = b.Product.SubCategory.subCategoryName
                }).ToList()
            }).ToList();




    }

    public BasketResponseDto getBasketByBasketId(int basketId)
    {
        return _context.Baskets
            .Include(b => b.User)
            .Include(b => b.BasketStatus)
            .Include(b => b.BasketDetails)
            .Where(b => b.basketId == basketId)
            .Select(b => new BasketResponseDto
            {
                basketId = b.basketId,
                baskeUserId = b.User.userId,
                basketUserName = b.User.userName,
                basketStatusId = b.basketStatusId,
                basketStatusName = b.BasketStatus.basketStatusName,
                basketDetails = b.BasketDetails.Select(b=> new BasketDetailsResponseDto
                {
                    productDescription = b.Product.productDescription,
                    productName = b.Product.productName,
                    basketQuantity = b.basket_quantity,
                    subCategoryName = b.Product.SubCategory.subCategoryName
                }).ToList()
            }).FirstOrDefault();
    }

    public ICollection<BasketResponseDto> getBasketByBasketStatusId(int basketStatusId)
    {
        return _context.Baskets
            .Include(b => b.User)
            .Include(b => b.BasketStatus)
            .Include(b => b.BasketDetails)
            .Where(b => b.basketStatusId == basketStatusId)
            .Select(b => new BasketResponseDto
            {
                basketId = b.basketId,
                baskeUserId = b.User.userId,
                basketUserName = b.User.userName,
                basketStatusId = b.basketStatusId,
                basketStatusName = b.BasketStatus.basketStatusName

            }).ToList();
    }

    public BasketResponseDto getBasketByUserId(int userId)
    {
        return _context.Baskets
            .Include(b => b.User)
            .Include(b => b.BasketStatus)
            .Include(b => b.BasketDetails)
            .Where(b => b.userId == userId)
            .Select(b => new BasketResponseDto
            {
                basketId = b.basketId,
                baskeUserId = b.User.userId,
                basketUserName = b.User.userName,
                basketStatusId = b.basketStatusId,
                basketStatusName = b.BasketStatus.basketStatusName,
                basketDetails = b.BasketDetails.Select(b => new BasketDetailsResponseDto
                {
                    productDescription = b.Product.productDescription,
                    productName = b.Product.productName,
                    basketQuantity = b.basket_quantity,
                    subCategoryName = b.Product.SubCategory.subCategoryName
                }).ToList()
            }).FirstOrDefault();
    }

    
}