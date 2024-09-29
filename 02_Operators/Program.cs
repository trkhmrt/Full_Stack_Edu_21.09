namespace _02_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             Snippet
            Temelde kullanılan kodların kısa yolla ekrana getirilmesi

            cw ->  Console.WriteLine();
            for 
            foreach

             */


            /*   OPERATORS
             
            Aritmatik operatörler


            int yas1 = 10  int yas2 = 10


            Toplama

             yas1 +  yas2

            Çıkarma

             yas1 -  yas2

            Çarpma

            yas1 *  yas2

            Bölme

            yas1 / yas2

            Kalan

            yas1 % yas2



             */



            //int sayi1 = 40;
            //int sayi2 = 20;

            //Console.WriteLine("Sayi1 10");
            //Console.WriteLine("Sayi1 5");
            //Console.WriteLine("Sayi1 9");

            //Console.WriteLine("Sayi1 "+sayi1);






            // int toplam = sayi1 + sayi2;

            //Console.WriteLine(sayi1+sayi2);
            //Console.WriteLine(sayi1-sayi2);
            //Console.WriteLine(sayi1*sayi2);
            //Console.WriteLine(sayi1/sayi2);
            //Console.WriteLine(sayi1%sayi2);

            //3 Adet değişken tanımlanıp bunların toplamları ekrana çıktı olarak verilsin.

            //sayi1 = 23;
            //sayi2 = 30;
            //sayi3 yukarıda tanımlanmadığı için bu satırda ilk defa tanımlandı.
            //int sayi3 = 50;

            //int toplam= sayi1 + sayi2 + sayi3;

            //Console.WriteLine(toplam);




            //VERİ TİPİ ÖĞRENME

            //short yas = 13;

            //Console.WriteLine(yas.GetType().FullName);

            //Console.WriteLine(toplam.GetType().FullName);

            //long mesafe = 100000000000000000;

            //Console.WriteLine(mesafe.GetType().FullName);

            //ulong mesafe2 = 10000000000000000000;


            //Console.WriteLine(mesafe2.GetType().FullName);


            //string isim = "TarıkHAMARAT";

            //Console.WriteLine(isim.GetType().Name);







            //Comparasion Operators(Karşılaştırma Operatörleri)



            //int sayi1 = 20;
            //int sayi2 = 20;

            //Console.WriteLine(sayi1>sayi2);

            //Console.WriteLine(sayi1 < sayi2);

            //Console.WriteLine(sayi1==sayi2);

            //Console.WriteLine(sayi1 >= sayi2);

            //Console.WriteLine(sayi1 <= sayi2);

            //Console.WriteLine(sayi1 != sayi2);


            /*
             LOGICAL OPERATORS(Mantıksal Operatörler)
             
             AND OR


            AND BAĞLACI ( && )
            (önermeler arasında çarpma işlemi vardır)

            Senaryo : Bir kullanıcı sistemde login olmaya çalışıyor.

            Email && Şifre  Durum
              1       1      1    
              1       0      0
              0       1      0
              0       0      0


            Veya BAĞLACI  ( || )
            (önermeler arasında toplama işlemi vardır)

            Senaryo : Bir kullanıcı sistemde login olmaya çalışıyor.

           ( Email  ||  Telefon || Username ) && Şifre Durum
              1           0           0            1     1
              0           0           1            0     0
              0           0           0            1     0    
              
             
             */

            //NOT C# dilinde büyük küçük harf duyarlılığı( case sensitivity ) vardır.

            //string username = "trkhmrt";
            //string email = "mail";
            //string sifre = "123";
            //string telefon = "555";

            //Console.WriteLine(username=="trkhmrt" && sifre=="123");

            //Console.WriteLine((username == "trkhmrt" || email=="" || telefon=="" ) && sifre == "123");


            //Kullanıcıdan Veri Alma I/O   Input(Console.ReadLine)   Output(Console.WriteLine) 

            //string isim = Console.ReadLine();


            //Console.WriteLine("Konsol çıktısı:"+isim);


            //NOT -> Klavyeden girilen değer her zaman string veri tipindedir.Farklı aktarmak için çevirme işlemi yapılmalı

            //Console.WriteLine("Soy isim giriniz");
            //string soyisim= Console.ReadLine();
            //Console.WriteLine(soyisim.GetType().Name);

            //Console.WriteLine("Yaş giriniz");
            //int yas= Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(yas.GetType().Name);

            //Console.WriteLine("Kilo giriniz");
            //double kilo=Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine(kilo.GetType().Name);

            //Console.WriteLine("Bool ifade giriniz");
            //bool kontrol= Convert.ToBoolean(Console.ReadLine());
            //Console.WriteLine(kontrol.GetType().Name);


            //Klavyeden okunana kullanıcı adı ve şifreyi tanımlamış olduğunuz(kullaniciadi ve sifre) değişkenlerleriyle karşılaştırın ve bu karşılaştırma sonucunu ekrana yazdırın.


            //string username = "trkhmrt";
            //string sifre = "123";

            //Console.WriteLine("Kullanıcı adını giriniz:");
            //string uname=Console.ReadLine();
            //Console.WriteLine("Şifre giriniz:");
            //string sfr = Console.ReadLine();

            //Console.WriteLine(username==uname && sifre==sfr);



            /*Console WriteLine ve Console Write Farkı*/

            //Console.WriteLine("Merhaba Dünya");
            //Console.WriteLine("Benim adım Tarık");

            //Console.WriteLine("Yaş giriniz:");
            //Console.ReadLine();

            //Console.Write("Yaş giriniz:");
            //Console.ReadLine();


            /*Kaçış operatörleri 
             * 
             * 
             * \n -> new line
             * 
             * \t  -> tab
             * 
             
             */

            // Console.WriteLine("Tarık\nHamarat");

            //Console.Write("Tarık\n");
            //Console.Write("Hamarat");


            //Console.Write("Tarık");
            //Console.Write("\nHamarat");



            /* $ ile Console writeLine */

            //int yas = 20;

            //Console.WriteLine("Kişinin Yaşı\t"+yas);

            //string isim = "Tarık";
            //string soyisim = "Hamarat";
            //string adres = "Dünyanın en güzel yeri";
            //double tutar = 450.80;



            //Console.WriteLine("Sayın:"+isim+" "+soyisim+" "+tutar+" tutarlı alışverişiniz "+adres+" adresinize gönderilecektir.");

            // Console.WriteLine($"Sayın:{isim} {soyisim} {tutar} tutarlı alışverişiniz {adres} adresinize gönderilecektir.");

            //Console.WriteLine(string.Format("Sayın:{0} {1} tutarlı alışverişiniz adresinize gönderilecektir.",isim,soyisim));


            //NOT STRİNG ifadelerde + işareti metinleri  birleştirmek için kullanılır.





            //ARTTIRMALI/AZALTMALI ATAMA OPERATÖRÜ


            //int sayi = 20;

            //Console.WriteLine(sayi);

            //sayi = sayi + 10;

            //Console.WriteLine(sayi);

            //sayi = sayi - 10;

            //Console.WriteLine(sayi);

            //Kısa yolu

            //int sayi2 = 40;

            //sayi2 += 10;
            //sayi2 -=10;
            //Console.WriteLine(sayi2);


            //Bir arttırma bir azaltma

           // int sayi3 = 60;

           // Console.WriteLine("Sayi3'ün ilk değeri" + sayi3);

           // int test1 = sayi3++;

           // Console.WriteLine("Test 1'in içerisine sayi3 atandı sonra sayi3 1 arttırıldı->"+test1);
           // Console.WriteLine("Test 1'in o an ki değeri üzerine 4 eklendi->"+(test1+4));
           // Console.WriteLine("Sayi3 önce test1 e atanıp sonra arttırıldı.Burada üzerine 4 Ekledik"+(sayi3+4));


           //int test2 = ++sayi3;

           // Console.WriteLine("BU işlemde sayi3 önce bir arttırıldı daha sonra test2 ye atandı->"+test2);


         



        }
    }
}
