namespace Microsoft_WebSite.DataAccess.Entities;

public class User
{
    public int UserID { get; set; }

    public string UserUsername { get; set; }
    
    public string UserPassword { get; set; }

    public string UserEmail { get; set; }

    public string userRole { get; set; }
    
}