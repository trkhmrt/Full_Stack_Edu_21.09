namespace E_Commerce.Business.Dto.requestDtos;

public class createNewProductDto
{
    
    public string productName { get; set; }
    
    public string productDescription { get; set; }
    
    public int productUnitPrice { get; set; }
    
    
    public int subCategoryId { get; set; }
    
}