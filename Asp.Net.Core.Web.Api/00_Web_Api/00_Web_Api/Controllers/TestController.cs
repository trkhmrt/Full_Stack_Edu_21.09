using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _00_Web_Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        /*
        Veri tabanımızı 3. kişilere paylaşmamız gerektiğinde bizim denetimimizdeki kısıtlı verileri belirlediğimiz adreslerle paylaşırız.Firmalar bu adreslere istekler atarak veri okurlar yada yazarlar.
         */

        [HttpGet("getData")]
        //[Route("/getData")]
        //[Route("getData")]
        public IActionResult getData()
        {
            var isim = "Tarık";
            var isimler = new List<String>{ "Tarık" ,"Duhan","Yusuf","Alper","Tuna"};
            
            return BadRequest(new {name="Tarık",surname="Hamarat"});
        }

        [HttpGet("getData/{id}")]
        public IActionResult getData(int id)
        {
            return Ok($"{id} değerine sahip kullanıcı Tarık Hamarat");
        }

        //Query parametre olarak veri gönderilecekse 
        //http://localhost:5036/Test/createData?userId=23 şeklinde yazılmalı
        //Nesnenin propları doldurulmak üzere formdan veri gönderiliyorsa parametre olarak nesne kullanılmalı ve isteğin body kısmında json tiple veriler oluşturulmalı.
        [HttpPost("createData")]
        public IActionResult createData(string userId)
        {
            return Ok();
        }
        
        [HttpPost("createOgrenci")]
        public IActionResult createOgrenci(Ogrenci ogrenci)
        {
            return Ok(ogrenci.ogrenciUserId);
        }
        
        
        [HttpPut]
        [HttpDelete]
        
    }

    public class Ogrenci
    {
        public int ogrenciUserId { get; set; }
        public int ogrenciNumber { get; set; }
    }
}
