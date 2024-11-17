
select * from Orders

--Sat�r say�s�n� getirir
select COUNT(*) from Orders


--MAX ifadesi ve tablo isimlendirme
select MAX(Freight)[En y�ksek kargo maliyeti] from Orders
select MAX(Freight) as 'En y�ksek kargo maliyeti' from Orders
select MAX(Freight)  'En y�ksek kargo maliyeti' from Orders
--MIN ifadesi ile bu s�tuna ait en d���k de�er getirilir.
select MIN(Freight)[En y�ksek kargo maliyeti] from Orders


--AVG()
select AVG(Freight) as 'Kargo maliyetlerinin ortalamas�' from Orders

--AVG()
select SUM(Freight) as 'Kargo maliyetlerinin toplam�' from Orders


--IN ifadesi ile birlikte toplu kay�t getirme
 select * from orders where ShipCountry = 'Brazil' or ShipCountry='France' or ShipCountry='Belgium'
 select * from orders where ShipCountry in('Brazil','France','Belgium')



 --KAR�ILA�TIRMA OPERAT�RLER�

 select * from Orders


select * from Orders where Freight > 48.10

select * from Orders where Freight >= 48.10
 
select * from Orders where Freight < 48.10

select * from Orders where Freight <= 48.10


select * from Orders where Freight = 68.66



select * from Orders where ShipCountry != 'USA'


   
--NULL SORGUSU ���N KULLANILIR.
select * from Orders where ShipRegion IS NOT NULL
select * from Orders where ShipRegion IS NULL

select Freight+2,* from Orders 
select Freight*2,* from Orders 

select * from Orders where EmployeeID % 2 = 1

