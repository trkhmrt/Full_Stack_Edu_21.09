using E_Commerce.Business.Dto;
using E_Commerce.Business.Interface;
using E_Commerce.DataAccess.Context;
using E_Commerce.DataAccess.Model;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce.Business.Service;

public class CategoryService : ICategoryService
{
    ProjectContext _context;


    public CategoryService(ProjectContext context)
    {
        _context = context;
    }
    
    public ICollection<CategoriesDto> GetAllCategories()
    {
        return _context.Categories
            .Select(sc=>new CategoriesDto
            {
                categoryId = sc.categoryId,
                categoryName = sc.categoryName,
                subCategoriesName = sc.subCategories.Select(s=>s.subCategoryName).ToList()
            })
            .ToList();
    }
}