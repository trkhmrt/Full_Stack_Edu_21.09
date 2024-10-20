namespace _09_Metot_Overloading;

class Program
{
    static void Main(string[] args)
    {
        //METOT OVERLOADING
        /*
         Aynı isimli metodun farklı parameterlerle işlemlerini gerçekleştirmesi
         */
        /*
         METOT İMZASI
         
         1-METODUN İSMİ  
         2-METODUN PARAMETRE SAYISI 
         3-PARAMETRELERİN VERİ TİPİ
         4-Geri dönüş tipi
         
         
         */

       EkranaYaz("Merhaba Dünya Bu mesaj ekrana yazılacak"); 
       EkranaYaz(10.2);
       EkranaYaz(10);
       EkranaYaz(10, 20);

    }

    static void EkranaYaz(string mesaj)
    {
        Console.WriteLine(mesaj);
    }
    static void EkranaYaz(double sayi)
    {
        Console.WriteLine(sayi);
    }
    static void EkranaYaz(int sayi)
    {
        Console.WriteLine(sayi);
    }
    static void EkranaYaz(int sayi1,int sayi2)
    {
        Console.WriteLine($"Sayi1:{sayi1} Sayi2:{sayi2}");
    }
    static void EkranaYaz(int sayi1,string mesaj)
    {
        Console.WriteLine($"Sayi1:{sayi1} Mesaj:{mesaj}");
    }
    static string EkranaYaz(int sayi1,string mesaj,double double_sayi)
    {
        return ($"Sayi1:{sayi1} Mesaj:{mesaj}");
    }
    
}

