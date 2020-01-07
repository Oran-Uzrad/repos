using System;

namespace ArrayReferences
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a1 = { 1, 3, 5, 7 };
            int[] a2 = { 2, 4, 6, 8 , 10 };
            Console.WriteLine(a1[1]);
            Console.WriteLine(a2[2]);
            a1 = a2;
            Console.WriteLine(a1[1]);
            Console.WriteLine(a1[4]);
            Console.WriteLine(a2[4]);
        }
    }
}
