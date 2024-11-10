using _22_OOP_PRACTICE.DTO_s.Response;
using _22_OOP_PRACTICE.entities;

namespace _22_OOP_PRACTICE.repositories;



public interface IOgrenciRepository
{
  
    void AddOgrenci();

    void DeleteOgrenci(Ogrenci ogrenci);
    
    Ogrenci GetOgrenciByOkulNo(string okul_no);

    List<OgrenciResponseDto> GetAllOgrenci();
    
    
}