using System;

namespace R4000_85
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int newNum;
            
            Console.Write("Enter a number: ");
            num = int.Parse(Console.ReadLine());

            while (num != 0)
            {
                Console.WriteLine("right most digit {0}" , num % 10);
                num = num / 10;
                Console.WriteLine("Chopped number: {0}", num);
            }
        }
    }
}
