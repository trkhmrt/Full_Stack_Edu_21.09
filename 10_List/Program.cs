namespace _10_List;

class Program
{
    static void Main(string[] args)
    {
       /*
        LİST
        
        Koleksiyon yapılarıdır.
        Elemanların dizilimi Diziler  gibi indeks mantığına sahiptir.
        Daha esnektir.
        Tanımlanırken eleman sayısı belirtme zorunluluğu yoktur.  
        Classlarıda veri tipi olarak kullanabilirler.   
        Dizilere daha fazla yardımcı metotları vardır.
           
        */
       //Dizi
       //int[] sayilar = new int[5];
       
       //Liste Tanımlama Yöntemi 
       //Yöntem 1
       // List<string> list = new List<string>()
       // {
       //     "Tarık","Duhan"
       // };
       
       //Yöntem 2
       // List<string>  herhangi_liste = new List<string>();
       
       //Yöntem 3
       // string[] herhangi_dizi = { "Tarık", "Hamarat" };
       // List<string>  herhangi_liste2 = new List<string>(herhangi_dizi);
       // foreach (var item in herhangi_liste2)
       // {
       //     Console.WriteLine(item);
       // }
       
       //Capacity ile listenin ihtyiaç duyduğu alan ayrılır.Fazla eleman eklenmek isteniyorsa add ile sorunsuz bir şekilkde eklenebilir.
       // List<int> yaslar = new List<int>(10);
       // yaslar.Add(20);
       // yaslar.Add(20);
       // yaslar.Add(20);
       // yaslar.Add(20);
       // yaslar.Add(20);
       // yaslar.Add(20);
       //
       // foreach (var item in yaslar)
       // {
       //     Console.WriteLine(item);
       // }
       

       //Add (Listeye eleman ekleme)
       // List<int> numbers = new List<int>();
       //
       // numbers.Add(3);
       // numbers.Add(10);
       // numbers.Add(20);
       // numbers.Add(500);

       //AddRange ile birlikte toplu eleman ekleme
       // numbers.AddRange(new List<int>(){400,800,1000});
       //
       // foreach (var item in numbers)
       // {
       //     Console.WriteLine(item);
       // }

       //Foreach ile elemanları yazdırma
       // foreach (var item in numbers)
       // {
       //     Console.WriteLine(item);
       // }
       //
       //Remove ile eleman silme
       // bool kontrol = numbers.Remove(400);
       //
       // foreach (var item in numbers)
       // {
       //     Console.WriteLine(item);
       // }

       //RemoveAt ile belirtilen indeksdeki elemanı silme
       // numbers.RemoveAt(0);
       // foreach (var item in numbers)
       // {
       //     Console.WriteLine(item);
       // }

       //RemoveAll ile birlikte belirli koşulu sağlayan elemanlar silinir.
       // numbers.RemoveAll(n => n % 2 == 0);
       //
       // foreach (var item in numbers)
       // {
       //     Console.WriteLine(item);
       // }


       //Count ile eleman sayısı
       //Console.WriteLine(numbers.Count());


       //Contains ile bu liste verilen elemanı içeriyormu
       // if (numbers.Contains(70))
       // {
       //     Console.WriteLine("Evet sayı liste içerisinde bulunuyor.");
       // }
       // else
       // {
       //     Console.WriteLine("Sayı liste içerisinde bulunmuyor.");
       // }


       //Clear ile birlikte liste elemanlarının tamamını temizledik.
       // numbers.Clear();
       //
       // foreach (var item in numbers)
       // {
       //     Console.WriteLine(item);
       // }


       //Insert ile birlikte istenen indekse eleman ekleme
       // numbers.Insert(0,30);
       //
       // foreach (var item in numbers)
       // {
       //     Console.WriteLine(item);
       // }


       //IndexOf ile birlikte parametre olarak verilen elemanın indeks numarasını bulma
       //Console.WriteLine(numbers.IndexOf(3));



       //Find belirli bir koşul karşılığında eleman getirir.Aşağıda sayı 10 ise o sayıyı getir bana dedim.Eğer bu sayı yoksa geriye sıfır döner
       //Console.WriteLine(numbers.Find(n => n == 10));


       //FindAll ile eleman bulma.Koşula uyan elemanları kendisi bir listeye taşır.Bu listeyide istenilen herhangi bir liste içerisine aktarabilirsiniz.
       // List<int> list = numbers.FindAll(n => n % 2 == 0);
       //
       // foreach (var item in list)
       // {
       //     Console.WriteLine(item);
       // }



       //Slice metodu ile belirtilen indeksten itibaren listeyi bölme
       //Verilen startdaki indeks dahil olmak üzere başlangıç indeksinden itibaren verilen uzunluk adedince eleman toplar ve metot sonlanır.(NOT! Başlangıç indekside dahildir toplam uzunluğa.)
       // List<string> names = new List<string>();
       // names.Add("Tarık");
       // names.Add("Ömer");
       // names.Add("Duhan");
       // names.Add("Esra");
       // names.Add("Hamdi");
       // names.Add("Yusuf");
       // names.Add("Alper");
       // names.Add("Tuna");
       //
       // foreach (string name in  names.Slice(2,4))
       // {
       //     Console.WriteLine(name);
       // }
       
       
       //Max liste içerisindeki en büyük değeri yazdırır.
       // List<int> en_buyuk= new List<int>(){10,40,25,80};
       //
       // Console.WriteLine(en_buyuk.Max());
      
       //Min liste içerisindeki en küçük değeri yazdırır.
       // List<int> en_kucuk= new List<int>(){10,40,25,80};
       //
       // Console.WriteLine(en_kucuk.Min());

       //Average listenin ortalamasını verir.
       // List<int> ortalama= new List<int>(){10,20};
       // Console.WriteLine(ortalama.Average());
        
       
        
       
       
       







    }
}