using MY_PRACTICE_CLASS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MY_PRACTICE_CLASS.Services
{
    public class PersonelService
    {
        public List<Personel> Personeller = new List<Personel>()
        {
            new Personel()
            {
                id="2",
                name="Asım",
                surname="Ergin"

            },
            new Personel()
            {
                id="3",
                name="Hamdi",
                surname="Ergin"
            }
        };



        public void PersonelCreate(Personel personel)
        {
            Personeller.Add(personel);
            Console.WriteLine($"{personel.name} İsimli Personel Eklendi");
        }
        public void PersonelRemove(Personel personel)
        {
            Personel silinecek_per = PersonelFindById(personel.id);
            if (silinecek_per== null)
            {
                Console.WriteLine("Personel Bulunamadı");
            }
            else
            {
                Personeller.Remove(personel);
            }

        }

        public void PersonelUpdate(Personel personel)
        {
            Personel güncellenecek_per = PersonelFindById(personel.id);
            if (güncellenecek_per == null)
            {
                Console.WriteLine("Personel Bulunamadı");
            }
            else
            {
                güncellenecek_per.name = "Joseph";
            }
        }

        public Personel PersonelFindById(string id)
        {
            foreach (var item in Personeller)
            {
                if (id == item.id)
                {
                   return item;
                }
            }
            return null;
        }

        public void PersonelGetAll()
        {
            if (Personeller.Count() == 0)
            {
                Console.WriteLine("Liste Boştur");
            }
            else
            {
                foreach (var item in Personeller)
                {
                    Console.WriteLine(item.id + " " + item.name + " " + item.surname);
                }
            }
        }

    }
}
