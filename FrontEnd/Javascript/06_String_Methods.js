/*

String Methods
*/

var isim = "Tarık "

console.log(isim.length)

console.log(isim.charAt(1))


console.log(isim.toUpperCase())
console.log(isim.toLowerCase())




/* TRIM 
Trim -> sağve sol boşlukları temizler

*/
var soyisim = " Hamarat"

var il = " İstanbul "
var semt = "Sefaköy"

var isimSoyisim = isim.trimEnd()+soyisim.trimStart()+il.trim()+semt

console.log(isimSoyisim)


/* REPEAT */

console.log(isim.repeat(3))


/* REPLACE */

var mesaj = "DERSİMİZE HOŞELDİNİZ"
console.log(mesaj.replace("HOŞELDİNİZ","HOŞGELDİNİZ ARKADAŞLAR"))


/* STRING ARAMA METOTLARI */

// INDEXOF

var text = "Merhaba Tarık Dünya"

console.log(text.indexOf("a",4))
console.log(text.indexOf("Dünya"))
console.log(text.indexOf("t")) //Olmayan bir karakter girildiğinde bize -1 cevabı döner

// LAST INDEX OF

console.log(text.lastIndexOf("Dünya"))

/* INCLUDES */

console.log(text.includes("Tarık"))


/* STARTSWİTH & ENDSWİTH */

console.log(text.startsWith("M"))
console.log(text.endsWith("k"))


/* SLICE */

console.log(text.slice(1,3))
console.log(text.slice(-6))

/* SUBSTRING */

console.log(text.substring(1,3))


/* STRING ŞABLONLARI */

console.log(`${text}`)