namespace E_Commerce.DataAccess.Model;

public class SubCategory
{
    public int subCategoryId { get; set; }
    
    public string subCategoryName { get; set; }
    
    public string subCategoryDescription { get; set; }
    
    public int categogryId { get; set; }
    
    public Category Category { get; set; }


    public List<Product> Products { get; set; }
    
}



