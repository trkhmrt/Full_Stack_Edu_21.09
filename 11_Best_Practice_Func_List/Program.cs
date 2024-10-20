namespace _11_Best_Practice_Func_List;

class Program
{
    static void Main(string[] args)
    {
        /*
            AlışVeriş Uygulaması
            
            Marketin Reyon ürünleri Liste Olarak
            
            {"Ülker","Eti","herhangi bir ürün"}
            {100,300,150}
            -İsimleri string liste olarak tanımlayın.
            -Fiyatları int liste olarak tanımlayın.
            
            
            Müşteri Sepet
            -Müşteri sepeti string liste olarak tanımlanacak.
            -Müşterinin bakiyesi int olarak tanımlansın (Miktar size ait)
            -Alışveri tutarı int olarak tanımlanacak
            
            -Müşteri istediği ürünü aldıktan sonra  ürün market reyonundan silinecek . Müşteri sepetine eklenecek.Müşterinin toplam borcu artıcak.
            
            -Alışverişi bitir dediğinizde toplam tutar ve kalan tutar ekrana yazdırılacak.
         */
        
        //ÇÖZÜM

        List<string> urun_isimleri = new List<string>() { "ülker", "eti" };
        List<int> urun_fiyatlari = new List<int>() { 100, 80 };

        List<string> musteri_sepeti = new List<string>();
        int musteri_bakiye = 500;
        int toplam_tutar = 0;

        while (true)
        {


            Console.WriteLine("Markete Hoşgeldiniz");
            Console.WriteLine($"Bakiyeniz:{musteri_bakiye}");
            for (int i = 0; i < urun_isimleri.Count; i++)
            {
                Console.WriteLine($"{i + 1} {urun_isimleri[i]} - {urun_fiyatlari[i]} TL");
            }

            Console.WriteLine("Satın almak istediğiniz ürünü adını giriniz");
            string secim = Console.ReadLine().ToLower();
            if (urun_isimleri.Contains(secim))
            {
                musteri_sepeti.Add(secim);

                int index = urun_isimleri.IndexOf(secim);
                toplam_tutar += urun_fiyatlari[index];

                Console.WriteLine($"Toplam tutar:{toplam_tutar}");

            }
            else
            {
                Console.WriteLine("Aradığınız ürün markette bulunmuyor.");
            }

            Console.WriteLine("Alışverişe devam edecek misiniz ? (y)");
            string cevap = Console.ReadLine().ToLower();
            if (cevap != "y")
            {
                if (toplam_tutar > musteri_bakiye)
                {
                    Console.WriteLine($"Bakiyeniz:{musteri_bakiye}");
                    Console.WriteLine($"Toplam tutar:{toplam_tutar}");
                    Console.WriteLine("Yetersiz Bakiye");
                    musteri_sepeti.Clear();
                    toplam_tutar = 0;
                    break;
                }
                else
                {
                    musteri_bakiye -= toplam_tutar;
                    Console.WriteLine("Sepetinizdeki Ürünler");
                    for (int i = 0; i < musteri_sepeti.Count; i++)
                    {
                        Console.WriteLine($"{i+1} {musteri_sepeti[i]} - {urun_fiyatlari[urun_isimleri.IndexOf(musteri_sepeti[i])]} TL");
                    }
                    Console.WriteLine($"Toplam tutar:{toplam_tutar}");
                    Console.WriteLine($"Kalan bakiye : {musteri_bakiye}");
                    Console.WriteLine("Alışverişiniz başarılı bir şekilde gerçekleşti.Bizi tercih ettiğiniz için teşekkürler");
                    break;
                }
            }
         

        }


        //   11:30 MOLA BİTİŞ














    }
}