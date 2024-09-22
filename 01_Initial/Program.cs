namespace _01_Initial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tek satır için Yorum satırı 
            /*
                Birden fazla satır için yorum satırı


             */

            /*
              
             
           DEĞİŞKENLER (Variables)
             
            Uygulama içerisinde ortaya çıkan verileri yada kullanıcı tarafından program içerisine aktarılmak istenen verileri tutan en küçük yapı birimleri.
             
            Veri Tipleri
            
            1-Metinsel Veri tipi

            -Char -String
            'T'   "Tarık" "01.11.1997"

            2-Sayısal Veri Tipleri

            -int  -> Tam sayılar  -2milyar - +2milyar uzunluğunda veri saklar.
            -double -> - ve + ondalıklı sayıları saklar.
            -longint -> int den daha büyük tam sayılar
            -shortint -> int den daha küçük tam sayılar

            3-Mantıksal veri Tipi

            Boolean -> True(1) yada False(0)

            
             */


            /*
             
            DEĞİŞKEN TANIMLAMA

            değişkenin_veri_tipi değişken_adı = veri ;
             
            Örnek Değişken Tanımlama

            int birth_year = 1997; 
            double weight = 80.0; 
            double height = 185.4

             string name_surname = "Tarık Hamarat" ;

       
             */

            int birth_year = 2009;
            double weight = 90.0;
            double height = 180.0;
            string name_surname = "Tarık Hamarat";

            string city = null; //null değer atandığında içerisinde hiçbir veri taşınmaz.
            string country = ""; // "" bu şekilde içi boş bir string tanımlanırsa.Bunun için bellekte bir yer atanır.



            /*
             * 
             * 
             * İçlerinde belirgin bir ifade yer almayabilir.Ancak identity_number içinde boşluk olduğu için ve boşlukta bir karakter olarak algılandığı için parent_name de bir karakter yokken identity_number da birden fazla boşluk karakteri bulunuyor.
             
            string parent_name = "";
            string identity_number = "                        "; 


            */


            /*
             
             DEĞİŞKEN TANIMLAMA KURALLARI
             
            yanlış tanımlama nasıl olur ?

            NOT:Türkçe karakter kullanmak kodlama esnasında herhangi bir hataya sebep olmaz ancak hiçbir şekilde türkçe karaktere yer verilmemelidir.

            name surname x (iki kelime arasıda boşluk olmaz)        name-surname x   name.surname x  ( _ dışında herhangi bir özel karakter kullanılmaz.)

            1name x (rakam başta değil sonda olmalı) 

             
            doğru değişken tanımlama kuralları nedir?

            namesurname v/  name_surname(sneak case) v/ nameSurname (camelCase) v/  NameSurname(PascalCase Not:Sadece class isimleri ve metot isimleri)

            name1 name2 name3 (Rakam sonda olacak şekilde isimlendirilir.)

            _name_surname _namesurname namesurname_


             */

            
            

            Console.WriteLine("Hello, World!");
        }
    }
}
