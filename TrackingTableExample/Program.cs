using System;

namespace TrackingTableExample
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.Write("Enter a real number: ");
            a = Double.Parse(Console.ReadLine());
            if (a < 0)
            {
                Console.WriteLine("Can not take negative numbers");
            }
            else
            {
                b = Math.Sqrt(a);
                c = Math.Round(b);
                if (b == c)
                {
                    Console.WriteLine("{0} has an integer square root {1}", a, b);
                }
                else
                {
                    Console.WriteLine("{0} does not an integer square root {1}", a, b);
                }
            }
            
        }
    }
}
