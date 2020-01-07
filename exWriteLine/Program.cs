using System;

namespace exWriteLine
{
    class Program
    {
        static void Main(string[] args)
        {

            int x;
            int y;
            int z;

            Console.Write("x = ");
            x = int.Parse(Console.ReadLine());
            Console.Write("y = ");
            y = int.Parse(Console.ReadLine());
            Console.Write("z = ");
            z = int.Parse(Console.ReadLine());

            Console.WriteLine("Original Orader {0}{1}{2}", x, y, z);
            Console.WriteLine("Second-First-Third {1}{0}{2}", x, y, z);
        }
    }
}
