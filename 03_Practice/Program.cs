namespace _03_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  29.09.24    */

            /*Kullanıcıdan alınan üç değer için ortalama hesabı yaptırıp ekrana
             
            Örnek Çıktı : Yaş ortalaması : 20 dir .
               
             */

            //Console.Write("Sayı 1:");
            //int yas1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Sayı 2:");
            //int yas2 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Sayı 3:");
            //int yas3 = Convert.ToInt32(Console.ReadLine());



            //double ortalama = (yas1 + yas2 + yas3) / 3;

            //Console.WriteLine($"Yaş ortalaması : {ortalama}'dır.");




            //Örnek -> Kullanıcıdan alınan sayının karesini hesaplayan ve kullanıcıya çıktı olarak veren bir uygulama.
            //Console.WriteLine("1.Sayı:");
            //int s1 = Convert.ToInt32(Console.ReadLine());

            //int kare = s1 * s1;

            //Console.WriteLine("Sayının karesi:"+kare);




            //Math.Pow(üssü alınacak sayyı, üs);
            //double üssünü_al = Math.Pow(s1,3);

            //Console.WriteLine("Üs sonucu:"+ üssünü_al);


            //Örnek ->  Kullanıcıdan alınan değerin 20 den büyük olup olmadığının sonucunu ekrana yazdıran uygulama.

            //Console.WriteLine("Kontrol etmek için bir sayi giriniz:");
            //int number = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Kontrol Sonucum: " + (number>20 || number==20));


            //Örnek -> Kullanıcıdan alınan ürün fiyat toplamına sizin belirlemiş olduğunuz bir indirim tutarı uygulayın.

            Console.WriteLine("Ürün 1 Tutar:");

            int urun1 =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ürün 2 Tutar:");

            int urun2=Convert.ToInt32(Console.ReadLine());

            int toplam=urun1+urun2;

            Console.WriteLine("Uygulanacak Tl miktarı");

            int indirim=Convert.ToInt32(Console.ReadLine());

            int son_tutar = toplam - indirim;

            Console.WriteLine("Ürünlerin indirimli toplamı -> "+son_tutar);

        }
    }
}
