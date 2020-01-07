using System;

namespace F2C
{
    class Program
    {
        static void Main(string[] args)
        {
            double F, C;
            Console.Write("Enter F: ");
            F = double.Parse(Console.ReadLine());
            C = (F - 32) * 5 / 9;
            Console.WriteLine("C = {0}", C);
        }
    }
}
