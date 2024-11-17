--GROUP BY ve HAVING

/*
SQL DE VER�LER� BEL�RL� GRUPLARA AYIRMAK VE BU AYRILAN GRUPLAR �ZER�NDE �E��TL� KO�ULLAR UYGULAYARAK �STEN�LEN RAPORLAMAYI EKRANA GET�RMEK ���N KULLANILIR.


*/


--GROUP BY

select * from Orders 

select * from Orders where ShipCountry = 'Germany'

select ShipCountry,COUNT(*) as '�lkelere g�re toplam sat�� adedi' from Orders group by ShipCountry

select ShipCountry,SUM(Freight) as '�lkelere g�re toplam sat��' from Orders group by ShipCountry



--HAVING
--Aggregate metotlarla birlikte where ifadesi kullan�lamaz having kullan�lmal�.
select ShipCountry,COUNT(*) as '�lkelere g�re toplam sat�� adedi' from Orders group by ShipCountry having COUNT(*) >=70


select * from Products

select CategoryID,SUM(UnitPrice) from Products group by CategoryID 

select CategoryID,SUM(UnitsInStock)   from Products group by CategoryID having SUM(UnitsInStock)  < 160


select * from [Order Details]

select * from [Order Details] where ProductID = 1 

select ProductID,COUNT(*) as 'SATI� ADED�',SUM(UnitPrice*Quantity) as 'SATI� TOPLAM TUTARI' from [Order Details] group by ProductID  



--ORDER BY �LE SIRALAMA
select ProductID,COUNT(*) as 'SATI� ADED�',SUM(UnitPrice*Quantity) as 'SATI� TOPLAM TUTARI' from [Order Details] group by ProductID order by ProductID desc

select ProductID,COUNT(*) as 'SATI� ADED�',SUM(UnitPrice*Quantity) as 'SATI� TOPLAM TUTARI' from [Order Details] group by ProductID order by 'SATI� TOPLAM TUTARI' desc



--SUBQUERY �LE GROUP BY 

select (Select ProductName from Products where ProductID = od.ProductID),Sum(od.Quantity*od.UnitPrice) from [Order Details] od group by od.ProductID

--DISTINCT �LE TABLO ��ER�S�NDE TEKRAR EDEN DE�ERLER� TEKE D���R�R

select DISTINCT OrderID from [Order Details]
