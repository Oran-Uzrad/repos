using System;

namespace DumbQuestionForTest3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int err = 0;
            while (err < 3)
            {
                Console.Write("Enter a 3 digits number: ");
                x = int.Parse(Console.ReadLine());
                if ((x > 99) || (x < 10))
                {
                    err++;
                }
                else
                {
                    Console.WriteLine("Your input is: {0}", x);
                    err = 0;
                }
            }
            Console.WriteLine("Done...");
        }
    }
}
