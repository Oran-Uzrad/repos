using System;

namespace NestedFor1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 10; i >= 1; i--)
            {
                for( int j = 10; j >= 1 ; j-- )
                {
                    Console.Write("{0,5}", (i * j));
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
