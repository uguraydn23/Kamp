using System;
using System.Collections.Generic;
using System.Text;

namespace Oop2
{

    //Miras , inheritance aldı
    // Tuzelmüsteri bir müşteridir.
    // Musteride olanları , gerçekte alıyor.
    //
    class GercekMusteri :Musteri
    {
        public string TcNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
    }
}
