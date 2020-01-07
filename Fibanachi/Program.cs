using System;

namespace Fibanachi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int a = 1;
            int b = 1 ;

            Console.WriteLine("F1 = " + a);
            Console.WriteLine("F2 = " + b);
            a = a + b;
            Console.WriteLine("F3 = " + a);
            b = b + a;
            Console.WriteLine("F4 = " + b);
            a = a + b;
            Console.WriteLine("F5 = " + a);
        }
    }
}
