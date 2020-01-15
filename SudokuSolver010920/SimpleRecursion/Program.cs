using System;

namespace SimpleRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For");
            PrintNumbersFor(1 , 10);
            Console.WriteLine("Rec");
            PrintNumbersRec(1 , 10);
        }

        static void PrintNumbersFor(int n , int limit)
        {
            for (int i = n; i < limit; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void PrintNumbersRec(int n , int limit)
        {
            if (n < limit)
            {
                Console.WriteLine(n);
                PrintNumbersRec(n + 1 , limit);
            }
        }
    }
}
