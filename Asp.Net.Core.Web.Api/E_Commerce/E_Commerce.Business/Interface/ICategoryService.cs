using E_Commerce.Business.Dto;

namespace E_Commerce.Business.Interface;

public interface ICategoryService
{
    ICollection<CategoriesDto> GetAllCategories();
}