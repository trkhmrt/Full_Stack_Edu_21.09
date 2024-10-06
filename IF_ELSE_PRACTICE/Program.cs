namespace IF_ELSE_PRACTICE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ÖRNEKLER

            /*SORU-1 Klavyeden girilen değerin pozitif , negatif , sıfıra eşitlik durumunu kontrol edin.Uygun mesajı ekrana yazdırın.  süre: 7DK  */


            //while (true)
            //{

            //    Console.WriteLine("Sayı giriniz");
            //    int sayi = Convert.ToInt32(Console.ReadLine());

            //    if (sayi >= 0)
            //    {
            //        Console.WriteLine("Sayı pozitif");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Negatif");
            //    }

            //}


            //ARALIK BELİRTME
            int sayi = 10;

            if(sayi>2 && sayi<11 )
            {
                Console.WriteLine("2 ile 11 arasında");
            }

            /*  
             *  
             Kullanıcı not bilgisi girdiğinde aşağıda belirtilen uygun aralığa göre konsolda bir mesaj yazdırın.
             
             0-44 kaldı
             45-59 geçti
             60-84 teşekkür
             85-100 takdir
          
             */

            //string belge1 = "Teşekkür";
            //string belge2 = "Takdir";
            //string belge3 = "Belgesiz";

            //string mesaj = "";

            //while (true)
            //{

            //    //Console.Clear()  Konsoldaki çıktı geçmişini temizler
            //    //Thread.Sleep(1000); Uygulama akışını belirtilen ms cinsinden süre kadar durdurur.
            //    Console.WriteLine("Not giriniz");
            //    int not = Convert.ToInt32(Console.ReadLine());

            //    if (not >= 0 && not < 45)
            //    {
            //        Console.WriteLine("Öğrenci Kaldı");

            //    }
            //    else if (not >= 45 && not < 60)
            //    {
            //        Console.WriteLine($"Öğrenci {belge3} sınıfı geçti.");

            //    }
            //    else if (not >= 60 && not < 85)
            //    {
            //        Console.WriteLine($"Öğrenci {belge1} belgesi ile sınıfı geçti.");

            //    }
            //    else if (not >= 85 && not <= 100)
            //    {
            //        Console.WriteLine($"öğrenci {belge2} belgesi ile sınıfı geçti");

            //    }
            //    else
            //    {
            //        Console.WriteLine("0-100 aralığında uygun bir not değeri giriniz.");

            //    }
            //    Thread.Sleep(2000);
            //    Console.Clear();
            //}

            /*
             
            Kullanıcıdan alınana yaş bilgisine göre emeklilik ikramiyesi hesaplansın
            
             45 den küçükse Çalışmaya devam

            45 den büyükse Emekli ve ,
                -çocuk yoksa -> maaşa +200 TL eklensin
                -çocuk varsa -> çocuk sayısı kadar * 200 TL

            Kişinin maaşı asgari ücret üzerinden hesaplansın 

            Kişinin İkramiye hakedişden önceki ve sonraki maaşı ayrıca çocuk sayısı ekrana yazdırılsın.

            Ayrıca Çocuk sayısından gelen hakedişde ekrana ayrıntı olarak yazdırılsın

            Hesaplamadan önce maaşınız 
            İkramiyeli maaş
            Çocuk sayısı
            Çocuk sayısından doğan hakediş


  
             */

            int maas = 17000;
            int yeni_maas = 0;
            Console.WriteLine("Yaş bilgisi");
            int yas=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Çocuk Sayısı");
            int cocuk_sayisi = Convert.ToInt32(Console.ReadLine());

            if (yas>=0 && yas<= 45)
            {
                Console.WriteLine("Çalışmaya devam");
            }
            else if (cocuk_sayisi > 0)
            {
                yeni_maas = maas + (cocuk_sayisi * 200);
                Console.WriteLine($"Eski maaş{maas} ₺");
                Console.WriteLine($"İkramiyeli maaş{yeni_maas} ₺");
                Console.WriteLine($"Çocuk sayısı {cocuk_sayisi}");
                Console.WriteLine($"Çocuk sayısı {cocuk_sayisi * 200} ₺");
            }
            else
            {
                //maas = maas + 200;
                yeni_maas = maas + 200;
                Console.WriteLine($"Eski maaş:{maas} TL");
                Console.WriteLine($"İkramiyeli maaş:{yeni_maas} TL");
                Console.WriteLine($"Çocuk sayısı:{cocuk_sayisi}");
                Console.WriteLine($"Çocuk sayısından doğan hakediş:{cocuk_sayisi * 200} TL");
            }








        }
    }
}
