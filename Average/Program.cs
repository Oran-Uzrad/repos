using System;

namespace Average
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, z, w, a;
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            z = int.Parse(Console.ReadLine());
            w = int.Parse(Console.ReadLine());
            a = (x + y + z + w) / 4;
            Console.WriteLine(a);
        }
    }
}
