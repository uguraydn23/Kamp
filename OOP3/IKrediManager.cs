using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //Eğer bir interface varsa bu method u kullanmalı
    // Referans alan herkes hesapla methodunu kullanmalıdır
    //Okunurluğunu arttırmakiçin Baş harfi I Büyük olur
    interface IKrediManager
    {
        public void Hesapla();

        public void BirseyYap();
       
    }
}
