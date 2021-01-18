using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Matematik!");
            DortIslem dortIslem = new DortIslem();
            dortIslem.Topla(5,5);
            dortIslem.Topla(111, 33);
        }
    }
}
