using System;

namespace NestedForTracingTable
{
    class Program
    {
        static void Main(string[] args)
        {
            const int size = 5;
            int t = size / 2;
            for (int i = 0; i < size ; i++)
            {
                for (int j = 0; j < size ; j++)
                {
                    if ((i < (t - j)) || (i >= (size - j + t)))
                    {
                        Console.Write("{0,2}" , (i + j) % size);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
