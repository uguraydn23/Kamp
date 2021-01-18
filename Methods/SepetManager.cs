using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        //name convention
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urun.Adi );
        }

        public void Eklendi()
        {
            Console.WriteLine("Tebrikler. Sepete eklendi");
        }

        public void Ekle2(string urunAdi, string aciklama , double fiyat , int StokAdeti)
        {
            Console.WriteLine("Tebrikler . Sepete eklendi : "+ urunAdi);
        }
    }
}