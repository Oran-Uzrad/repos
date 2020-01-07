using System;

namespace Test2BQ4Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int err = 0;
            while (err < 3)
            {
                Console.Write("Enter a 2 digits number: ");
                x = int.Parse(Console.ReadLine());
                if ((x > 99) || (x < 10))
                {
                    err++;
                }
                else
                {
                    if (x % 10 == 5)
                    {
                        x = (x / 10) * 10 + 3;
                    }
                    else
                    {
                        if (x % 10 == 3)
                        {
                            x = (x / 10) * 10 + 5;
                        }
                    }
                    if (x / 10 == 3)
                    {
                        x = 50 + (x % 10);
                    }
                    else
                    {
                        if (x / 10 == 5)
                        {
                            x = 30 + (x % 10);
                        }
                    }
                    Console.WriteLine("Your input is: {0}", x);
                    err = 0;
                }
            }
            Console.WriteLine("Done...");
        }
    }
}
