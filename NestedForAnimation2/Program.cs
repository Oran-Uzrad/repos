using System;
using System.Threading;

namespace NestedForAnimation2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 5; i > 0; i--)
            {
                for (int j = 4; j > 0; j--)
                {
                    Console.Write("i = {0}, j = {1}    ", i, j);
                    Thread.Sleep(3500);
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
