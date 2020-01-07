using System;

namespace Test1Park
{
    class Program
    {
        static void Main(string[] args)
        {
            int h;
            double Pay;
            Console.Write("Enter hours: ");
            h = int.Parse(Console.ReadLine());
            if (h <= 3)
            {
                Pay = h * 27.5;
            }
            else
            {
                Pay = 27.5 * 3 + (h - 3) * 10;
            }
            if (Pay > 180)
            {
                Pay = 180;
            }
            Console.WriteLine("Pay: {0}", Pay);
            Console.WriteLine("Average: {0}", Pay / h);
        }
    }
}
