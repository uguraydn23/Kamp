-- Select -- Seç demektir
--ANSI
Select * from Customers



--Customerstan Contactname , companyname ve city kolonlarını getir
Select ContactName,CompanyName,City from Customers



-- ContactName , adi olarak gelsin
Select ContactName Adi,CompanyName SirketAdi,City Sehir from Customers


--Customers tablosundan Şehri London olanlar gelsin
Select * from Customers WHERE City = 'London'


--case insensitive (Büyük küçük harf duyarsız) ,, Products da categoryid si 1 olanı getir
select * from Products where CategoryID=1


--case insensitive (Büyük küçük harf duyarsız) ,, Products da categoryid si 1 olanı getir
--Örn. Eticarette kategorisi bilgisayar veya cep telefonu olanlar gelir
select * from Products where CategoryID=1 or CategoryID=3

--Örn. Eticarette kategorisi bilgisayar ve fiyatı 10 dan büyük olanları getir
select * from Products where CategoryID=1 and UnitPrice>=10



---***---**---******************-*******************-*************

-- order by -- Sıralama demektir
-- Productsları products name e göre sıralar
select * from Products order by ProductName

--CategoroyId si ve productname e göre sıralama , kendi içlerinde sırala
select * from Products order by CategoryID,ProductName

-- Fiyata göre sırala 
select * from Products order by UnitPrice


-- Fiyata göre sırala artan
select * from Products order by UnitPrice asc


-- Fiyata göre sırala düşen
select * from Products order by UnitPrice desc


-- categorysi 1(örneğin. 1 araba olsun) ve Fiyata göre sırala düşen
-- arabayı fiyatı azalana göre sırala
select * from Products where CategoryID=1 order by UnitPrice desc







---***--***  count (say, adeti ver)-------***********-----------------*********--
--Producttaki toplam sayıyı verir. Buradada örnek olarak benim 10k ürünüm var vs gibi.
Select COUNT(*) from Products


-- Categoryıd si 2 olan ürünlerin adetini ver
Select COUNT(*) from Products where CategoryID=2


-- Adet olarak yaz
Select COUNT(*) Adet from Products


-- Bütün kategorileri tekrar etmeyece şekilde listele ve adetlerini ver
select CategoryID,COUNT(*) from Products group by CategoryID


--Ürün Sayısı 10 dan az olan kategorileri listele
select CategoryID,COUNT(*) from Products group by CategoryID having COUNT(*)<10

--
select CategoryID,COUNT(*) from Products where UnitPrice>20
group by CategoryID having COUNT(*)<10






--*************************-- Joın------------*****************************---------
-- categoryıd si 1,2 yerine direkt ismini getiririz
-- joinleriz , tabloları birleştiririz
select *
from Products inner join Categories
on Products.CategoryID=Categories.CategoryID


-- joinleriz , tabloları birleştiririz,
select Products.ProductID, Products.ProductName, Products.ProductID, Products.UnitPrice, Categories.CategoryName
from Products inner join Categories
on Products.CategoryID=Categories.CategoryID


--DTO Data transformation object

--
select Products.ProductID, Products.ProductName, Products.ProductID, Products.UnitPrice, Categories.CategoryName
from Products inner join Categories
on Products.CategoryID=Categories.CategoryID
where Products.UnitPrice>10





--*************************-- Inner Joın------------*****************************---------
-- Sadece eşleşen dataları getirir , eşleşmeyenleri getirmez
-- ortak tabloları bulmamız gerekiyor
-- products a p dedik , order details e od dedik

-- Inner join bağladığını her iki tabloda eşleşen
-- Left join bağladığın iki tabloda solda olup sağda olmayanları getir
-- Right join bağladığın tabloada sağda olup solda olmayanları getir

-- 2 den fazla tabloyu join etmek istersen inner join le devam edersin

Select * from Products p inner join [Order Details] od
on p.ProductID = od.ProductID


-- Solda olup , sağda olmayanlar
-- Satışı olmayanlar üründe olup  , satışı olmayanlar
Select * from Products p left join [Order Details] od
on p.ProductID = od.ProductID


-- Müsteri de olup siparişte olmayanlar
-- Left join solda olup sağda olmayanları getir
select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID

select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null


-- Right join sağda olup solda olmayanları getir
select * from Customers c right join Orders o
on c.CustomerID = o.CustomerID


-- 3 tabloyu joinle
select * from Products p inner join [Order Details] od
on p.ProductID = od.ProductID
inner join Orders o 
on o.OrderID = od.OrderID
