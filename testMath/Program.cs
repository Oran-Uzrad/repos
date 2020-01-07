using System;

namespace testMath
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, tmp;
            Console.WriteLine("Enter a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter b: ");
            b = int.Parse(Console.ReadLine());
            if (b > a)
            {
                tmp = a;
                a = b;
                b = tmp;
            }
            if ((a % b) != 0)
            {
                Console.WriteLine("a and b are strangers");
            }
            else
            {
                Console.WriteLine("a and b are related");
            }
        }
    }
}
