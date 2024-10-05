using System;

namespace _05_İF_ELSE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Değer Giriniz: ");
            //int yas = Convert.ToInt32(Console.ReadLine());
            //if (yas > 0)
            //{
            //    Console.Write("Pozitif bir değer girdiniz ");

            //}
            //else if (yas < 0)
            //{

            //    Console.Write("Negatif bir değer girdiniz ");
            //}
            ////else if (yas == 0)
            ////{

            ////    Console.WriteLine("0 girdiniz");
            ////}
            //else
            //{
            //    Console.Write("0 girdiniz");
            //}
            /*
            string belge1 = "Takdir";
            string belge2 = "Teşekkür";
            while (true)    

            {
                
                Console.WriteLine("Not Giriniz: ");
                int not = Convert.ToInt32(Console.ReadLine());
                if (not > 0 && not <= 44)
                {
                    Console.WriteLine("Kaldınız ");              
                }
                else if (not > 44 && not <= 59)
                {
                    Console.WriteLine("Geçtiniz ");                  
                }
                else if (not > 59 && not <= 84)
                {
                    Console.WriteLine($"{belge2} aldınız ");                   
                }
                else if (not > 84 && not <= 100)
                {
                    Console.WriteLine($"{belge1} e şayansınız ");                  
                }
                else
                {
                    Console.Write("Böyle bir not olamaz");          
                }
                Thread.Sleep(2000); //uygulamayı 3 saniye durdurdu
                Console.Clear();// console temizlendi
            */
            int maas = 17000;
            int yeni_maas = 0;
           
                Console.WriteLine("yaş Giriniz: ");
                int yas = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Cocuk sayısı giriniz ");
                int sayi = Convert.ToInt32(Console.ReadLine());

            if (yas >= 0 && yas =< 45)
            {
                Console.WriteLine("Çalışmaya devam ");
            }
            else if (sayi > 0)
            {
                Console.WriteLine("Emekli olabilirsiniz");
                yeni_maas = maas + (sayi * 200);
                Console.WriteLine("yeni maaş" + maas);

            }
            else {

                yeni_maas = maas + 200;
                Console.WriteLine("eski maaş"+maas);
                Console.WriteLine("yeni maas"+yeni_maas);
                Console.WriteLine("cocuk sayisi"+sayi);
                Console.WriteLine(  );
            }
                
               
  
            





        
        }
    }
}


