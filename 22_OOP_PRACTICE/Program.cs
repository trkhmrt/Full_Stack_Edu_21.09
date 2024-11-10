using _22_OOP_PRACTICE.Context;
using _22_OOP_PRACTICE.entities;
using _22_OOP_PRACTICE.services;
using Microsoft.Data.Sqlite;

namespace _22_OOP_PRACTICE;

class Program
{
    static void Main(string[] args)
    {
        OgrenciService ogrenciService = new OgrenciService();

        while (true)
        {
            Console.WriteLine("Uygulamaya hoşgeldiniz");
            Console.WriteLine("İşleme seçiniz 1-Ogrenci Kayıt 2-Öğrenci Listesi");
            int secim = Convert.ToInt32(Console.ReadLine());
            if (secim == 1)
            {
                Console.WriteLine("Öğrenci Kayıt Ekranına Hoşgeldiniz");
                ogrenciService.AddOgrenci();
            }
            else if (secim == 2)
            {
                
                foreach (var item in ogrenciService.GetAllOgrenci())
                {
                    Console.WriteLine($"{item.name} {item.surname} {item.okul_no}");
                }
            }
        }
      

      
       
      
       
    }
}