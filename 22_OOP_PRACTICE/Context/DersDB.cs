using _22_OOP_PRACTICE.entities;

namespace _22_OOP_PRACTICE.Context;

public class DersDB
{
    
    public static List<Ders> dersler = new List<Ders>()
    {
        new Ders()
        {
            alan = "sayısal",
            ders_adi = Enum.GetName(Ders_Isimleri.matematik),
            gecme_notu = 30,
            ogrenci_sayisi = 30
            
        },
        new Ders()
        {
            alan = "sözel",
            ders_adi = DersAdi.türkçe,
            gecme_notu = 50,
            ogrenci_sayisi = 30
        },
        new Ders()
        {
            alan = "sayısal",
            ders_adi = DersAdi.biyoloji,
            gecme_notu = 45,
            ogrenci_sayisi = 30
        },
        new Ders()
        {
            alan = "sayısal",
            ders_adi = DersAdi.geometri,
            gecme_notu = 45,
            ogrenci_sayisi = 30
        }
    };
}