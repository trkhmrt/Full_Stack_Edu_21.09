namespace _05_IF_ELSE
{
    internal class Program
    {
        static void Main(string[] args)
        {


            /*
             
            IF_ELSE(KARAR YAPILARI)

            Uygulama içerisinde değişen şartlara göre kodun akış yönünün ne şekilde olacağına karar verdirdiğimiz yapılardır.


            IF ve Elseden sadece birer adet kullanılabilir ama 'else if' den istediğiniz kadar kullanabilirsiniz.

            Bütün şartlar kontrol edildiğinde her birinden false cevabı alınırsa else çalışır.

            Birden fazla şartın olduğu durumda tek bir ifade true döndürüyorsa o çalıştırılır , diğer şartlar kontrol edilmez ve uygulama akışında çalışmaya devam eder.


            if(burada kontrol edilen şartın true döndürürse)
            {
             
            Buradaki kod çalışır

            }
            else{
                
                 şart true döndürmezse burası çalışır.
            
            }

             */


            //bool kontrol = false;

            //if (kontrol!=false)
            //{
            //    Console.WriteLine("kontrol false a eşittir.");

            //}
            //else
            //{
            //    Console.WriteLine("kontrol false a eşit değildir.");
            //}

            //if (false)
            //{
            //    Console.WriteLine("kontrol false a eşittir.");

            //}
            //else
            //{
            //    Console.WriteLine("kontrol false a eşit değildir.");
            //}



            //IF - ELSE IF - ELSE


            //Console.WriteLine("Yaş giriniz");

            //int yas = Convert.ToInt32(Console.ReadLine());



            //if (yas > 18)
            //{

            //    Console.WriteLine("Ehliyet alınabilir");

            //}
            //else if (yas==18)
            //{
            //    Console.WriteLine("Yaş 18 e eşittir.");
            //}
            //else if (yas < 0)
            //{
            //    Console.WriteLine("Uygun bir yaş aralığı girin");
            //}
            //else
            //{
            //    Console.WriteLine("Ehliyet alınamaz");
            //}




            //ELSE IF OLMASA NE OLURDU.


            Console.WriteLine("Yaş giriniz");

            int yas = Convert.ToInt32(Console.ReadLine());



            if (yas > 18)
            {

                Console.WriteLine("Ehliyet alınabilir");

            }

            if (yas == 18)
            {
                Console.WriteLine("Yaş 18 e eşittir.");
            }


            if (yas < 0)
            {
                Console.WriteLine("Uygun bir yaş aralığı girin");
            }


            else
            {
                Console.WriteLine("Ehliyet alınamaz");
            }







        }
    }
}
