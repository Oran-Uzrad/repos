using System;

namespace Test1Cellular
{
    class Program
    {
        static void Main(string[] args)
        {
            int m;
            double Pay;
            double Average;
            Console.Write("Enter numbers of minutes: ");
            m = int.Parse(Console.ReadLine());
            if (m < 65)
            {
                Pay = m * 1.5;
            }
            else
            {
                Pay = 65 * 1.5 + (m - 65) * 1.2;
            }
            Average = Pay / m;
            Console.WriteLine("Pay: {0}", Pay);
            Console.WriteLine("Average: {0}", Average);

            Console.ReadLine();
        }
    }
}
