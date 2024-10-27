namespace _14_Linq_Query;

class Program
{
    static void Main(string[] args)
    {
        //Linq sorguları yapılan data binding işlemlerini daha pratik bir şekilde yazmayı amaçlar.
        //Linq(Language Integrated Query)
        /*
        Yapılan sorgulamada eğer ki bir nesne tutan liste üzerinde çalışılıyorsa ,select kullanılarak bir sütun belirtilmezse nesnenin kendisini getirir.
         
         */

        // List<Ogrenci> ogrenciler = new List<Ogrenci>()
        // {
        //     new Ogrenci()
        //     {
        //         name = "Tarık",
        //         surname = "Hamarat",
        //         age = 50
        //     },
        //     new Ogrenci()
        //     {
        //         name ="Duhan",
        //         surname = "Göksal",
        //         age=85
        //     },
        //     new Ogrenci()
        //     {
        //         name ="Yusuf",
        //         surname = "Ergin",
        //         age=18
        //     },
        //     new Ogrenci()
        //     {
        //         name="Hamdi",
        //         surname="Kantekin",
        //         age=36
        //     },
        //     new Ogrenci()
        //     {
        //         name="Esra",
        //         surname="Çakıcı",
        //         age=22
        //     },
        //     new Ogrenci()
        //     {
        //         name = "Alper",
        //         surname="kayabaşı",
        //         age=13
        //         
        //     },
        //     new Ogrenci()
        //     {
        //         name = "Tuna",
        //         surname="Genç",
        //         age=27
        //         
        //     }
        //     
        // };

        // List<string> ogrenci_sonuc = ogrenciler.Select(o => o.name).ToList();
        //SELECT(Tablodan istenilen sütun bilgisini getirmeye yarar)
        // var ogrenci_sonuc2 = ogrenciler.Select(o => o.name);
        //
        // foreach (var item in ogrenci_sonuc)
        // {
        //     Console.WriteLine(item);
        // }

        //Where sorgusu(İstenilen koşulu sağlayan verilerin getirilmesini sağlar)
        //var yas_buyuk_on_sekiz = ogrenciler.Where(ogrenci => ogrenci.age > 18);
        //Where sorgusuyla birlikte Select
        //var yas_buyuk_on_sekiz_isimleri = ogrenciler.Where(ogrenci => ogrenci.age > 18).Select(ogrenci=>ogrenci.name);

        //FirstOrDefault(Tablo içerisinde sorgulama yapıldığında uygun koşula ait ilk veriyi getirir)
        
        //var ogrenci = ogrenciler.Where(o => o.age > 18).FirstOrDefault();

        
        //Startswith ve endswith ifadeleri ile başlangıç ve bitiş karakterleri kontrol edilir.
        // var t_ile_baslayan_k_ile_biten = ogrenciler.Where(ogrenci => ogrenci.name.StartsWith("T") && ogrenci.name.EndsWith("k"));
        
        
        //Distinct ifadesi ile tekrar sayısını teke düşürür ve böylece birbirinden farklı tek değerler gelir.
        
        // List<int> sayilar = new List<int>(){11,11,20,20,30,40,50,23,23,99};
        // //
        // // var farkli_sayilar = sayilar.Distinct();
        //
        // var adet = sayilar.Where(sayi => sayi % 2 == 0).Distinct().Count();
        
        
        
        //SELECT İLE VERİLERİ NESNE OLARAK GETİRME(İstenilen property ile birlikte)
       // var ogrenci_listesi = ogrenciler.Select(ogrenci => new { ogrenci.name});
        
        
       //ORDER BY ile sıralama

       //Default hali ascending(Küçükten büyüğe doğru sıralama)
       //var siralama = ogrenciler.OrderBy(ogrenci => ogrenci.age);
       //Descending(Büyükten küçüğe doğru sıralama yapar.)
       //var siralama2 = ogrenciler.OrderBy(ogrenci => ogrenci.age).OrderDescending();
      
       
       //ınline olarak foreach kullanımı
        //ogrenciler.ForEach(ogrenci => Console.WriteLine(ogrenci.name));

        //UNION
        // List<string> isimler = new List<string>(){"Furkan","Alper","Duhan"};
        // List<string> isimler2 = new List<string>(){"Tuna","Hamdi","Ömer","Yusuf","Esra"};
        // //Union-Birleştirme
        // var karsilastirma = isimler.Union(isimler2);
        
         
        
        List<Ogrenci> ogrenciler = new List<Ogrenci>()
        {
            new Ogrenci()
            {
                name = "Tarık",
                surname = "Hamarat",
                age = 50,
                 puan1 = 20,
                 puan2= 30,
            },
            new Ogrenci()
            {
                name ="Duhan",
                surname = "Göksal",
                age=85,
                puan1 = 40,
                puan2= 50,
            },
            new Ogrenci()
            {
                name ="Yusuf",
                surname = "Ergin",
                age=18,
                puan1 = 60,
                puan2= 90,
            },
            new Ogrenci()
            {
                name="Hamdi",
                surname="Kantekin",
                age=36,
                puan1 = 80,
                puan2= 100,
            },
            new Ogrenci()
            {
                name="Esra",
                surname="Çakıcı",
                age=22,
                puan1 =95,
                puan2= 95,
            },
            new Ogrenci()
            {
                name = "Alper",
                surname="kayabaşı",
                age=13,
                puan1 = 99,
                puan2= 88,
                
            },
            new Ogrenci()
            {
                name = "Tuna",
                surname="Genç",
                age=27,
                puan1 = 45,
                puan2= 92,
                
            }
            
        };
        
        
        
        
        //Her bir öğrencinin not ortalamasını bulun.

        var sinif_ortalama = ogrenciler.Select(ogrenci => (ogrenci.puan1 + ogrenci.puan2)/2).Average();
        
        //puan1 değeri 50 üzerindeki öğrencileri bulun

        var puan_buyuk_elli = ogrenciler.Where(ogrenci => ogrenci.puan1 > 50);

        //İsmi a ile biten ve yaşı 22 den büyük olan öğrenciyi bulun.

        var sonuc = ogrenciler.Where(ogrenci => ogrenci.name.EndsWith("a") && ogrenci.age > 22);

        //İsmi t ile başlayan öğrencilerin notlarını büyükten küçüğe sıralayın

        var sonuc2 = ogrenciler.OrderByDescending(ogrenci => ogrenci.puan1)
            .Where(ogrenci => ogrenci.name.StartsWith("T"));
        
        //Önce şart sağlayanları getir ardından bunlar arasında sıralama yap.
        var sonuc3 = ogrenciler.Where(ogrenci => ogrenci.name.StartsWith("T")) .OrderByDescending(ogrenci => ogrenci.puan1);
       
            
        //Yaşı 18'e eşit ve küçük olan öğrencilerin bilgisini nesne olarak ve sadece isim propertysiyle getirin.

        var ogrenci_isimleri_nesnesi = ogrenciler.Where(ogrenci=>ogrenci.age<=18).Select(ogrenci=>new {ogrenci.name,ogrenci.age});

        
        





    }
}