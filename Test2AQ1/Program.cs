using System;

namespace Test2AQ1
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 100, num, index = 0;
            for ( int i = 1; i < 4; i++ )
            {
                num = int.Parse(Console.ReadLine());
                if (num < min)
                {
                    min = num;
                    index = i;
                }
            }
            Console.WriteLine("min {0} was number {1}", min, index);
        }
    }
}
