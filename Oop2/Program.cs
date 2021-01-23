using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello OOP2 PROJECT!");

            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Uğur";
            musteri1.Soyadi = "Aydın";
            musteri1.TcNo = "21212121";


            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "55454";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "22121222";


            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();


            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);





        }
    }
}
