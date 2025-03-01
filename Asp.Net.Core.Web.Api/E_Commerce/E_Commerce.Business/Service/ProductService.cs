using E_Commerce.Business.Dto;
using E_Commerce.Business.Dto.requestDtos;
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
                categoryName = p.SubCategory.Category.categoryName,
                productUnitPrice = p.productUnitPrice,
                isProductActive = p.isProductActive
            }).ToList();
    }

    public ProductDto GetProductById(int id)
    {
        ProductDto? productDto = _context.Products
            .Include(p => p.SubCategory)
            .ThenInclude(sc => sc.Category)
            .Where(p=>p.productId==id)
            .Select(p => new ProductDto
            {
                productId = p.productId,
                productName = p.productName,
                productDescription = p.productDescription,
                subcategoryId = p.subCategoryId,
                subcategoryName = p.SubCategory.subCategoryName,
                categoryId = p.SubCategory.categoryId,
                categoryName = p.SubCategory.Category.categoryName,
                productUnitPrice = p.productUnitPrice,
                isProductActive = p.isProductActive,
            }).FirstOrDefault();

        return productDto;
    }

    public bool createNewProduct(createNewProductDto newProduct)
    {
        try
        {
            Product product = new Product()
            {
                productName = newProduct.productName,
                productDescription = newProduct.productDescription,
                subCategoryId = newProduct.subCategoryId,
                productUnitPrice = newProduct.productUnitPrice,
            
            };
            
            _context.Products.Add(product);
            _context.SaveChanges();
            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return false;
        }
   
    }
}