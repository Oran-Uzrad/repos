using System;

namespace Graphical_presentation_of_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int d;
            Console.Write("Please enter an integer: ");
            num = int.Parse(Console.ReadLine());
            while (num != 0)
            {
                d = num % 10;
                for (int i = 0; i < d; i++ )
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                num = num / 10;
            }
        }
    }
}
