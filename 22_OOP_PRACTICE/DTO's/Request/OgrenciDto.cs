using _22_OOP_PRACTICE.entities;

namespace _22_OOP_PRACTICE.DTO_s;

public class OgrenciDto
{
    
    public string name { get; set; }

    public string surname { get; set; }

    public DateTime dogum_tarihi { get; set; }

    public string okul_no { get; set; }
    
    public List<Ders> dersler { get; set; }
    
}