using System;

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
            basvuruManager.krediBasvuruYap(tasitKrediManager);


            
        }
    }
}
