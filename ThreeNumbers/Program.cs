
using System;

namespace ThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int x;
            int y;
            int z;
            double d;

            Console.WriteLine("Enetr x");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enetr y");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("Enetr z");
            z = int.Parse(Console.ReadLine());

            Console.WriteLine("First combination {0}{1}{2}", x, y, z);
            Console.WriteLine("Second combination {1}{0}{2}", x, y, z);

            x = x + 4;
            Console.WriteLine("First combination {0}{1}{2}", x, y, z);
            x = x / 5;
            Console.WriteLine("First combination {0}{1}{2}", x, y, z);
            x = x % 5;
            Console.WriteLine("First combination {0}{1}{2}", x, y, z);

            d = 2 / 5;
            Console.WriteLine("First combination " + d);
        }
    }
}
