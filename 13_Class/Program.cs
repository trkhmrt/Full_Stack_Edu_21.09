namespace _13_Class;

class Program
{
    static void Main(string[] args)
    {
        /*
         
        CLASS NEDİR ? 
      
        class referans tiptir.
        
        OOP'nin temel yapı taşıdır.
    
        İçerisinde Metotları ve değişkenleri barındırabilir.
        
        Modülerliği sağlar , bakım ve geliştirme maliyetlerini düşürür.
        
        
        CLASS NASIL TANIMLANIR ?
        
        erişim_belirleyici class Class_Adi {
        
        
        }
         */


        // string marka = "bmw";
        // string renk = "mavi";
        //
        // Console.WriteLine("Veri tabanına kaydedildi");
        //
        //
        //
        // string marka2 = "mercedes";
        // string renk2 = "mavi";
        //
        // Console.WriteLine("Veri tabanına kaydedildi");
        //
        //
        // string marka3 = "mercedes";
        // string renk3 = "mavi";

        
        /*
         NESNE NEDİR ? 
         
         Canlı yada cansız varlıkların yazılım ortamında algılanacak şekilde tanımlanması ve üretilip kulllanılacak hale getirilmesidir.
        
         */
        
        
        //NESNE/OBJE ÜRETMEK(INSTANCE) 
        // Otomobil otomobil = new Otomobil();
        // Console.WriteLine(otomobil.GetHashCode());
        // otomobil.marka = "bmw";
        // otomobil.renk = "mavi;";
        //
        // Otomobil otomobil2 = new Otomobil();
        // Console.WriteLine(otomobil2.GetHashCode());
        // otomobil2.marka = "mercedes";
        // otomobil2.renk = "kırmızı;";
        //
        // Otomobil otomobil3 = new Otomobil();
        // Console.WriteLine(otomobil3.GetHashCode());
        // otomobil3.marka = "toyota";
        // otomobil3.renk = "beyaz;";
        

        // Console.WriteLine(otomobil.marka +" "+otomobil.renk);
        // Console.WriteLine(otomobil2.marka +" "+otomobil2.renk);
        // Console.WriteLine(otomobil3.marka +" "+otomobil3.renk);
        
        List<Otomobil> otomobiller = new List<Otomobil>()
        {
            new Otomobil()
            {
                id = 1,
                marka = "BMW",
                renk = "kırmızı"
            },
            new Otomobil()
            {
                id = 2,
                marka = "Mercedes",
                renk = "Mavi"
            }

        };
        
        // for (int i = 0; i < 2; i++)
        // {
        //     Otomobil otomobil = new Otomobil();
        //     otomobil.id = otomobil.GetHashCode();
        //     Console.WriteLine("Marka:");
        //     otomobil.marka = Console.ReadLine();
        //     Console.WriteLine("Renk:");
        //     otomobil.renk = Console.ReadLine();
        //
        //     Console.WriteLine(otomobil.id);
        //     
        //     otomobiller.Add(otomobil);
        // }

        foreach (var item in otomobiller)
        {
            Console.WriteLine(item.id + " " + item.marka + " " + item.renk);
        }
        
        
        Console.WriteLine("Güncellenecek otomobilin id değerini giriniz");
        int id = Convert.ToInt32(Console.ReadLine());
        
        foreach (var item in otomobiller)
        {
            if (item.id == id)
            {
                item.renk = "Sarı";
            }
        }

        foreach (var item in otomobiller)
        {
            Console.WriteLine(item.id + " " + item.marka + " " + item.renk);
        }

        Console.WriteLine("Silinecek otomobilin id değerini giriniz");
        int silinecek_id = Convert.ToInt32(Console.ReadLine());
        
        foreach (var item in otomobiller)
        {
            if (item.id == silinecek_id)
            {
                otomobiller.Remove(item);
                break;
            }
            
        }
        
        foreach (var item in otomobiller)
        {
            Console.WriteLine(item.id + " " + item.marka + " " + item.renk);
        }
        
        
        /*
         Belirlediğiniz herhangi bir senaryo ,
         
         Bu senaryoya bağlı olarak  Liste , Metot  ve Class yapılarını kullandığınız CRUD operasyonlarını içeren bir uygulama yazın.
         C -> Create 
         R -> Read
         U -> Update
         D -> Delete
        
         */
        
        
         
    
        
        
    }
}
