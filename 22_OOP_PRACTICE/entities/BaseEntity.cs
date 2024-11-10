namespace _22_OOP_PRACTICE.entities;

public class BaseEntity
{
    
    public string name { get; set; }

    public string surname { get; set; }

    public DateTime dogum_tarihi { get; set; }
    
    public List<Ders> dersler { get; set; }

    public DateTime kayit_tarihi { get; set; }
    
}