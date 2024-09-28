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


            string username = "trkhmrt";
            string sifre = "123";

            Console.WriteLine("Kullanıcı adını giriniz:");
            string uname=Console.ReadLine();
            Console.WriteLine("Şifre giriniz:");
            string sfr = Console.ReadLine();

            Console.WriteLine(username==uname && sifre==sfr);


        }
    }
}
