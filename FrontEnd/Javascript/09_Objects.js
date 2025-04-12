/*
Javascriptte objeler anahtar-değer çiftlerinden oluşan veri yapılarıdır.
*/

// var ogrenci = {
//     isim:"Tarık",
//     yas:28
// }

// console.log(ogrenci.isim + ogrenci.yas)

// console.log(ogrenci["isim"])

// //NESNE GÜNCELLEME

// ogrenci.isim = "Yusuf"

// console.log(ogrenci.isim + ogrenci.yas)

// ogrenci.notOrt = 95

// console.log(ogrenci.isim + ogrenci.yas + "NotOrt" + ogrenci.notOrt)


//NESNE İÇİNDE NESNE

// var araba = {
//     marka:"BMW",
//     renk:"Sarı",
//     ureticiFirma:{
//         firmaAdi:"Borusan",
//         uretimYeri:"Istanbul"
//     }
// }

// // console.log(araba.marka)
// // console.log(araba.ureticiFirma.firmaAdi)
// console.log(araba["ureticiFirma"]["firmaAdi"])

//NESNE İÇİNDE METOT TANIMLAMA

// var urun = {
//     marka:"Eti",
//     tür:"Çikolata",
//     bilgiler:function(message = ""){
//         console.log(`${this.marka} Markasının ${this.tür} türündeki ürünü.${message}`)
//     }
// }

// urun.bilgiler("ALIN!!!")
