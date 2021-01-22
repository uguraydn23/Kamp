using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Generics!");


            //string yerine int de verebilirsin
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Heyooo Generics");




        }
    }
}
