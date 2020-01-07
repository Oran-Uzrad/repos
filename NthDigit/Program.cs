using System;

namespace NthDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, position, powerOfTen = 1, d;
            Console.Write("Integer number--> ");
            number = int.Parse(Console.ReadLine());
            Console.Write("Integer position--> ");
            position = int.Parse(Console.ReadLine());

            for( int i = 0; i < position; i++)
            {
                powerOfTen *= 10;
            }
            d = (number / powerOfTen) % 10;

            Console.WriteLine("d--> {0}", d);

        }
    }
}
