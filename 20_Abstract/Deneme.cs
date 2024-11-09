namespace _20_Abstract;

class ApiMesaj
{
    private ApiMesaj()
    {   
        
    }

    //Daha güvenli yöntem
    private static string Asilmesaj
    {
        get
        {
            return "200 OK";
        }
        
    }

    public static string mesaj
    {
        get
        {
            return Asilmesaj;
        }
    }
    
    //2. yöntem
    public static string staticMesaj = "200 OK";
    
    



}