using System;

namespace Fibonachi1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 1;

            Console.WriteLine("F1 = {0}" , a);
            Console.WriteLine("F2 = {0}" , b);
            a = a + b;
            Console.WriteLine("F3 = {0}", a);
            b = a + b;
            Console.WriteLine("F4 = {0}", b);
            a = a + b;
            Console.WriteLine("F5 = {0}", a);
            b = a + b;
            Console.WriteLine("F6 = {0}", b);
            Console.ReadLine();
        }
    }
}
