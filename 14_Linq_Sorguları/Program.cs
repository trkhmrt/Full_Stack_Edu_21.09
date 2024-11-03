using _14_Linq_Sorguları;

namespace _14_Linq_Query
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Linq sorguları daha pratik bir şekilde  data binding (CRUD) işlemleri
            //yapmayı sağalr
            /* Yapılan uygulamada select ile sütun belirtilmezse nesnenin kendisini getirir
            */

            List<Ogrenci> ogrenciler = new List<Ogrenci>()
            {
                new Ogrenci()
                {
                    name="Ali",
                    surname="Koksal",
                    age=40,
                 
                },
                new Ogrenci()
                {
                    name="Yusuf",
                    surname="Ergin",
                    age=50
                },
                new Ogrenci()
                {
                    name="Asım",
                    surname="Ergen",
                    age=18
                },
                new Ogrenci()
                {
                    name="Hamdi",
                    surname="Engin",
                    age=30
                },
                new Ogrenci()
                {
                    name="Orhan",
                    surname="Ergan",
                    age=45
                },
                new Ogrenci()
                {
                    name="Hasan",
                    surname="Erkin",
                    age=60
                }
            };

            //listedeki tüm nesnelerin name lerini bir listede toplayıp yazdırma

            /* List<string> ogrenci_sonuc = ogrenciler.Select(o => o.name).ToList();
             foreach (var item in ogrenci_sonuc)
             {
                 Console.WriteLine(item);
             }
            */
            //filtreleme yapalım bir de  where sorgusu ile
            /*var yas_buyuk_kirk_ = ogrenciler.Where(yas => yas.age > 40);
            foreach (var item in yas_buyuk_kirk_)
            {
                Console.WriteLine(item.name);
            }
            */

            //where sorgusu ile birlikte select kullanımı

            /*var yas_onsekizden_buyuk_isimleri = ogrenciler.Where(yas => yas.age > 18).Select(isim => isim.name);
            foreach (var item in yas_onsekizden_buyuk_isimleri)
            {
                Console.WriteLine(item);
            }
            */
            // FirstOrDefault koşula ilk uyan nesneyi getirir.
            /* var ogrenci = ogrenciler.Where(o => o.age > 40).FirstOrDefault();
             Console.WriteLine(ogrenci.name);
            */


            //endwith ve startwith kullanımı
            /* var h_ile_baslayan = ogrenciler.Where(ogrenci => ogrenci.name.StartsWith("H"));
             foreach (var item in h_ile_baslayan)
             {
                 Console.WriteLine(item.name);
             }

             var h_ile_baslayan_n_ile_biten = ogrenciler.Where(ogrenci => ogrenci.name.StartsWith("H")&& ogrenci.name.EndsWith("n"));
             foreach (var item in h_ile_baslayan_n_ile_biten)
             {
                 Console.WriteLine(item.name);
             }
            */

            //Distinct ifadesi ile tekrar sayısını teke düşürür ve değerler birbirinden 
            //farklı olur.

            /* List<int> sayilar = new List<int>() { 10, 20, 10, 30, 20, 40, };
             var farkli_sayilar = sayilar.Distinct();
             var farkli_sayilar_adet = sayilar.Distinct().Count();

             foreach (var item in farkli_sayilar)
             {
                 Console.WriteLine(item);
             }
             Console.WriteLine(farkli_sayilar_adet);//birbirinden farklı sayı adedi
            */

            //select ile verileri istenilen prop ile nesne olarak getirdik

            /*
              var ogrenci_listesi = ogrenciler.Select(ogrenci => new { ogrenci.name, ogrenci.age });
            */


            //OrderBy İLE SIRALAMA

            /*var siralama = ogrenciler.OrderBy(ogrenci => ogrenci.age);
            foreach (var item in siralama)
            {
                Console.WriteLine(item.age);
            }
            
            //bunlarda  da büyükten küçüğe doğru sıralar
            var siralama2 = ogrenciler.OrderBy(ogrenci => ogrenci.age).OrderDescending();
            var siralama3 = ogrenciler.OrderByDescending(ogrenci => ogrenci.age);
            */

            //inline olarak foreach kullanımı

            // ogrenciler.ForEach(ogrenci => Console.WriteLine(ogrenci.name));


            //UNİON İLE BİRLEŞTİRME.Aynı olanları tek yazar
            /*
             List<int> sayilar = new List<int>() { 10, 20, 10, 30, 20, 40,};
            List<int> sayilar2 = new List<int>() { 10, 20, 70, 30, 50};
            var karsilastir=sayilar.Union(sayilar2);
            */
           
        }
    }
}
