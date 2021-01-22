using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Collections!");


            //Array
            // stack          , heap(adresi aldı) , değerler  
            string[] isimler = new string[]        { "Uğur", "Ali", "Veli", "AYDIN"};
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);
            // Arraylere sonra dan data ekleyemiyoruz ama collections lara ekleyebiliyoruz.
            // O yüzden collection ı kullanmalıyız.
            // Dataları başka yerlerden alacağımız için , collection daha mantıklı


            //new denilirse yeni bir adres oluşur



            //Collection
            List<string> isimler2 = new List<string> { "Mrs 1 ", "Mrs 2", "Mrs 3" };

            // boylede eklenebilir isimler2.Add("Mrs Collection1");

            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            isimler2.Add("İlke");
            Console.WriteLine(isimler2[3]);
            Console.WriteLine(isimler2[1]);



        }
    }
}
