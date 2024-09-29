namespace _04_Scope
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int sayi = 10;


            //Console.WriteLine(sayi);



            //{
            //    int sayi2 = 40;
            //    Console.WriteLine(sayi);
            //    {
                    //Farklı scopelar içerisinde adeğişken isimleri aynı olsa bile hata vermez.
                //    int sayi3 = 40;
                //    Console.WriteLine(sayi2);
                    
                //}
                //{
                //    int sayi3 = 40;
                //    Console.WriteLine(sayi2);
                //}


                //Genel scope içinde özel bir scope oluşturulursa,özel scope içinde tanımlanan herhangi bir değişkene dış scopedan erişim sağlanamaz.
              //  Console.WriteLine(sayi3);





            //}


            {
                //Globalde en dışarıdaki katmanda bir değişken tanımlanırsa bu değişkene bütün katmanlardan erişim sağlanabilir.
                //  int sayi = 40;

                int sayi4 = 20;

                {
                    int sayi5 = 30;
                    Console.WriteLine($"1.Scope-> Sayi4:{sayi4 + 10}"); 
                    Console.WriteLine($"1.Scope-> Sayi5:{sayi5 + 20}"); 

                }
                {
                    int sayi5 = 30;
                    Console.WriteLine($"2.Scope Sayi4->{sayi4 + 30}");
                    Console.WriteLine($"2.Scope Sayi5->{sayi5 + 30}");
                }



                //Soru :  1. ve 2. scopedaki sayi4 ve sayi5 değerleri nelerdir ? 


            }

         





        }
    }
}
