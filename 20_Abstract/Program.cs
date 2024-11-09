namespace _20_Abstract;

class Program
{
    static void Main(string[] args)
    {
        /*
        ABSTRACT(Soyut) VE CONCRETE(Somut)
        
        Abstract Metot -> Sadece imza kısmı olan metot 
        
        void KareAl();
       
       Concrete Metot -> Gövde kısmı bulunan metotlar
        
        Abstract yapılar -> Abstract class ve Interface
        
        Soyut sınıfların genel amacı ;
        
        Kod tekrarını azaltma
        
        Bakım ve Test kolaylığı
        
        
        ABSTRACT CLASS
        
        -Eğer bir metot miras alan class içerisinde kullanılması zorunlu bırakılmak isteniyorsa abstract eki alarak gövdesiz şekilde tanımlanmalı.
        
        -Bir classın içinde abstract(gövdesiz metot) yapı kullanılacaksa classın türünün abstract class olması gerekir.
        
        -Abstract classlar içerisinde somut ve soyut yapılar birlikte bulunabilir.
        
        -Her bir class sadece bir tane abstract class'ı miras alabiliri.
        
        -Abstract classlardan nesne oluşturulmaz.
        
        -İmplement edilmesi Zorunlu yada zorunlu olmayan yapılar bir arada tanımlanabilir.
         */

        //Abstract class newlenemez.
        //AracService service = new AracService();

       // Deneme deneme = new Deneme();
        string mesaj =  ApiMesaj.mesaj;
        Console.WriteLine(mesaj);
        
        //11:10 MOLA BİTİŞ





    }
    
    public abstract class AracService
    {
        
        public abstract void Create();
        public abstract void Delete();
        public abstract void Update();

        public abstract void GetAll();

        public  void GetAllColor()
        {
            
        }

        public abstract void getColor();

    }
    
    
     class Sedan : AracService
    {
       
        
        public override void Create()
        {
            Console.WriteLine("Sedan araç eklendi");
        }

        public override void Delete()
        {
            Console.WriteLine("Sedan araç silindi");
        }

        public override void Update()
        {
            Console.WriteLine("Sedan araç güncellendi");
        }

        public override void GetAll()
        {
            throw new NotImplementedException();
        }

        public override void getColor()
        {
            throw new NotImplementedException();
        }
    }
    public class Suv : AracService
    {
        
        
        public override void Create()
        {
            Console.WriteLine("Sedan araç eklendi");
        }

        public override void Delete()
        {
            Console.WriteLine("Sedan araç silindi");
        }

        public override void Update()
        {
            Console.WriteLine("Sedan araç güncellendi");
        }

        public override void GetAll()
        {
            throw new NotImplementedException();
        }

        public override void getColor()
        {
            throw new NotImplementedException();
        }
    }
    
}