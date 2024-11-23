
--SORULAR--(SUBQUERY �LE)

--ID si 6 olan kullan�c�n�n sat�� yapt��� �r�nlerin kategori ismi
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


--En pahal� �r�n�n fiyat�n� bulunuz

select ProductName from Products where UnitPrice = (Select MAX(UnitPrice) from products)                           


-- En �ok Sipari� verilen �r�n�n ad�n� bulunuz

--select TOP 1 ProductID,Sum(Quantity) from [Order Details] group by ProductID order by Sum(Quantity) desc
select * from Products where ProductID = (select TOP 1 ProductID from [Order Details] group by ProductID order by Sum(Quantity) desc)

--�r�n Stok Miktar� ortalama stok miktarlar�ndan fazla olan �r�nleri listeleyiniz
Select AVG(UnitsInStock) from products
select * from products where UnitsInStock > (Select AVG(UnitsInStock) from products)

--Fiyat� kategori ba��na ortalama �r�n fiyat�ndan y�ksek olanlar� listeleyin.

--Ortalama �r�n Fiyat�
select AVG(UnitPrice) from products 
select * from products 
select Distinct CategoryID from Products where UnitPrice > (select AVG(UnitPrice) from products)
--Products Idlerle Kategorileri birle�tirelim.

select * from Products
select CategoryName from Categories where CategoryID in (select CategoryID from Products where UnitPrice > 100)


--Toplam sipari� tutar� en y�ksek olan m��terinin ad� 

select * from Orders

select OrderID,SUM(Quantity * UnitPrice) from [Order Details] group by OrderID order by SUM(Quantity * UnitPrice) desc

select * from Orders where OrderID = (select TOP 1 OrderID   from [Order Details] group by OrderID order by SUM(Quantity * UnitPrice) desc )

--A���daki sorgudan gelen Customer ID yi ald�k
select CustomerID from Orders where OrderID = (select TOP 1 OrderID   from [Order Details] group by OrderID order by SUM(Quantity * UnitPrice) desc )

select * from Customers where CustomerID = (select CustomerID from Orders where OrderID = (select TOP 1 OrderID   from [Order Details] group by OrderID order by SUM(Quantity * UnitPrice) desc )
)

--11:40 DERS BA�LAR



--JOIN
/*
�li�kisel veri tabanlar�nda birbirleri aras�nda ili�ki bulunana tablolardaki verileri �ekmek i�in kullan�l�r.

1.INNER JOIN
�ki veya daha fazla tabloda e�le�en b�t�n kay�tlar� getirir.


2.LEFT JOIN(LEFT OUTER JOIN)
Sol ilk tabloda bulunan t�m kay�tlar� d�nd�r�r.Sa� tarafta e�le�en kay�t yoksa bunlar null olarak d�ner.


2.RIGHT JOIN(LEFT OUTER JOIN)
Sa� ikinci tabloda bulunan t�m kay�tlar� d�nd�r�r.Sol tarafta e�le�en kay�t yoksa bunlar null olarak d�ner.

3.FULL OUTER JOIN
T�m kay�tlar� d�ner.Sol veya sa�da herhangi birinde e�le�me yoksa bunlar null olarak d�ner.

*/

--Customers tablosu ile Orders tablosunu birle�tirelim.

select * from Customers
select * from Orders

select c.CompanyName,c.ContactName,o.OrderID from Customers c join Orders o on c.CustomerID = o.CustomerID 


--Order tablosunda ge�en her bir kargo firmas�n�n ad�n� getiriniz

select distinct s.CompanyName from Shippers s join Orders o  on o.ShipVia = s.ShipperID 



--Kargo maliyeti en y�ksek olan sipari�i ta��yan kargo firmas�n�n ad�(--Freight kargo maliyeti)
SELECT     s.CompanyName,o.FreightFROM     Orders oJOIN     Shippers s ON o.ShipVia = s.ShipperID order by o.Freight desc

--Kargo isimlerine g�re grupland�rma yaparak toplam tutarda en y�ksek kargo maliyetine sahip olan firma ad�n� getirmek.
select s.CompanyName,SUM(o.Freight) from 
Orders o join Shippers s on s.ShipperID = o.ShipVia 
group by s.CompanyName

--�al��anlar�n ald��� sipari�leri ve ortalama sipari� tutar�(Sipari� adedi 5 den az olanlar hari�)

select e.EmployeeID,e.FirstName,COUNT(o.OrderID) as [Toplam Sipari� Adedi] ,AVG(od.UnitPrice * od.Quantity) as 'Ortalama Sat�� Tutar�'
from Employees e 
inner join Orders o on o.EmployeeID = e.EmployeeID 
inner join [Order Details] od on od.OrderID = o.OrderID
group by e.EmployeeID,e.FirstName
having COUNT(o.OrderID) >=300
order by [Toplam Sipari� Adedi] DESC


--Her bir kategori i�in o kategoriye ait �r�nlerin kategori ortalama fiyat�n� bulun.Ortalama fiyat� 50 den fazla olan kategorileri listeleyin.(Kategori isimlerini alfabetik olarak s�ralay�n.)


--Her bir m��terinin toplam sipari� tutar�n� hesaplayal�m en y�ksek tutar� g�sterelim.Toplam sipari� tutar� 1000 den az olanlar� d��layal�m.






