using Microsoft.VisualBasic;


namespace _09_Function;

class Program
{
    
    
    static void Main(string[] args)
    {

        
        
        /*
         Fonksiyon
         
         Kod tekrarının olduğu ve bir koda  birden fazla kez ihtiyaç duyulduğunda bu kod bloğu için bir fonksyion tanımlanır.Ve bu şekilde istenilen yerde çağrılır.
         
         
         Fonksyion Çeşitleri
         
           1-Geri Değer Döndürmeyen(void)(veri void'dir)
                - Parametreli
                - Parametresiz
            2-Geri Değer Döndüren(return)(veri tipi ihtiyaca göre değişir.)
                - Parametreli  
                - Parametresiz
                 
          METOTLAR NASIL ÇALIŞIR ? 
        
        NOT:Metotlar çağrılmadan çalışmazlar!
        
        1-Metot Çağrılır
        2-Okunan satır metodun çağrıldığı yere gelince buradan tanımlandığı yere gider
        3-Tanımlandığı yere gelen metod içerisindeki kodları çalıştırır.Çağrıldığı yere geri gider
        4-Çağrıldığı yerden sonraki satırlar okunmaya devam eder...
        
        
        NOTLAR
        
        -Parametreli fonksyionda parametre ismi ile içerisine gönderilecek olan değişkenin isminin aynı olması gerekmez.ANCAK metodun ihtiyaç duyduğu verinin takibini kolaylaştırmak için aynı isimde tanımlanması daha uygun olur.
        
        -Parametreleri metotların tercih edilme sebebi metodun içerisinin daha sade tutulması gerektiği içindir.
        
        -Verileri gönderirken parametrelerin sırasına ve veri tipine dikkat etmek gerekir.
        
        -METOT İSİMLERİ BÜYÜK HARFLE BAŞLAR.
        
        -Metotlarda return ifadesi break görevi görür.Metot içerisinde return den sonra kod çalıştırılmaz.metot çağrıldığı yere geri döner.
        
        -BİR Metot içerisinde birden fazla return çağrılmaz.
        
        
        
          
        erişim_belirleyici varsa fonksyion_döndüreceği_değer fonksiyon_ismi () {
        
        }
         
    
         */
        
        //ToplamaFonksiyonu();
        
        // int boy = 1;
        // int kilo = 20;
        //
        //BoyKilo(boy,kilo);

        
        //BETİMLEME
        /*
         
         Geri Değer döndürmeyen Metod -> Bağış gibi.Para verildikten sonra size asla geri gelmez.
         Geri Değer Döndüren Metod -> yatırım gibidir.O para size mutlaka geri döner.
         
         */
        // Console.WriteLine("Kullanıcı adını giriniz");
        // string ka= Console.ReadLine();
        //
        //
        // bool kontrol = KullaniciBul(ka);
        //
        // if (kontrol)
        // {
        //     Console.WriteLine("Başarılı bir şekilde giriş işlemi yaptınız");
        // }
        // else
        // {
        //     Console.WriteLine("Kullanıcı adı veya parola hatalı.");
        //    
        // }
        //
        //MetodunBreaki();






    }

    //Geri Değer döndürmeyen  & Parametresiz
    static void ToplamaFonksiyonu()
    {
        int sayi1 = 10;
        int sayi2 = 20;

        Console.WriteLine($"Toplam {sayi1 + sayi2}");
    }
    //Geri Değer döndürmeyen  & Parametreli
    static void BoyKilo(int boy,int kilo)
    {
        Console.WriteLine(boy);
        Console.WriteLine(kilo);
    }
    //Geri Değer döndüren   Parametreli
    static bool KullaniciBul(string kullanici_adi)
    {
        string kullanici_Adi_Veri_Tabani = "trk";

        if (kullanici_adi == kullanici_Adi_Veri_Tabani)
        {
            return true;
        }
        else
        {
            return false;
        }
  
    }
    //return ifadesi metotlarda break görevi görür.Birden fazla return ifadesi kullanılmaz.
    static string MetodunBreaki()
    {
        int sayi = 20;

        if (sayi == 20)
        {
            
            return "";
            return "Şu mesajı gönder";
            Console.WriteLine("Merhaba dünya");
        }
        else
        {
            return "sayi 20 değildir";
        }
        
    }
    
    
    
    
    
    
  
    
    
    
    
    
}