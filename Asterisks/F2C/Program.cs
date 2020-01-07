using System;

namespace F2C
{
    class Program
    {
        static void Main(string[] args)
        {
            double f;
            double c;
            Console.WriteLine("Enter F");
            f = double.Parse(Console.ReadLine());
            c = (5.0 / 9.0) * (f - 32.0);
            Console.WriteLine("f was {0} c = {1}", f ,c);
        }
    }
}
