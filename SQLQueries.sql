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


