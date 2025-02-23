using E_Commerce.Business.Dto;
using E_Commerce.Business.Interface;
using E_Commerce.DataAccess.Context;
using E_Commerce.DataAccess.Model;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce.Business.Service;

public class ProductService:IProductService
{
    ProjectContext _context;


    public ProductService(ProjectContext context)
    {
        _context = context;
    }

    public ICollection<ProductDto> GetAllProducts()
    {
        return _context.Products
            .Include(p=>p.SubCategory)
            .ThenInclude(sc=>sc.Category)
            .Select(p=> new ProductDto
            {
                productId = p.productId,
                productName = p.productName,
                productDescription = p.productDescription,
                subcategoryId = p.subCategoryId,
                subcategoryName = p.SubCategory.subCategoryName,
                categoryId = p.SubCategory.categoryId,
                categoryName = p.SubCategory.Category.categoryName
            }).ToList();
    }
}