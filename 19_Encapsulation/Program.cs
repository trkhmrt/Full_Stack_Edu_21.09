namespace _19_Encapsulation;

class Program
{
    static void Main(string[] args)
    {
       /*
        KAPSÜLLEME(ENCAPSULATION)
        
        Bir nesnenin belirli bir özelliği veya metodunun gizlenerek , veri güvenliğinin sağlanmasını amaçlar.
        
        */
       //TRİM START -> BAŞLANGIÇTAKİ White-Space B  TRİMEND->Sondaki white-space'i siler   TRİM -> sağdaki ve soldaki boşluğu siler
       
       User user = new User();
       //Console.WriteLine(user._TC);
       // Console.WriteLine("Tc giriniz");
       // user._TC = Console.ReadLine();
       Console.WriteLine("IBAN GİRİNİZ");
       user._IBAN = Console.ReadLine().Trim();
        
    }
    
    class User
    {
        
        private string TC { get; set; }
        
        private string IBAN { get; set; }
        //IBAN BAŞINDA TC VARMI ? 
        //TC İLE BİRLİKTE TOPLAM 5 KARAKTER OLSUN
        //BU ŞARTLAR SAĞLANIRSA IBANA VERİ AKTARILSIN.SAĞLANMIYORSA DOĞRU GİRENE KADAR BİZDEN VERİ İSTESİN.
        public string _TC
        {
            get
            {
                return "Veriyi okuyamazsın";
            }
            set
            {
                    if (value.Length != 11)
                    {
                        
                        Console.WriteLine("11 hane giriniz");
                        _TC = Console.ReadLine();
                        
                    }
                    else
                    {
                        TC = value;
                    }
            }
        }

        public string _IBAN
        {
            get
            {
                return _IBAN;
            }
            set
            {
                //1-StartsWith
                // if (value.StartsWith("TC") && value.Length ==5 )
                // {
                //     Console.WriteLine("IBAN DOĞRU");
                // }
                // else
                // {
                //     Console.WriteLine("IBAN DOĞRU DEĞİL");
                // }
                
                //2-Substring
                if (value.Length == 5)
                {
                    if (value.Substring(0, 2) == "TC"   )
                    {
                        Console.WriteLine("İBAN DOĞRU");
                    }
                    else
                    {
                        Console.WriteLine("TC İFADESİ YOK");
                    }
                }
                else
                {
                    Console.WriteLine("UYGUN IBAN GIRINIZ");
                }

              
               
                
            }
        }
        
        
    }
}