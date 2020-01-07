using System;
using System.Threading;

namespace NestedForAnimation1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
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
