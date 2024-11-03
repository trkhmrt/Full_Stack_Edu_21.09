using System.Net;

namespace _17_Metod_Override
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Veritabaniİpadres ipadres=new Veritabaniİpadres();
            Ogrenci ogrenci=new Ogrenci();
            Hoca hoca = new Hoca();
            ogrenci.Ekle(ipadres);
            hoca.Ekle(ipadres);

        }

        class SistemKayitNesnesi  //abstract(en başa) bu class ta nesne oluşturmayı 
            //engeller
        {
            public string isim { get; set; }
            public string soyisim { get; set; }
            public string DogumTarihi { get; set; }
            public string VeriTabaniKayitTarihi { get; set; }
            public string TC { get; set; }

            public virtual void Ekle(Veritabaniİpadres veritabaniipadres)
            {
                //Console.WriteLine("Kayıt Eklendi");
            }


        }
        class Veritabaniİpadres
        {
            private string ip { get; set; }

            public void ip_adres_goster(string ip_address)
            {
                ip = ip_address;
                Console.WriteLine(ip);
            }


        }
        class Ogrenci : SistemKayitNesnesi    //SistemKayitNesnesinden miras alacak propları
        {
            public string AldigiDersSayisi { get; set; }  //Bu sadece öğrenciye özel prop
            private string ip_adres = "localhost";
            public override void Ekle(Veritabaniİpadres veritabaniipadres)
            {
                veritabaniipadres.ip_adres_goster("192.168.1.10");
            }
        }
        

        class Hoca : SistemKayitNesnesi
        {
            public string VerdigiDersSayisi { get; set; }
            public override void Ekle(Veritabaniİpadres veritabaniipadres)
            {
                veritabaniipadres.ip_adres_goster("192.168.1.11");
            }

        }

    }
}
