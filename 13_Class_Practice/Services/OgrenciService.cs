using _13_Class_Practice.Models;

namespace _13_Class_Practice.Services;

public class OgrenciService
{
   public List<Ogrenci> ogrenciler = new List<Ogrenci>()
    {
        new Ogrenci()
        {
            id="1",
            name = "Tarık",
            cinsiyet = "erkek"
        },
        new Ogrenci()
        {
            id="2",
            name = "Duhan",
            cinsiyet = "erkek"
        },
        new Ogrenci()
        {
            id="3",
            name = "Hamdi",
            cinsiyet = "erkek"
        },
        new Ogrenci()
        {
            id="4",
            name = "Yusuf",
            cinsiyet = "erkek"
        },
        new Ogrenci()
        {
            id="5",
            name = "Tuna",
            cinsiyet = "erkek"
        },
    };

    public void OgrenciCreate(Ogrenci ogrenci)
    {
        ogrenciler.Add(ogrenci);
        Console.WriteLine($"{ogrenci.name} isimli Ogrenci Eklendi");
        
    }

    public void OgrenciRemove(Ogrenci ogrenci)
    {

        Ogrenci bulunan_ogrenci = OgrenciFindById(ogrenci.id);
        
        if (bulunan_ogrenci == null)
        {
            Console.WriteLine("Öğrenci Bulunamadı");
        }
        else
        {
            ogrenciler.Remove(bulunan_ogrenci);
        }
    }
    
    public void OgrenciUpdate(Ogrenci ogrenci)  
    {
        Ogrenci bulunan_ogrenci = OgrenciFindById(ogrenci.id);
        
        if (bulunan_ogrenci == null)
        {
            Console.WriteLine("Öğrenci Bulunamadı");
        }
        else
        {
            bulunan_ogrenci.name = "Duhan";
        }

    }

    public Ogrenci OgrenciFindById(string id)
    {
        foreach (var item in ogrenciler)
        {
            if (id == item.id)
            {
                return item;
            }
            
        }

        return null;

    }

    public void OgrenciGetAll()
    {
        if (ogrenciler.Count == 0)
        {
            Console.WriteLine("Liste içerisi boş");
        }
        else
        {
            foreach (var item in ogrenciler)
            {
                Console.WriteLine( item.id+ " " + item.name + " " + item.cinsiyet );
            }
        }
      
    }
    
}