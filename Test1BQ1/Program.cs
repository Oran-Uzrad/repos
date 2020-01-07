using System;

namespace Test1BQ1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3, b = 2;
            

            bool c;
            Console.WriteLine(Math.Pow(a, b));
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);
            c = ((a / b) == (a % b));
            if (a > b)
            {
                Console.WriteLine("a>b");
                a++;
            }
            else if (a == b) {
                Console.WriteLine("a==b");
            }
            else if (a<b)
            {
                Console.WriteLine("a<b");
                b--;
            }
            Console.WriteLine("a={0} b={1} c={2}", a, b, c);
        }
    }
}
