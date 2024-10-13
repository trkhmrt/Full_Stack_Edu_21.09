namespace _08_Arrays;

class Program
{
    static void Main(string[] args)
    {
        /*
         Diziler
         
         Bir veya birden fazla veriyi içerisinde veri tipi gözeterek saklar.
         
         Elemanları indeks mantığı ile sıralar.
         
         Kendisine ait birtakım metotlar bulunur.
         
         */
        
        /* DİZİ TANIMLAMA */
        
        //1.Yöntem
        
        // int[] sayilar = new int[5];
        // string[] isimler = new string[10];
        //
        // //2.Yöntem
        //
        // int[] sayilar2 = { 90 , 3, 5, 10 };
        // string[] isimler2 = { "Tarık", "Esra", "Duhan", "Yusuf", "Hamdi" ,"Alper"};
        
        /*  DİZİ ELEMANLARINA ERİŞİM   */
           
        //string[] isimler2 = { "Tarık", "Esra", "Duhan", "Yusuf", "Hamdi" ,"Alper" ,"Ömer","Tuna" };

        // Console.WriteLine(isimler2[0]);
        // Console.WriteLine(isimler2[1]);
        // Console.WriteLine(isimler2[2]);
        // Console.WriteLine(isimler2[3]);
        // Console.WriteLine(isimler2[4]);
        // Console.WriteLine(isimler2[5]);
        // Console.WriteLine(isimler2[6]);
        // Console.WriteLine(isimler2[7]);
        // Console.WriteLine(isimler2[8]);

        // for (int i = 0; i < 9; i++)
        // {
        //     Console.WriteLine(isimler2[9]);
        // }
        
        //Dizilerin uzunluğunu alma
        
       // int dizi_uzunlugu = isimler2.Length;
        
        // for(int i = 0; i < isimler2.Length; i++)
        // {
        //     Console.WriteLine(isimler2[i]);
        // }
        
        
        
        //ilk eleman
        //Console.WriteLine(isimler2[0]);
        //son eleman
        //Console.WriteLine(isimler2[isimler2.Length - 1]);
        
        //FOREACH DÖNGÜSÜ//
        
        /*
        foreach (string isim in isimler2)
        {
            Console.WriteLine(isim);
        }
        */
        
        //DİZİ METOTLARI

        //string[] meyveler = { "Elma", "Armut", "Kiraz", "Muz" };
        
        //Dizi uzunluğu
        //Console.WriteLine(meyveler.Length);
        
        //Dizi elemanı indeks değerini bulma
        //indexOf()

        //Console.WriteLine(Array.IndexOf(meyveler,"Kiraz"));

        
        //Elemanları küçükten büyüğe sıralar.
        //Array.Sort()
        // int[] yaslar = { 27, 65, 19, 90, 45 };
        // Array.Sort(yaslar);
        // foreach (var yas in yaslar)
        // {
        //     Console.WriteLine(yas);
        // }
        
        //STRING İFADELERDE ALFABETİK SIRAYA GÖRE SIRALAR.
        // Array.Sort(meyveler);
        // foreach (var meyve in meyveler)
        // {
        //     Console.WriteLine(meyve);
        // }
        
        /*  ELEMANLARI TERS ÇEVİRME   */
        
        // int[] yaslar = { 27, 65, 19, 90, 45 };
        // Console.WriteLine(Array.IndexOf(yaslar, 45));
        // Array.Reverse(yaslar);
        // foreach (var item in yaslar)
        // {
        //     Console.WriteLine(item);
        // }
        // Console.WriteLine(Array.IndexOf(yaslar, 45));
        

        //ÖRNEK-Büyükten küçüğe göre sıralamayıda siz yapın.
        
        // int[] sayi_kumesi = {80,10,70,5,90,23,45,12,77,-10};
        //
        // Array.Sort(sayi_kumesi);

        // foreach (var item in sayi_kumesi)
        // {
        //     Console.WriteLine(item);
        // }
        
        // Array.Reverse(sayi_kumesi);
        //
        // foreach (var item in sayi_kumesi)
        // {
        //     Console.WriteLine(item);
        // }
        
        
        //DİZİYE ELEMAN EKLEME
        
        //int[] sayilar = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

        //Console.WriteLine($"Dizinin ilk uzunluğu:{sayilar.Length}");
        
        //Dizinin uzunluğu 10 dan 11 e çıkarıldı.
        //Array.Resize(ref sayilar,13);
        
        //Console.WriteLine($"Dizinin Resizdan sonraki uzunluğu:{sayilar.Length}");
        
        //Sistem tarafından 0 atandı son elemana 
        //Console.WriteLine($"Son indeksdeki elemanı:{sayilar[sayilar.Length-1]}");
      
        //Dizi elemanları döngüyle döndürüldü ve eklenen yeni eleman görüntülendi.
        // foreach (var item in sayilar)
        // {
        //     Console.WriteLine(item);
        // }
        
        
        
        //DİNAMİK OLARAK DİZİYE ELEMAN EKLEME
        
        //TEK TEK ELEMAN EKLEME
        // string[] isimler = { "Tarık", "Duhan", "Hamdi" };
        //
        // while (true)
        // {
        //     foreach (string item in isimler)
        //     {
        //         Console.WriteLine(item);
        //     }
        //     
        //     
        //     Console.WriteLine("İsim giriniz");
        //     
        //     string isim = Console.ReadLine();
        //     
        //     
        //     Array.Resize(ref isimler, isimler.Length + 1);
        //
        //     isimler[isimler.Length - 1] = isim;
        //     Console.Clear();
        //     
        // }
        //
        //TOPLU ELEMAN EKLEME
        // string[] isimler = { "Tarık", "Duhan", "Hamdi"};
        // string[] eklenecek_isimler = { "Esra", "Ömer", "Tuna", "Alper" };
        //
        //
        // for (int i = 0; i < eklenecek_isimler.Length; i++)
        // {
        //     Array.Resize(ref isimler, isimler.Length + 1);
        //
        //     isimler[isimler.Length - 1]=eklenecek_isimler[i];
        //     
        // }
        //
        // foreach (var item in isimler)
        // {
        //     Console.WriteLine(item);
        // }

        //CLEAR
        // int[] sayilar = {1,2,3,4,5,6,7,8,9,10};
        //
        // Array.Clear(sayilar,1,1);
        // foreach (var item in sayilar)
        // {
        //     Console.WriteLine(item);
        // }

        // string[] yeni_arabalar = { "Ferrari", "Fiat", "Toyota" ,"Mazda"};
        //
        // string[] galerim = { "BMW" ,"Mercedes","Renault" };

        // foreach (var item in arabalar2)
        // {
        //     Console.WriteLine(item);
        // }
        
        //Array.Copy(arabalar,arabalar2,3);

        // foreach (var item in arabalar2)
        // {
        //     Console.WriteLine(item);
        // }
        // Console.WriteLine("ATAMADAN ÖNCEKİ ADRESLERİ");
        // Console.WriteLine($"Galerim dizisi Referans adresi:{galerim.GetHashCode().ToString()}");
        // Console.WriteLine($"Yeni_arabalar dizisi Referans adresi:{yeni_arabalar.GetHashCode().ToString()}");
        // Console.WriteLine(yeni_arabalar.GetHashCode().ToString());
        // Console.WriteLine("-----------------------------------------------------");
        // galerim = yeni_arabalar;
        // Console.WriteLine("-----------------------------------------------------");
        // Console.WriteLine("ATAMADAN SONRAKİ ADRESLERİ");
        // Console.WriteLine($"Galerim dizisi Referans adresi:{galerim.GetHashCode().ToString()}");
        // Console.WriteLine($"Yeni_arabalar dizisi Referans adresi:{yeni_arabalar.GetHashCode().ToString()}");
        // foreach (var item in galerim)
        // {
        //     Console.WriteLine(item);
        // }
        
        
        
        // galerim[0] = "ARAÇ YOK";
        // Console.WriteLine(galerim[0]);
        // Console.WriteLine(yeni_arabalar[0]);
        //
        // yeni_arabalar[0] = "FERRARİ";
        // Console.WriteLine(galerim[0]);
        // Console.WriteLine(yeni_arabalar[0]);
        //

        
        
        /*
         Kullanıcıya öncelikle depoya ekleyeceği ürün adedini sorun.Bu ürünleri ekleme işlemini yaptıktan sonra işleme devam edecek misiniz sorusunu kullanıcıya yöneltin cevaba göre uygulamayı sonlandırın yada devam ettirin.
         
         Deponun önceki hali ve ekleme yapıldıktan sonraki halini ekrana yazdırın.
         */
        
        //SORU SÜRE BİTİŞ : 12:40

        // string[] urunler = {  };
        // while (true)
        // {
        //     foreach (var item in urunler)
        //     {
        //         Console.WriteLine(item);
        //     }
        //     Console.WriteLine("Kaç adet ürün eklemek istiyorsunuz");
        //     int adet = Convert.ToInt32(Console.ReadLine());
        //     for (int i = 0; i < adet; i++)
        //     {
        //         Array.Resize(ref urunler,urunler.Length + 1);
        //         
        //         Console.WriteLine("Ürün adını giriniz");
        //         string urun_ad = Console.ReadLine();
        //         
        //         urunler[urunler.Length - 1] = urun_ad;
        //     }
        //     Console.WriteLine("İşleme devam etmek istiyor musunuz  E/H");
        //     string cevap = Console.ReadLine().ToLower();
        //
        //     if (cevap == "e")
        //     {
        //         continue;
        //     }
        //     else
        //     {
        //         break;
        //     }
        // }
        //
        // Console.WriteLine("Uygulama sonlandı.");
        Console.WriteLine("New");
        Console.WriteLine("New");
        Console.WriteLine("New");
        











    }
}