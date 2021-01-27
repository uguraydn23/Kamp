using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello OOP3!");


           // IhtiyacKrediManager ıhtiyacKrediManager = new IhtiyacKrediManager();
         //   ıhtiyacKrediManager.Hesapla();
            //Bunu şu şekildede kullanabiliriz
            // Yine aynı sonuç çıkacak. Interface lerde o interface implemente eden classın referans nosun tutabiliyor 
            IKrediManager krediManager = new IhtiyacKrediManager();
           // krediManager.Hesapla();





            TasitKrediManager tasitKrediManager = new TasitKrediManager();
            // tasitKrediManager.Hesapla();


            KonutKrediManager konutKrediManager = new KonutKrediManager();
            // konutKrediManager.Hesapla();


            BasvuruManager basvuruManager = new BasvuruManager();
          // basvuruManager.krediBasvuruYap(tasitKrediManager);



            List<IKrediManager> kredier = new List<IKrediManager> { konutKrediManager , tasitKrediManager};
            // basvuruManager.KrediOnBilgilendirmesiYap(kredier);







            BasvuruManager basvuruManager1 = new BasvuruManager();
             basvuruManager1.krediBasvuruYap(tasitKrediManager , new DatabaseLoggerService());

            //yada
            //
            // ILoggerService dbloggerService = new DatabaseLoggerService();
            // ILoggerService loggerService = new FileLoggerService();






        }
    }
}