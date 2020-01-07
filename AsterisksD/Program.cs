using System;

namespace AsterisksD
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 20; i++) 
            { 
                for (int j = 1; j <= 20; j++)
                {
                    if (i < j)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
