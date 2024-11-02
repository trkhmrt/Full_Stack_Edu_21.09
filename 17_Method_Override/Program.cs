using Microsoft.EntityFrameworkCore;

namespace _17_Method_Overloading;

class Program
{
    static void Main(string[] args)
    {
        Ogrenci ogrenci = new Ogrenci();
        Hoca hoca = new Hoca();

        ogrenci.OpenDatabase("192.168.99.100");
        //ogrenci.Ekle();
        hoca.Ekle();
    }

    class VeriTabanı:DbContext
    {
        
        protected override void OnConfiguring(DbContextOptionsBuilder b)
        {
          
        }
        
        public virtual void OpenDatabase(string ip)
        {
           
        }
        
    }


  
    
    class SistemKayitNesnesi:DbContext
    {
        private string isim { get; set; }
        public string soyisim { get; set; }
        public string TC { get; set; }
        public string DogumTarihi { get; set; }
        public string VeriTabaninaKayitTarihi { get; set; }

        public virtual void Ekle()
        {
            Console.WriteLine("Sistem Kayıt Nesnesi Ekleme Metodu");
        }


        
    }
    
    class Ogrenci : VeriTabanı 
    {
        public string aldigi_ders_sayisi { get; set; }
        
        // public override void Ekle()
        // {
        //     Console.WriteLine("Öğrenci Ekleme Metodu");
        // }

        public override void OpenDatabase(string ip)
        {
            Console.WriteLine(ip);
        }
    }
    
    class Hoca : SistemKayitNesnesi
    {
        public string verdigi_ders_sayisi { get; set; }
        
        public override void Ekle()
        {
            Console.WriteLine("Hoca Ekleme Metodu");
        }
    }
}