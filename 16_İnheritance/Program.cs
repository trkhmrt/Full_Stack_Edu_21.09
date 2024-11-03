namespace _16_İnheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
            Miras Alma, base class ta tanımlanan bir özelliğin alt classlara uygulanması
            
            Her classs sadece bir yerden miras alabilir
             */

            Ogrenci ogrenci= new Ogrenci();
            Hoca hoca= new Hoca();
            hoca.Ekle();
            SistemKayitNesnesi nesne = new Ogrenci();// bu mümkün ama mantıksız
            
            //Ogrenci nesne2 = new SistemKayitNesnesi();   bu kullanılamaz
        }


        class SistemKayitNesnesi  //abstract bu class ta nesne oluşturmayı engeller
        {
            public string isim { get; set; }
            public string soyisim { get; set; }
            public string DogumTarihi { get; set; }
            public string VeriTabaniKayitTarihi { get; set; }
            public string TC { get; set; }

            public void Ekle()
            {
                Console.WriteLine("Kayıt Eklendi");
            }
            

        }
        class Ogrenci : SistemKayitNesnesi    //SistemKayitNesnesinden miras alacak propları
        {
            public string AldigiDersSayisi { get; set; }  //Bu sadece öğrenciye özel prop
        }

        class Hoca : SistemKayitNesnesi
        {
            public string VerdigiDersSayisi { get; set; }
           
        }
       

    }
}
