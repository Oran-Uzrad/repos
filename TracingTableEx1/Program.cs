using System;

namespace TracingTableEx1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = 0;
            for (int i = x; i >= 1; i--)
            {
                if (i % 2 == 0)
                {
                    y *= (i % 2);
                }
                else {
                    y += (i % 2);
                }
            }
            Console.WriteLine(y);
        }
    }
}
