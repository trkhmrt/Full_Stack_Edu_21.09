using System.Collections;
using System.Net;
using System.Text.Json;
using Azure.Core;
using E_Commerce.Business.Dto;
using E_Commerce.Business.Dto.requestDtos;
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
  
    public BasketResponseDto addProductToBasket(AddProductToBasketRequestDto addProductToBasketRequestDto)
    {
        Basket basket = _context.Baskets.FirstOrDefault(b=>(b.customerId == addProductToBasketRequestDto.customerId) && (b.basketStatusId == 1 || b.basketStatusId == 3));

        if (basket != null)
        {
            if (basket.basketStatusId == 1)
            {
                var basketDetail = _context.BasketDetails.Where(bd=>bd.basketId == basket.basketId && basket.basketStatusId ==1);
                var basketProduct = basketDetail.FirstOrDefault(bd=>bd.productId == addProductToBasketRequestDto.productId);
                if (basketProduct != null)
                {
                    basketProduct.basket_quantity += 1;
                    _context.SaveChanges();
                }
                else
                {
                    //Ürün hiç yoksa o id ye ait ürünü bul db ye ekle.
                    Product product = _context.Products.FirstOrDefault(p => p.productId == addProductToBasketRequestDto.productId);
                    BasketDetail new_basketDetail = new BasketDetail
                    {
                        basketId = basket.basketId,
                        productId = addProductToBasketRequestDto.productId,
                        basket_quantity = addProductToBasketRequestDto.quantity,
                    };
                    _context.BasketDetails.Add(new_basketDetail);
                    _context.SaveChanges();
                }

           
            }
            else if (basket.basketStatusId == 3)
            {
                continueShopping(basket.basketId);
                addProductToBasket(addProductToBasketRequestDto);
            }
            else
            {
                throw new Exception($"Basket status {basket.basketStatusId} is not valid");
            }
            return getBasketByBasketId(basket.basketId);
        }
        else
        {
            Basket new_basket = new Basket
            {
                basketStatusId = 1,
                customerId = addProductToBasketRequestDto.customerId,
                BasketDetails = new List<BasketDetail>
                {
                    new BasketDetail
                    {
                        productId = addProductToBasketRequestDto.productId,
                        basket_quantity = addProductToBasketRequestDto.quantity,
                    }
                }
            };
            
            _context.Baskets.Add(new_basket);
            _context.SaveChanges();
            
            return getBasketByBasketId(new_basket.basketId);
        }
        
        
        
    }

    public ICollection<BasketResponseDto> getAllBaskets()
    {
        return _context.Baskets
            .Include(b => b.Customer)
            .Include(b => b.BasketStatus)
            .Include(b => b.BasketDetails)
            .Select(b => new BasketResponseDto
            {
                basketId = b.basketId,
                basketCustomerId = b.Customer.customerId,
                basketUserName = b.Customer.customerUserName,
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
            .Include(b => b.Customer)
            .Include(b => b.BasketStatus)
            .Include(b => b.BasketDetails)
            .Where(b => b.basketId == basketId)
            .Select(b => new BasketResponseDto
            {
                basketId = b.basketId,
                basketCustomerId = b.Customer.customerId,
                basketUserName = b.Customer.customerUserName,
                basketStatusId = b.basketStatusId,
                basketStatusName = b.BasketStatus.basketStatusName,
                basketDetails = b.BasketDetails.Select(b=> new BasketDetailsResponseDto
                {
                    productId = b.productId,
                    productDescription = b.Product.productDescription,
                    productName = b.Product.productName,
                    productPrice = b.Product.productUnitPrice,
                    basketQuantity = b.basket_quantity,
                    subCategoryName = b.Product.SubCategory.subCategoryName
                }).ToList()
            }).FirstOrDefault();
    }

    public BasketResponseDto getActiveBasketByCustomerId(int customerId)
    {
        return _context.Baskets
            .Include(b => b.Customer)
            .Include(b => b.BasketStatus)
            .Include(b => b.BasketDetails)
            .Where(b => b.customerId == customerId && b.basketStatusId == 1)
            .Select(b => new BasketResponseDto
            {
                basketId = b.basketId,
                basketCustomerId = b.Customer.customerId,
                basketUserName = b.Customer.customerUserName,
                basketStatusId = b.basketStatusId,
                basketStatusName = b.BasketStatus.basketStatusName,
                basketDetails = b.BasketDetails.Select(b=> new BasketDetailsResponseDto
                {
                    productId = b.productId,
                    productDescription = b.Product.productDescription,
                    productName = b.Product.productName,
                    productPrice = b.Product.productUnitPrice,
                    basketQuantity = b.basket_quantity,
                    subCategoryName = b.Product.SubCategory.subCategoryName
                }).ToList()
            }).FirstOrDefault();
    }
    public BasketResponseDto getReadyForPaymentBasketByCustomerId(int customerId)
    {
        return _context.Baskets
            .Include(b => b.Customer)
            .Include(b => b.BasketStatus)
            .Include(b => b.BasketDetails)
            .Where(b => b.customerId == customerId && b.basketStatusId == 3)
            .Select(b => new BasketResponseDto
            {
                basketId = b.basketId,
                basketCustomerId = b.Customer.customerId,
                basketUserName = b.Customer.customerUserName,
                basketStatusId = b.basketStatusId,
                basketStatusName = b.BasketStatus.basketStatusName,
                basketDetails = b.BasketDetails.Select(b=> new BasketDetailsResponseDto
                {
                    productId = b.productId,
                    productDescription = b.Product.productDescription,
                    productName = b.Product.productName,
                    productPrice = b.Product.productUnitPrice,
                    basketQuantity = b.basket_quantity,
                    subCategoryName = b.Product.SubCategory.subCategoryName
                }).ToList()
            }).FirstOrDefault();
    }
    public ICollection<BasketResponseDto> getBasketByBasketStatusId(int basketStatusId)
    {
        return _context.Baskets
            .Include(b => b.Customer)
            .Include(b => b.BasketStatus)
            .Include(b => b.BasketDetails)
            .Where(b => b.basketStatusId == basketStatusId)
            .Select(b => new BasketResponseDto
            {
                basketId = b.basketId,
                basketCustomerId = b.Customer.customerId,
                basketUserName = b.Customer.customerUserName,
                basketStatusId = b.basketStatusId,
                basketStatusName = b.BasketStatus.basketStatusName

            }).ToList();
    }

    public ICollection<BasketResponseDto> getBasketByCustomerId(int basketCustomerId)
    {
        return _context.Baskets
            .Include(b => b.Customer)
            .Include(b => b.BasketStatus)
            .Include(b => b.BasketDetails)
            .Where(b => b.customerId == basketCustomerId)
            .Select(b => new BasketResponseDto
            {
                basketId = b.basketId,
                basketCustomerId = b.Customer.customerId,
                basketUserName = b.Customer.customerUserName,
                basketStatusId = b.basketStatusId,
                basketStatusName = b.BasketStatus.basketStatusName,
                basketDetails = b.BasketDetails.Select(b => new BasketDetailsResponseDto
                {
                    productDescription = b.Product.productDescription,
                    productName = b.Product.productName,
                    basketQuantity = b.basket_quantity,
                    subCategoryName = b.Product.SubCategory.subCategoryName
                }).ToList()
            }).ToList();
    }

    public BasketCheckOutResponse checkoutBasket(int customerId)
    {
        BasketResponseDto basketResponseDto = getReadyForPaymentBasketByCustomerId(customerId);
        CustomerCheckOutInfo customerCheckOutInfo = new CustomerCheckOutInfo
        {
            customerAddress = new List<string>{ "Sefaköy/Küçükçekmece", "Halkalı/Meydan" },
            customerCreditCards = new List<string>{ "5890040000000016", "5526080000000006" }
        };

        BasketCheckOutResponse basketCheckOutResponse = new BasketCheckOutResponse
        {
            basketResponseDto = basketResponseDto,
            customerCheckOutInfo = customerCheckOutInfo
        };
        
        return basketCheckOutResponse;
    }

    public void approveBasket(int basketId)
    {
        /*
         Basket Statuses
         Basket onaylandığında -> id 3 Sepet Ödemeye Hazır
         */
        Basket basket = _context.Baskets.Find(basketId);

        if (basket == null || basket.basketStatusId != 1)
        {
            throw new Exception("Sepet bulunamadı veya hatalı sepet üzerinde işlem yapıyorsunuz.");
        }
        else
        {
            basket.basketStatusId = 3;

            _context.Update(basket);
            _context.SaveChanges();

        }
       
    }

    public void continueShopping(int basketId)
    {
        /*
         Basket Statuses
         Basket onaylandığında -> id 1 Sepet Aktif
         */
        Basket basket = _context.Baskets.Find(basketId);
        if (basket == null || basket.basketStatusId == 4 || basket.basketStatusId == 2)
        {
            throw new Exception("Sepet bulunamadı veya hatalı sepet üzerinde işlem yapıyorsunuz.");
        }
        else
        {
            basket.basketStatusId = 1;

            _context.Update(basket);
            _context.SaveChanges();

        }
    }

    public bool statusBasketToOrder(int basketId)
    {
        Basket basket = _context.Baskets.Find(basketId);
        if (basket == null)
        {
            throw new Exception("Basket not found");
        }
        else
        {
            basket.basketStatusId = 4;

            _context.Update(basket);
            _context.SaveChanges();
            
        }

        return true;
    }

    public BasketResponseDto removeProductToBasket(RemoveProductToBasketDto removeProductToBasketDto)
    {
        Basket basket = _context.Baskets.FirstOrDefault(b=>b.basketId == removeProductToBasketDto.basketId);
        if (basket != null)
        {
            ICollection<BasketDetail> basketDetails = _context.BasketDetails.Where(b => b.basketId == removeProductToBasketDto.basketId).ToList();
            _context.BasketDetails.Remove(basketDetails.FirstOrDefault(b => b.productId == removeProductToBasketDto.productId && b.basketId == removeProductToBasketDto.basketId));
            _context.SaveChanges();
        }
        else
        {
            throw new Exception("Basket not found");
        }
        return getBasketByBasketId(removeProductToBasketDto.basketId);
    }
}