using System;

namespace Asterisks1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                    Console.Write("*");
                    System.Threading.Thread.Sleep(1000);
            }
            for (int i = 0; i < 10; i++)
            {
                Console.Clear();
                for ( int j = 0 ; j < (9 - i) ; j++)
                {
                    Console.Write("*");
                }
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}



