using System;

namespace ReverseMtWith7Boom
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            for (int i = 10; i >= 1; i--)
            {
                for (int j = 10; j >= 1; j--)
                {
                    n = i * j;
                    if (((n % 7) == 0) || ((n / 10) == 7) || ((n % 10) == 7))
                    {
                        Console.Write("  Boom");
                    }
                    else
                    {
                        Console.Write("{0,6}", n);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
