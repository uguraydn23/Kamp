using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        // Method injection
        public void krediBasvuruYap(IKrediManager krediManager , ILoggerService loggerService)
        {

            krediManager.Hesapla();
            loggerService.Log();
        }



                                                // Bana bir liste var 
                                                //Ikredimanger olsun
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)

        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
