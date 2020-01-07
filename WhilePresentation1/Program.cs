using System;

namespace WhilePresentation1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;

            while (n != 5)
            {
                Console.Write("Please enter 5: ");
                n = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Thank you!");
        }
    }
}
