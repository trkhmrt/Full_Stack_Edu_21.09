using E_Commerce.Business.Dto;
using E_Commerce.Business.Dto.requestDtos;
using E_Commerce.DataAccess.Model;

namespace E_Commerce.Business.Interface;

public interface IProductService
{
    ICollection<ProductDto> GetAllProducts();
    ProductDto GetProductById(int id);
    bool createNewProduct(createNewProductDto newProduct);
    
}