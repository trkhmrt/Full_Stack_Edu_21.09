namespace _16_Inheritance;

class Program
{
    static void Main(string[] args)
    {
        /*
         Miras Alma 
         
         base class'da tanımlanan herhangi bir özelliğin alt classlara uygulanması yöntemi 
        
        ÖNEMLİ -> Her class sadece tek bir class'ı miras alabilir.
        
         */
        // Hoca hoca = new Hoca();
        // hoca.Ekle();
        //
        VeriTabaniIpAdress ipAdress = new VeriTabaniIpAdress();
        
        Ogrenci ogrenci = new Ogrenci();
        ogrenci.Ekle(ipAdress);
        
        Hoca hoca = new Hoca();
        hoca.Ekle(ipAdress);
        
        
        //Yanlış kullanım
        //SistemKayitNesnesi ogrenci2 = new Ogrenci();
        //Ogrenci ogrenci3 = new SistemKayitNesnesi();
    }

    class  SistemKayitNesnesi
    {
        private string isim { get; set; }
        public string soyisim { get; set; }
        public string TC { get; set; }
        public string DogumTarihi { get; set; }
        public string VeriTabaninaKayitTarihi { get; set; }

        public virtual void Ekle(VeriTabaniIpAdress veriTabaniIpAdress)
        {
           // Console.WriteLine("Sistem Kayıt Nesnesi Ekleme Metodu");
        }
    }

    class VeriTabaniIpAdress
    {
        private string ip { get; set; }

        public void IpAdresi_Goster(string ip_adress)
        {
             ip = ip_adress;
             
           Console.WriteLine(ip);
        }
    }
    
    
    class Ogrenci : SistemKayitNesnesi
    {
        public string aldigi_ders_sayisi { get; set; }
     
        
        public override void Ekle(VeriTabaniIpAdress veriTabaniIpAdress)
        {
           veriTabaniIpAdress.IpAdresi_Goster("192.168.10.10 Öğrenci");
        }

    }
    
    class Hoca : SistemKayitNesnesi
    {
        public string verdigi_ders_sayisi { get; set; }
        
        public override void Ekle(VeriTabaniIpAdress veriTabaniIpAdress)
        {
            veriTabaniIpAdress.IpAdresi_Goster("192.168.20.20 Hoca");
        }
    }
    
  
    
}