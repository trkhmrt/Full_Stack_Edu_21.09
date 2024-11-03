namespace _12_Dictionary;

class Program
{
    static void Main(string[] args)
    {
        /*
         Dictionary
         
         Verileri Key ve Value olarak sözlük mantığıyla depolar.
         Kelime:Kelimenin anlamı
         Key:Value
         
         */

        Dictionary<string, int> urunler = new Dictionary<string, int>();
        urunler["ülker"] = 100;
        urunler.Add("eti",250);

        foreach (var item in urunler)
        {
            Console.WriteLine(item.Key + " : " + item.Value + "TL");
        }

        Console.WriteLine("Aramak istediğiniz ürünü giriniz ");
        string urun = Console.ReadLine();
        string donus_cevabi = UrunBul(urun, urunler);
        Console.WriteLine(donus_cevabi);

        Console.WriteLine("Silinecek ürünün adını giriniz");
        string silinecek_urun = Console.ReadLine();
        UrunSil(silinecek_urun,urunler);
        
        
        
        
        
        
        
        


    }

    static string UrunBul(string urun_adi,Dictionary<string,int> urunler)
    {
        string mesaj = "";
        if (urunler.ContainsKey(urun_adi))
        {
            mesaj = "Ürünü bulundu";
        }
        else
        {
            mesaj = "ürünü bulunmadı";
        }

        return $"{urun_adi} "+mesaj;
    }

    static void UrunSil(string silinecek_urun_adi,Dictionary<string,int> urunler)
    {
       string donus_mesaji = UrunBul(silinecek_urun_adi, urunler);
       if (donus_mesaji == $"{silinecek_urun_adi} Ürünü bulundu")
       {
           urunler.Remove(silinecek_urun_adi);
       }
       else
       {
           Console.WriteLine("Silinecek ürün bulunamadı");
       }
    }
}