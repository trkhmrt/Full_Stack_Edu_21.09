using My_Practice_Home.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Practice_Home.Services
{
    internal class PersonelServices
    {
        public List<Personel> Personeller = new List<Personel>()
    {
        new Personel()
        {
            id="1",
            isim = "YUSUF",
            soyisim = "ERGİN"
        },
        new Personel()
        {
            id="2",
            isim = "ORHAN",
            soyisim = "ERGİN"
        },
        new Personel()
        {
            id="3",
            isim = "HAMDİ",
            soyisim = "ERGİN"
        },
       
        new Personel()
        {
            id="4",
            isim = "ASIM",
            soyisim = "ERGİN"
        },
    };



    }
}
