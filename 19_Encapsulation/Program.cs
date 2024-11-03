namespace _19_Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Kapsülleme,bir nesnenin belirli bir propunu yada metodunun gizlenerek veri güvenliğinin sağlanmasını amaçlar
            */
            User user = new User();
            Console.WriteLine(user._TC);
            Console.WriteLine("TC giriniz");
           
            user._TC = Console.ReadLine();


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

        }
    }
}
