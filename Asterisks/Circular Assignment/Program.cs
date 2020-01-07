using System;

namespace Circular_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z, tmp;
            String s;
            s = Console.ReadLine();
            Console.WriteLine(s);
            Console.Write("Enter first element: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Enter second element: ");
            y = int.Parse(Console.ReadLine());
            Console.Write("Enter third element: ");
            z = int.Parse(Console.ReadLine());
            tmp = x;
            x = z;
            z = y;
            y = tmp;
            Console.WriteLine("{0} {1} {2}", x, y, z);
        }
    }
}
