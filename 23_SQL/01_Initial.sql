
--SQL GÝRÝÞ--
/*
Veritabaný nedir?
Açýða çýkan ve saklanmasý mecburi olan verilerin depolandýðý alanlardýr.

Veritabaný Uygulama Türleri 
MSSQL
MYSQL
ORACLE SQL
POSTGRESQL

MONGODB(NO SQL)
*/



--Tek satýrlýk yorum býrakmak için kullanýlýr
/*
Çoklu yorum satýrý için bu ifade kullanýlýr.

*/


/*
Veri Tipleri

Int ->Rakamsal ifadeler için kullanýlýr.

Decimal ->Ondalýklý ifadeler için kullanýlýr.

char(adet)->adet kadar karakter tutar

nvarchar->Çince , rusça , arapça gibi latin alfabe karakteri içermeyen alfabeler için kullanýlýr.

Date-> yýl , ay , gün
DateTime -> yýl , ay , gün saat,dakika,salise

BIT -> Boolean karþýlýðý , sadece 1 - 0 tutar
*/

/*
SORGULAR

Veritabanýnda crud iþlemleri yapýlýr

Ýþlem - Komut
Create - Create
Read - Select
Update -Update
Delete -Delete



*/

--EXECUTE -> sorguyu çalýþtýrmak için kullanýlan komut 
/*
Sayfa üzerinde belirli bir sorgu seçilmezse o sayfa içindeki bütün komutlarý çalýþtýrýr.
*/




--CREATE
--Database oluþturuldu
create DATABASE fullstackORNEKDB

--USE ile birlikte çalýþacaðýmýz db yi seçiyoruz.
USE fullstackORNEKDB

--Tablo oluþturuldu
create Table Students (
	StudentID INT IDENTITY(1,1) PRIMARY KEY,
	Name nvarchar(50) NOT NULL,
	Surname nvarchar(50) NOT NULL,
	Email nvarchar(50) UNIQUE,
	BirthDate DATETIME DEFAULT GETDATE()
)

--INSERT
--NOT ÇÝFT TIRNAK KULLANILMAZ
INSERT INTO Students (Name,Surname,Email,BirthDate) values
('TARIK','HAMARAT','trkhamarat@gmail.com','2024-11-16 13:00:000')


INSERT INTO Students (Name,Surname,Email,BirthDate) values
--('Ömer','Þahin','omer@gmail.com','2020-10-16 10:00:000'),
('Duhan','karaman','duhan5@gmail.com','2008-09-01 03:00:000')



/*
Kayýtlý bir eposta girildiði için Email adresi uniqoue olduðundan duplicate uyarýsý alýyoruz.
INSERT INTO Students (Name,Surname,Email,BirthDate) values
('Esra','Çakýcý','trkhamarat@gmail.com','2020-10-16 10:00:000')
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
select * from Students where Name='Duhan' and Surname = 'Göksal' and Email='duhan@gmail.com'
select * from Students where StudentID > 3


--UPDATE
--Veriyi güncellemek için kullanýlýr.
select * from Students

update Students set 
Name='Yusuf'
where StudentID = 5

--Koþul belirtilmeden güncelleme yapýlýrsa tablodaki bütün verileri etkiler.
update Students set 
Name='Tarýk'

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

-- Yanlýþ bir iþlem yaptýysanýz:
ROLLBACK; -- Ýþlem geri alýnýr.

-- Eðer doðru olduðuna karar verirseniz:
COMMIT; -- Deðiþiklikler kaydedilir.

-----------------------------------------------------------------------------------------

--DROP 
--DROP ifadesi ile birlikte veri tabanýndan tablonun kaldýrýlmasýný saðlarýz
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


--Sütun veri tipi ve null özellii güncellenebilir
alter table Students ALTER COLUMN DENEME Nvarchar(50) NOT NULL

--UNIQUE DURUMU EKLEMEK
alter table Students ADD CONSTRAINT UQ_Email UNIQUE (Email)
alter table Students DROP CONSTRAINT UQ_Email


--ADD ILE SÜTUN EKLEMEK

alter table Students ADD Adres nvarchar(100),Phone nvarchar(20)

--Sütun isimlerini deðiþtirme.
exec sp_rename 'Students.TCCC','TCKN' , 'COLUMN' 


