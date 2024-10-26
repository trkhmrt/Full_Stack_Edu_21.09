using _13_Class_Practice.Models;
using _13_Class_Practice.Services;

namespace _13_Class_Practice;

class Program
{
    static void Main(string[] args)
    {
        OgrenciService ogrenciService = new OgrenciService();

        for (int i = 0; i < 3; i++)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.id = (ogrenciService.ogrenciler.Count()+1).ToString();
            ogrenci.name = $"Yeni öğrenci {i+1}";
            ogrenci.cinsiyet = "Erkek";
            ogrenciService.OgrenciCreate(ogrenci);
        }

        //Burada bulunana öğrenci aşağıdaki metotlara parametre olarak geçilebilir.
        // Console.WriteLine("İşlem yapılacak öğrenci id yi giriniz");
        // string ogrenci_id = Console.ReadLine();
        //
        // Ogrenci bulunan_ogrenci = ogrenciService.OgrenciFindById(ogrenci_id);
        
      
        ogrenciService.OgrenciGetAll();
        //
        // ogrenciService.OgrenciRemove(ogrenci);
        // ogrenciService.OgrenciGetAll();
        //
        // ogrenciService.OgrenciCreate(ogrenci);
        // ogrenciService.OgrenciGetAll();
        //
        // ogrenciService.OgrenciUpdate(ogrenci);
        // ogrenciService.OgrenciGetAll();
        //
     
        
        
        
        
        
    }
}