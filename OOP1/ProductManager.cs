using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{   //ProjectService te olabilirdi class in adı. CRUD  CREATE , READ  ,UPDATE , DELETE
    class ProductManager
    {
        public void Add(Product product) //Parametre nin anlamı bana bir tane ürün ver demek,//,(string ad) yazsak string değerinde isim ister
        {
            product.ProductName = "Kamera";
        }

        public void BirSeyYap(int sayi)
        {
            sayi = 99;
        }
    }
}


//encapsulation , butun product(ad,soyad,fiyat vs gibi) ın içine yazacağımıza. Genel gönderiyoruz