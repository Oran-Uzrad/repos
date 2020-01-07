using System;

namespace Fibonacci4000_84
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 1;
            int c;
            int n;
            Console.Write("How many Elements? ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine(a);
            Console.WriteLine(b);
            for (int i = 0; i < (n-2); i++)
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
            }
        }
    }
}
