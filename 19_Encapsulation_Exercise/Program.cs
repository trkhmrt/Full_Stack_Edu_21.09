namespace _19_Encapsulation_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            User user = new User();
            //Console.WriteLine(user._TC);
            // Console.WriteLine("TC giriniz");

            // user._TC = Console.ReadLine();
            Console.WriteLine("Iban GİRİNİZ");
            user._Iban = Console.ReadLine().Trim();// TRİM SAĞ VE SOL BOŞLUĞU SİLER


        }
        class User
        {
            private string TC { get; set; }
            private string Iban { get; set; }
            public string _TC
            {
                get
                {
                    return "veriyi okuyamazsın";
                }
                set
                {
                    if (value.Length != 11)
                    {
                        Console.WriteLine("11 Hane giriniz");
                        _TC = Console.ReadLine();  // yeni değerde tekrar set tetiklenir
                    }

                    else
                    {
                        TC = value;
                    }

                }
            }
            public string _Iban 
            {
                get
                {
                    return "veriyi okuyamazsın";
                }
                set
                {
                    if (value.StartsWith("TC")&&value.Length==5)// SUBSTRİNG DE OLURDU
                    {
                        Console.WriteLine("IBAN DOĞRU");
                        
                    }

                    else
                    {
                        Console.WriteLine("Iban DOĞRU DEĞİL");
                    }

                }

            }
            
        }
    }
}
