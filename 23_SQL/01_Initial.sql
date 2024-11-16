
--SQL G�R��--
/*
Veritaban� nedir?
A���a ��kan ve saklanmas� mecburi olan verilerin depoland��� alanlard�r.

Veritaban� Uygulama T�rleri 
MSSQL
MYSQL
ORACLE SQL
POSTGRESQL

MONGODB(NO SQL)
*/



--Tek sat�rl�k yorum b�rakmak i�in kullan�l�r
/*
�oklu yorum sat�r� i�in bu ifade kullan�l�r.

*/


/*
Veri Tipleri

Int ->Rakamsal ifadeler i�in kullan�l�r.

Decimal ->Ondal�kl� ifadeler i�in kullan�l�r.

char(adet)->adet kadar karakter tutar

nvarchar->�ince , rus�a , arap�a gibi latin alfabe karakteri i�ermeyen alfabeler i�in kullan�l�r.

Date-> y�l , ay , g�n
DateTime -> y�l , ay , g�n saat,dakika,salise

BIT -> Boolean kar��l��� , sadece 1 - 0 tutar
*/

/*
SORGULAR

Veritaban�nda crud i�lemleri yap�l�r

��lem - Komut
Create - Create
Read - Select
Update -Update
Delete -Delete



*/

--EXECUTE -> sorguyu �al��t�rmak i�in kullan�lan komut 
/*
Sayfa �zerinde belirli bir sorgu se�ilmezse o sayfa i�indeki b�t�n komutlar� �al��t�r�r.
*/




--CREATE
--Database olu�turuldu
create DATABASE fullstackORNEKDB

--USE ile birlikte �al��aca��m�z db yi se�iyoruz.
USE fullstackORNEKDB

--Tablo olu�turuldu
create Table Students (
	StudentID INT IDENTITY(1,1) PRIMARY KEY,
	Name nvarchar(50) NOT NULL,
	Surname nvarchar(50) NOT NULL,
	Email nvarchar(50) UNIQUE,
	BirthDate DATETIME DEFAULT GETDATE()
)

--INSERT
--NOT ��FT TIRNAK KULLANILMAZ
INSERT INTO Students (Name,Surname,Email,BirthDate) values
('TARIK','HAMARAT','trkhamarat@gmail.com','2024-11-16 13:00:000')


INSERT INTO Students (Name,Surname,Email,BirthDate) values
--('�mer','�ahin','omer@gmail.com','2020-10-16 10:00:000'),
('Duhan','karaman','duhan5@gmail.com','2008-09-01 03:00:000')



/*
Kay�tl� bir eposta girildi�i i�in Email adresi uniqoue oldu�undan duplicate uyar�s� al�yoruz.
INSERT INTO Students (Name,Surname,Email,BirthDate) values
('Esra','�ak�c�','trkhamarat@gmail.com','2020-10-16 10:00:000')
*/

--SELECT 
--Veri okumaya yarar

select * 
from 
Students

select Name,Surname 
from 
Students


--1 TARIK
select * 
from 
Students

/*
TARIK HAMARAT -> click -> 1 -------->API ILE SERVER'A 
*/
select * from Students where StudentID = 1
select * from Students where Name='Duhan' and Surname = 'G�ksal' and Email='duhan@gmail.com'
select * from Students where StudentID > 3


--UPDATE
--Veriyi g�ncellemek i�in kullan�l�r.
select * from Students

update Students set 
Name='Tar�k'
where StudentID = 10

--Ko�ul belirtilmeden g�ncelleme yap�l�rsa tablodaki b�t�n verileri etkiler.
update Students set 
Name='Tar�k'

--DELETE
select * from Students
delete from Students where StudentID = 6






