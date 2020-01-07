using System;

namespace Test2EshkolBQ1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 9, sum = 0;
            for (int i = 0; i < 5; i++)
            {
                sum = sum + num;
                Console.WriteLine("{0}, {1}", num, sum);
                if (num % 2 == 0)
                {
                    num = num / 2;
                }
                else
                {
                    num = 3 * num + 1;
                }
            }
        }
    }
}
