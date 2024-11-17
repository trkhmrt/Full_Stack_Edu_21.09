
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
Name='Yusuf'
where StudentID = 5

--Ko�ul belirtilmeden g�ncelleme yap�l�rsa tablodaki b�t�n verileri etkiler.
update Students set 
Name='Tar�k'

--DELETE
select * from Students
delete from Students where StudentID = 6


--------------------------------------------------------------------------------

CREATE TABLE Musteriler (
    MusteriID INT PRIMARY KEY,
    Ad NVARCHAR(50),
    Telefon NVARCHAR(15),
    SysStartTime DATETIME2 GENERATED ALWAYS AS ROW START NOT NULL,
    SysEndTime DATETIME2 GENERATED ALWAYS AS ROW END NOT NULL,
    PERIOD FOR SYSTEM_TIME (SysStartTime, SysEndTime)
)
WITH (SYSTEM_VERSIONING = ON (HISTORY_TABLE = dbo.MusterilerHistory));

insert into Musteriler (MusteriID,Ad,Telefon)  values  (2,'Yusuf','6666')

select * from dbo.MusterilerHistory

SELECT *
FROM Musteriler 
---------------------------------------------------------------------------------
use fullstackORNEKDB

SELECT *
FROM fn_dblog(NULL, NULL);

DBCC LOG (fullstackORNEKDB, 1);

--------------------------------------------------------------------------------------
select * from Musteriler

BEGIN TRANSACTION;

UPDATE Musteriler
SET Telefon = '1111'
WHERE MusteriID = 1;

-- Yanl�� bir i�lem yapt�ysan�z:
ROLLBACK; -- ��lem geri al�n�r.

-- E�er do�ru oldu�una karar verirseniz:
COMMIT; -- De�i�iklikler kaydedilir.

-----------------------------------------------------------------------------------------

--DROP 
--DROP ifadesi ile birlikte veri taban�ndan tablonun kald�r�lmas�n� sa�lar�z
create Table Deneme(
  MusteriID INT PRIMARY KEY,
    Ad NVARCHAR(50),
    Telefon NVARCHAR(15),
)
DROP TABLE Deneme



--ALTER


alter table Musteriler set (System_Versioning = off)

DROP TABLE Musteriler
DROP TABLE MusterilerHistory


--S�tun veri tipi ve null �zellii g�ncellenebilir
alter table Students ALTER COLUMN DENEME Nvarchar(50) NOT NULL

--UNIQUE DURUMU EKLEMEK
alter table Students ADD CONSTRAINT UQ_Email UNIQUE (Email)
alter table Students DROP CONSTRAINT UQ_Email


--ADD ILE S�TUN EKLEMEK

alter table Students ADD Adres nvarchar(100),Phone nvarchar(20)

--S�tun isimlerini de�i�tirme.
exec sp_rename 'Students.TCCC','TCKN' , 'COLUMN' 


