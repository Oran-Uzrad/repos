using System;

namespace Random1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                int x = rnd.Next(1, 11);
                Console.WriteLine(x);
            }
            Console.ReadLine();
        }
    }
}
