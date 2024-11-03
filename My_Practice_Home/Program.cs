using My_Practice_Home.Models;

namespace My_Practice_Home
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Personel>Personeller = new List<Personel>();
            Personel personel= new Personel();
       
        foreach(Personel item in Personeller)
            {
                Console.WriteLine(item.id+" "+item.isim+" "+item.soyisim);
            }
        }
    }
}
