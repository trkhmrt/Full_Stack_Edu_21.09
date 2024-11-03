namespace _18_Constructure_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             bu methodlar nesne oluştuğu anda herşeyden önce çalışacaktır.
             Constructure metod tanımlanmaışsa default olarak oluşturulur ve çalışır
             */
            Ogrenci ogrenci = new Ogrenci(); //parametresiz metod çalışır
            Ogrenci ogrenci2 = new Ogrenci("yusuf"); //string isim alan metod çalışır
        }

        public class Ogrenci
        {         
            public Ogrenci()
            {
                Console.WriteLine("Constructure Çalıştı");
            }

            public Ogrenci(string isim)
            {
                Console.WriteLine($"{isim} String isim alan Constructure Çalıştı");
            }
        }
    }
}
