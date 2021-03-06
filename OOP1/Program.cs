﻿using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Object oriented");
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2; //2Mobilya ya karşılık geliyor
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitInStock = 3;



            //Üsttekine alternatif kullanım şeklidir
            Product product2 = new Product { Id=2 , CategoryId=5 ,
                UnitInStock=5, ProductName="Kalem"  , UnitPrice=35};




            ProductManager productManager = new ProductManager();
            //ProductManager productManager;    Alternatif kullanımdır
            // Usttek Pascal , üstteki camel case.

            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);




            int sayi = 100;
            productManager.BirSeyYap(sayi);
            Console.WriteLine(sayi);




            productManager.Topla2(3, 6);
            // void ile int arasındaki fark void ile yaptığımızda  2 sayıyı toplar ama onu kullanmak istediğimizde 
            // yani 6 yı kullanmak istediğimizde kullanamayız. Çünkü return edilmiyor , sadece ekrana yazdırıyor.
            // Gidip 2 le çarpmak istediğimde çarpamam. Çünkü console a sadece yazıyor. 



            // Kredi geri dönüş oranı gibi düşün
            // Git hesapla sonra onun üzerinde çalış . Bu yüzden return kullanıyoruz.
            // O yüzden void yerine int kullanıldıi.ProductManger class ında
            int toplamSonucu = productManager.Topla(3, 6);
            Console.WriteLine(toplamSonucu * 2);



        }
    }
}
