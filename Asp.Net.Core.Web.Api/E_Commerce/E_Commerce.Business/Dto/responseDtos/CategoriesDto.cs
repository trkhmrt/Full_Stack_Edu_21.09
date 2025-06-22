using E_Commerce.DataAccess.Model;

namespace E_Commerce.Business.Dto;

public class CategoriesDto
{
    public int categoryId  { get; set; }
    public string categoryName { get; set; }
    public ICollection<String> subCategoriesName { get; set; }
    
}