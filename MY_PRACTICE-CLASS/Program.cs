using MY_PRACTICE_CLASS.Models;
using MY_PRACTICE_CLASS.Services;

namespace MY_PRACTICE_CLASS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonelService personelService = new PersonelService();

            for(int i = 0; i < 3; i++)
            {
                Personel personel = new Personel();
                personel.id = (personelService.Personeller.Count + 1).ToString();
                personel.name = $"Yeni Öğrenci {i+1}";
                personel.surname = "Ergin";
                personelService.PersonelCreate(personel);
            }
            

            
            personelService.PersonelGetAll();

            //personelService.PersonelRemove(personel);
            //personelService.PersonelGetAll();

            //personelService.PersonelCreate(personel);
            //personelService.PersonelGetAll();

            //personelService.PersonelUpdate(personel);
            //personelService.PersonelGetAll();
        }
    }
}
