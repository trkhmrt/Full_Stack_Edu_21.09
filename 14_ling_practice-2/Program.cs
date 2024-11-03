namespace _14_ling_practice_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<talebe> talebeler = new List<talebe>()
{
                new talebe()
                {
                    name = "Tarık",
                    surname = "Hamarat",
                    age = 50,
                     puan1 = 20,
                     puan2= 30,
                },
                new talebe()
                {
                    name ="Duhan",
                    surname = "Göksal",
                    age=85,
                    puan1 = 40,
                    puan2= 50,
                },
                new talebe()
                {
                    name ="Yusuf",
                    surname = "Ergin",
                    age=18,
                    puan1 = 60,
                    puan2= 90,
                },
                new talebe()
                {
                    name="Hamdi",
                    surname="Kantekin",
                    age=36,
                    puan1 = 80,
                    puan2= 100,
                },
                new talebe()
                {
                    name="Esra",
                    surname="Çakıcı",
                    age=22,
                    puan1 =95,
                    puan2= 95,
                },
                new talebe()
                {
                    name = "Alper",
                    surname="kayabaşı",
                    age=13,
                    puan1 = 99,
                    puan2= 88,

                },
                new talebe()
                {
                    name = "Tuna",
                    surname="Genç",
                    age=27,
                    puan1 = 45,
                    puan2= 92,

                }

            };

            //her bir öğrencinin not ortalamasını bulun
            var sinif_ortalama = talebeler.Select(talebe => (talebe.puan1 + talebe.puan2)/2).Average();
            //puan1 değeri 50 üzerindeki öğrenciler

            var puan_buyuk_elli = talebeler.Where(talebe => talebe.puan1 > 50);

            //ismi a ile başlayan ve yaşı 22 den büyük olana
            var isim_a_yas_buyuk_yirmiki = talebeler.Where(talebe => talebe.name.EndsWith("a") && talebe.age > 22);

            //ismi t ile başlayan öğrencilerin notlarını büyükten küçüğe sırala

            var sonuc = talebeler.OrderByDescending(talebe => talebe.puan1).Where(talebe => talebe.name.StartsWith("T"));

            var sonuc2 = talebeler.Where(talebe => talebe.name.StartsWith("T")).OrderByDescending(talebe => talebe.puan1);

            //YAŞI 18 E EŞİT ve küçük olan talebelerin bilgisini sadece ismi ile getir

            var talebe_listesi = talebeler.Where(talebe => talebe.age >= 18).Select(talebe => new { talebe.name});











        }
    }
}
