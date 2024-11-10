using _22_OOP_PRACTICE.Context;
using _22_OOP_PRACTICE.DTO_s.Response;
using _22_OOP_PRACTICE.entities;
using _22_OOP_PRACTICE.repositories;

namespace _22_OOP_PRACTICE.services;



public class OgrenciService:IOgrenciRepository
{
    List<Ogrenci> ogrenciList;
   
    public OgrenciService()
    {
        ogrenciList = OgrenciDB.ogrenciler;
       
    }
    
    
    public void AddOgrenci()
    {
        Ogrenci ogrenci = new Ogrenci();
        
        Console.WriteLine("Öğrenci ismi");
        ogrenci.name = Console.ReadLine();
        Console.WriteLine("Öğrenci soyismi");
        ogrenci.surname = Console.ReadLine();
        Console.WriteLine("Öğrenci DoğumTarihi");
        ogrenci.dogum_tarihi = Convert.ToDateTime(Console.ReadLine());
        ogrenci.kayit_tarihi = DateTime.Now;
        ogrenci.okul_no = Guid.NewGuid().ToString();
        ogrenci.dersler = new List<Ders>();
        
        while (true)
        {
            Console.WriteLine("Ders giriniz- Ders girme işlemini tamamlamak için -t ye basın");
            string ders_secim = Console.ReadLine();
            if (ders_secim != "t")
            {
                Console.WriteLine("Ders adi giriniz.");
                string ders_adi = Console.ReadLine().ToLower();
                foreach (var item in DersDB.dersler)
                {
                    if (ders_adi == item.ders_adi)
                    {
                        ogrenci.dersler.Add(item);
                        break;
                    }
                        
                }
            }
            else
            {
                break;
            }
        }
        
        ogrenciList.Add(ogrenci);
        
    }

    public void DeleteOgrenci(Ogrenci ogrenci)
    {
        throw new NotImplementedException();
    }

    public Ogrenci GetOgrenciByOkulNo(string okul_no)
    {
        throw new NotImplementedException();
    }

    public List<OgrenciResponseDto> GetAllOgrenci()
    {
        List<OgrenciResponseDto> ogrenciResponseDtoList = new List<OgrenciResponseDto>();
        
        foreach (var item in ogrenciList)
        {
            OgrenciResponseDto ogrenciResponseDto = new OgrenciResponseDto();
            ogrenciResponseDto.name = item.name;
            ogrenciResponseDto.surname = item.surname;
            ogrenciResponseDto.okul_no = item.okul_no;
            ogrenciResponseDtoList.Add(ogrenciResponseDto);
        }
        
        return ogrenciResponseDtoList;
    }
    
    
}