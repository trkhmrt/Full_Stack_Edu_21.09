namespace E_Commerce.DataAccess.Model;

public class Category
{
    public int categoryId { get; set; }
    
    public string categoryName { get; set; }
    
    public string categoryDescription { get; set; }
    
    public List<SubCategory> subCategories { get; set; }
    
    
}