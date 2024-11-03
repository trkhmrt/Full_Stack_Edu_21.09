namespace _18_Constructor_Method;

class Program
{
    static void Main(string[] args)
    {
        /*
         Constructor(Yapıcı Method)
         
         Nesne üretildiği anda çalışır.
         
         Constructor metod class içinde tanımlanmamışsa default olarak içi boş çağrılır ve çalışır.
         
         
         Bu classla alakalı gerekli configler varsa bunların herşeyden önce tamamlanmasını sağlar.
         
         class Ogrenci
         { 
         
         public Ogrenci()
         {
         
         }
         
         
         }
         
         */


        Ogrenci ogrenci = new Ogrenci("192.168.1.1");
        
        ogrenci.OgrenciEkle();
        ogrenci.OgrenciSil();
        ogrenci.OgrenciGuncelle();
        
        //Ogrenci ogrenci1 = new Ogrenci("192.168.2.1");
        // Ogrenci ogrenci2 = new Ogrenci("Tarık");
        // Ogrenci ogrenci3 = new Ogrenci("Tarık","Hamarat");
        //
        
       
        
    }

    class Ogrenci
    {
        private string VeriTabani = "";    
       

        public Ogrenci(string ip)
        {
            VeriTabani = ip;
        }

        
        public void OgrenciEkle()
        {
            Console.WriteLine(VeriTabani);
        }
        public void OgrenciSil()
        {
            Console.WriteLine(VeriTabani);
        }
        public void OgrenciGuncelle()
        {
            Console.WriteLine(VeriTabani);
        }
        
        
        // public Ogrenci(string MssqlBaglantiAyarlari)
        // {
        //     this.MssqlBaglantiAyarlari = MssqlBaglantiAyarlari;
        //     
        //     Console.WriteLine(this.MssqlBaglantiAyarlari);
        //     
        // }
        

        // public Ogrenci(string isim)
        // {
        //     Console.WriteLine(isim);
        // }
        //
        // public Ogrenci(string isim,string soyisim)
        // {
        //     Console.WriteLine( isim + " " + soyisim);
        // }
        
        //Yorum Satırı
        
        
        
        
        
        
    }
    
}