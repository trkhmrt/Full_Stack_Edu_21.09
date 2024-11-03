namespace _07_While_Loop;

class Program
{
    static void Main(string[] args)
    {
         /*


           While Döngüsü
           while(buradaki_durum_true ise kod çalışır){
           }


           */

        // while (3<10)
        // {
        //     Console.WriteLine("Merhaba dünya");
        // }

        // int i = 0;
        // while (i<10)
        // {
        //     
        //     Console.WriteLine(i);
        //     i++;
        //
        // }
        
        /*
         * While döngüsü kullanarak 1-50 arasındaki çift sayıları ekrana yazdırın.
         */

        // int i = 0;
        //
        // while (i<50)
        // {
        //     if (i % 2 == 0)
        //     {
        //         Console.WriteLine(i);
        //         
        //     }
        //
        //     i++;
        //    
        // }

        /*
         *Kullanıcıdan 0-9 arası rakam girmesini isteyin 0 girdiğinde while döngüsünden çıkarın.
         * 
         */
        //1.yöntem
        // int rakam;
        // while (true)
        // {
        //     Console.WriteLine("0-9 rakam gir");
        //     rakam = Convert.ToInt32(Console.ReadLine());
        //     if (rakam == 0)
        //         break;
        // }
        
        //2.yöntem
        // int sayi=1;
        //
        // while (sayi!=0)
        // {
        //     try
        //     {
        //         Console.WriteLine("Rakam giriniz");
        //         sayi = Convert.ToInt32(Console.ReadLine());
        //     
        //     }
        //     catch (Exception e)
        //     {
        //         Console.WriteLine("Hatalı değer girdiniz Rakam giriniz");
        //     }
        //         
        //     
        // }
        //
        // Console.WriteLine("0 girdiniz döngüden çıkıldı");
        
        
        /*
         For döngüsü kullanarak çarpım tablosunu ekrana yazdırın
         */

        /*
         1x1   2x1   3x1
         1x2   2x2   3x2
         1x3   2x3   3x3
         1x4   ...   ...
         ...   2x10
         1x10
         
         
         */
        
        
        // for (int i = 1; i <= 10; i++)
        // {
        //  for (int j = 1; j <= 10; j++)
        //  {
        //   Console.Write($"{j}x{i}={j*i}\t");
        //  }
        //  Console.WriteLine("");
        // }
        
            
        
        /*
         
         kullanıcıdan 3 adet ürün fiyatı girmesini isteyin.Girilen ürünlerin fiyatı toplamı 500 tl ve üzerindeyse 200 tl indirim yapılsın değilsede 100tl indirim yapılsın.
         
         kullanıcıya yapılan indirim miktarı ve  ürünlerin toplam fiyatı gösterilsin.
         While döngüsü kullanarak yapın.
         
         */
        int i = 0;
        double toplam_fiyat = 0.0;
        while (i<3)
        {
         Console.WriteLine($"{i+1}.Ürünün fiyatı giriniz");
         double fiyat = Convert.ToDouble(Console.ReadLine());
         toplam_fiyat += fiyat;
         i++;
        }
        if (toplam_fiyat >= 500)
        {
         toplam_fiyat -= 200;
         Console.WriteLine($"indirim miktarı:{200}TL");
        }
        else
        {
         toplam_fiyat -= 100;
         Console.WriteLine($"indirim miktarı:{100}TL");
        }
        Console.WriteLine($"Toplam fiyat:{toplam_fiyat}");
        
        
        
        
        

    }
}