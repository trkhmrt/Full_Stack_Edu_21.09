
select * from Orders

--Satýr sayýsýný getirir
select COUNT(*) from Orders


--MAX ifadesi ve tablo isimlendirme
select MAX(Freight)[En yüksek kargo maliyeti] from Orders
select MAX(Freight) as 'En yüksek kargo maliyeti' from Orders
select MAX(Freight)  'En yüksek kargo maliyeti' from Orders
--MIN ifadesi ile bu sütuna ait en düþük deðer getirilir.
select MIN(Freight)[En yüksek kargo maliyeti] from Orders


--AVG()
select AVG(Freight) as 'Kargo maliyetlerinin ortalamasý' from Orders

--AVG()
select SUM(Freight) as 'Kargo maliyetlerinin toplamý' from Orders


--IN ifadesi ile birlikte toplu kayýt getirme
 select * from orders where ShipCountry = 'Brazil' or ShipCountry='France' or ShipCountry='Belgium'
 select * from orders where ShipCountry in('Brazil','France','Belgium')



 --KARÞILAÞTIRMA OPERATÖRLERÝ

 select * from Orders


select * from Orders where Freight > 48.10

select * from Orders where Freight >= 48.10
 
select * from Orders where Freight < 48.10

select * from Orders where Freight <= 48.10


select * from Orders where Freight = 68.66



select * from Orders where ShipCountry != 'USA'


   
--NULL SORGUSU ÝÇÝN KULLANILIR.
select * from Orders where ShipRegion IS NOT NULL
select * from Orders where ShipRegion IS NULL

select Freight+2,* from Orders 
select Freight*2,* from Orders 

select * from Orders where EmployeeID % 2 = 1

