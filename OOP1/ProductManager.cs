using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{   //ProjectService te olabilirdi class in adı. CRUD  CREATE , READ  ,UPDATE , DELETE
    class ProductManager
    {
        public void Add(Product product) //Parametre nin anlamı bana bir tane ürün ver demek,//,(string ad) yazsak string değerinde isim ister
        {
            Console.WriteLine(product.ProductName + "eklendi");
        }

        public void Update (Product product)
        {
            Console.WriteLine(product.ProductName + "güncellendi");
        }


        public int Topla(int sayi1 , int sayi2) //void ile int arasındaki fark
        {
            return sayi1 + sayi2;
        }

        // void ile int arasındaki fark void ile yaptığımızda  2 sayıyı toplar ama onu kullanmak istediğimizde 
        // yani 6 yı kullanmak istediğimizde kullanamayız. Çünkü return edilmiyor , sadece ekrana yazdırıyor.
        // Gidip 2 le çarpmak istediğimde çarpamam. Çünkü console a sadece yazıyor. 
        // int yaptığıp return edince 3,6 vernce sonucu toplayabiliriz.

        public void Topla2(int sayi1, int sayi2) //void ile int arasındaki fark
        {
            // return yazılamaz  return sayi1 + sayi2;
            Console.WriteLine(sayi1 + sayi2);
        }

        // void ile int arasındaki fark void ile yaptığımızda  2 sayıyı toplar ama onu kullanmak istediğimizde 
        // yani 6 yı kullanmak istediğimizde kullanamayız. Çünkü return edilmiyor , sadece ekrana yazdırıyor.


        public void BirSeyYap(int sayi)
        {
            sayi = 99;
        }
    }
}


//encapsulation , butun product(ad,soyad,fiyat vs gibi) ın içine yazacağımıza. Genel gönderiyoruz