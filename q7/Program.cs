using System;

namespace q7
{
    class Program
    {
        static void Main(string[] args)
        {
            double realNumber;
            Console.Write("Enter a real number: ");
            realNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("realNumber = {0}", realNumber * realNumber);
        }
    }
}
