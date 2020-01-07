using System;

namespace _5020HowManyMatchingElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a1 = new int[100];
            int[] a2 = new int[100];
            Random rnd = new Random();
            int matchCount = 0;

            for (int i = 0; i < 100; i++)
            {
                a1[i] = rnd.Next(0, 9);
                a2[i] = rnd.Next(0, 9);
            }
            
            for (int i = 0; i < 100; i++)
            {
                if (a1[i] == a2[i])
                {
                    matchCount++;
                }
            }

            Console.WriteLine("Match Count: {0}", matchCount);
        }
    }
}
