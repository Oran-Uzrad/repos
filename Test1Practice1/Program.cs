using System;

namespace Test1Practice1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Please type a number and press Enter");
            x = int.Parse(Console.ReadLine());
            y = x * x;
            Console.WriteLine("x is {0}, y is {1}", x, y);

//         int x, y;
//         Console.WriteLine("Please type a number and press Enter");
//         x = int.Parse(Console.ReadLine());
//         y = x * x;
//         Console.WriteLine("x is {0}, y is {1}", x, y);
        }
    }
}
