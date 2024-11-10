using _22_OOP_PRACTICE.entities;

namespace _22_OOP_PRACTICE.Context;

public class OgrenciDB
{
    private OgrenciDB()
    {
        //Newlenmesin diye bir önlem yaptım.
    }
    
    public static List<Ogrenci> ogrenciler = new List<Ogrenci>()
    {
        new Ogrenci()
        {
          
           dogum_tarihi = Convert.ToDateTime("01.11.1997"),
           name = "Tarık",
           surname ="Hamarat",
           okul_no = Guid.NewGuid().ToString(),
           
        },
        new Ogrenci()
        {
        
            dogum_tarihi = Convert.ToDateTime("01.12.1998"),
            name = "Ömer",
            surname ="Şahin",
            okul_no = Guid.NewGuid().ToString(),
           
        }
    };
    
    
}