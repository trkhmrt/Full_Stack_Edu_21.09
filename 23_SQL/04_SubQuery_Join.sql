
--SORULAR--(SUBQUERY ÝLE)

--ID si 6 olan kullanýcýnýn satýþ yaptýðý ürünlerin kategori ismi
select * from Orders where EmployeeID = 6 

select * from [Order Details] where OrderID = 10390

select * from Products where ProductID in (31,
35,
46,
72)

select * from Categories where CategoryID in (4,
1,
8,
4)

select CategoryName from Categories c where CategoryID in (select CategoryID from products p where p.ProductID in ( select ProductID from [Order Details] od where OrderID in (select OrderID from Orders o where o.EmployeeID = 6)))


--En pahalý ürünün fiyatýný bulunuz

select ProductName from Products where UnitPrice = (Select MAX(UnitPrice) from products)                           


-- En çok Sipariþ verilen ürünün adýný bulunuz

--select TOP 1 ProductID,Sum(Quantity) from [Order Details] group by ProductID order by Sum(Quantity) desc
select * from Products where ProductID = (select TOP 1 ProductID from [Order Details] group by ProductID order by Sum(Quantity) desc)

--Ürün Stok Miktarý ortalama stok miktarlarýndan fazla olan ürünleri listeleyiniz
Select AVG(UnitsInStock) from products
select * from products where UnitsInStock > (Select AVG(UnitsInStock) from products)

--Fiyatý kategori baþýna ortalama ürün fiyatýndan yüksek olanlarý listeleyin.

--Ortalama Ürün Fiyatý
select AVG(UnitPrice) from products 
select * from products 
select Distinct CategoryID from Products where UnitPrice > (select AVG(UnitPrice) from products)
--Products Idlerle Kategorileri birleþtirelim.

select * from Products
select CategoryName from Categories where CategoryID in (select CategoryID from Products where UnitPrice > 100)


--Toplam sipariþ tutarý en yüksek olan müþterinin adý 

select * from Orders

select OrderID,SUM(Quantity * UnitPrice) from [Order Details] group by OrderID order by SUM(Quantity * UnitPrice) desc

select * from Orders where OrderID = (select TOP 1 OrderID   from [Order Details] group by OrderID order by SUM(Quantity * UnitPrice) desc )

--Aþðýdaki sorgudan gelen Customer ID yi aldýk
select CustomerID from Orders where OrderID = (select TOP 1 OrderID   from [Order Details] group by OrderID order by SUM(Quantity * UnitPrice) desc )

select * from Customers where CustomerID = (select CustomerID from Orders where OrderID = (select TOP 1 OrderID   from [Order Details] group by OrderID order by SUM(Quantity * UnitPrice) desc )
)

--11:40 DERS BAÞLAR



--JOIN
/*
Ýliþkisel veri tabanlarýnda birbirleri arasýnda iliþki bulunana tablolardaki verileri çekmek için kullanýlýr.

1.INNER JOIN
Ýki veya daha fazla tabloda eþleþen bütün kayýtlarý getirir.


2.LEFT JOIN(LEFT OUTER JOIN)
Sol ilk tabloda bulunan tüm kayýtlarý döndürür.Sað tarafta eþleþen kayýt yoksa bunlar null olarak döner.


2.RIGHT JOIN(LEFT OUTER JOIN)
Sað ikinci tabloda bulunan tüm kayýtlarý döndürür.Sol tarafta eþleþen kayýt yoksa bunlar null olarak döner.

3.FULL OUTER JOIN
Tüm kayýtlarý döner.Sol veya saðda herhangi birinde eþleþme yoksa bunlar null olarak döner.

*/

--Customers tablosu ile Orders tablosunu birleþtirelim.

select * from Customers
select * from Orders

select c.CompanyName,c.ContactName,o.OrderID from Customers c join Orders o on c.CustomerID = o.CustomerID 


--Order tablosunda geçen her bir kargo firmasýnýn adýný getiriniz

select distinct s.CompanyName from Shippers s join Orders o  on o.ShipVia = s.ShipperID 



--Kargo maliyeti en yüksek olan sipariþi taþýyan kargo firmasýnýn adý(--Freight kargo maliyeti)
SELECT     s.CompanyName,o.FreightFROM     Orders oJOIN     Shippers s ON o.ShipVia = s.ShipperID order by o.Freight desc

--Kargo isimlerine göre gruplandýrma yaparak toplam tutarda en yüksek kargo maliyetine sahip olan firma adýný getirmek.
select s.CompanyName,SUM(o.Freight) from 
Orders o join Shippers s on s.ShipperID = o.ShipVia 
group by s.CompanyName

--Çalýþanlarýn aldýðý sipariþleri ve ortalama sipariþ tutarý(Sipariþ adedi 5 den az olanlar hariç)

select e.EmployeeID,e.FirstName,COUNT(o.OrderID) as [Toplam Sipariþ Adedi] ,AVG(od.UnitPrice * od.Quantity) as 'Ortalama Satýþ Tutarý'
from Employees e 
inner join Orders o on o.EmployeeID = e.EmployeeID 
inner join [Order Details] od on od.OrderID = o.OrderID
group by e.EmployeeID,e.FirstName
having COUNT(o.OrderID) >=300
order by [Toplam Sipariþ Adedi] DESC


--Her bir kategori için o kategoriye ait ürünlerin kategori ortalama fiyatýný bulun.Ortalama fiyatý 50 den fazla olan kategorileri listeleyin.(Kategori isimlerini alfabetik olarak sýralayýn.)


--Her bir müþterinin toplam sipariþ tutarýný hesaplayalým en yüksek tutarý gösterelim.Toplam sipariþ tutarý 1000 den az olanlarý dýþlayalým.






