--GROUP BY ve HAVING

/*
SQL DE VERÝLERÝ BELÝRLÝ GRUPLARA AYIRMAK VE BU AYRILAN GRUPLAR ÜZERÝNDE ÇEÞÝTLÝ KOÞULLAR UYGULAYARAK ÝSTENÝLEN RAPORLAMAYI EKRANA GETÝRMEK ÝÇÝN KULLANILIR.


*/


--GROUP BY

select * from Orders 

select * from Orders where ShipCountry = 'Germany'

select ShipCountry,COUNT(*) as 'Ülkelere göre toplam satýþ adedi' from Orders group by ShipCountry

select ShipCountry,SUM(Freight) as 'Ülkelere göre toplam satýþ' from Orders group by ShipCountry



--HAVING
--Aggregate metotlarla birlikte where ifadesi kullanýlamaz having kullanýlmalý.
select ShipCountry,COUNT(*) as 'Ülkelere göre toplam satýþ adedi' from Orders group by ShipCountry having COUNT(*) >=70


select * from Products

select CategoryID,SUM(UnitPrice) from Products group by CategoryID 

select CategoryID,SUM(UnitsInStock)   from Products group by CategoryID having SUM(UnitsInStock)  < 160


select * from [Order Details]

select * from [Order Details] where ProductID = 1 

select ProductID,COUNT(*) as 'SATIÞ ADEDÝ',SUM(UnitPrice*Quantity) as 'SATIÞ TOPLAM TUTARI' from [Order Details] group by ProductID  



--ORDER BY ÝLE SIRALAMA
select ProductID,COUNT(*) as 'SATIÞ ADEDÝ',SUM(UnitPrice*Quantity) as 'SATIÞ TOPLAM TUTARI' from [Order Details] group by ProductID order by ProductID desc

select ProductID,COUNT(*) as 'SATIÞ ADEDÝ',SUM(UnitPrice*Quantity) as 'SATIÞ TOPLAM TUTARI' from [Order Details] group by ProductID order by 'SATIÞ TOPLAM TUTARI' desc



--SUBQUERY ÝLE GROUP BY 

select (Select ProductName from Products where ProductID = od.ProductID),Sum(od.Quantity*od.UnitPrice) from [Order Details] od group by od.ProductID

--DISTINCT ÝLE TABLO ÝÇERÝSÝNDE TEKRAR EDEN DEÐERLERÝ TEKE DÜÞÜRÜR

select DISTINCT OrderID from [Order Details]
