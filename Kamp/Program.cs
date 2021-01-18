using System;

namespace Kamp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("This is uğur");
            string kategoriEtiketi = "Kategori";
            Console.WriteLine(kategoriEtiketi);
            Kurs kurs1 = new Kurs();
            kurs1.ad = "Java";
            kurs1.yas = 10;

            Kurs kurs2 = new Kurs();
            kurs2.yas = 20;

            Console.WriteLine(kurs1.ad);

        }

    }

    class Kurs
    {
        public string ad { get; set; }

        public int yas { get; set; }
    }
}
