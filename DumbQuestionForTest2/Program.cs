using System;

namespace DumbQuestionForTest2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool terminate = false;
            int number = 0;
            int errorCount = 0;
            while (!terminate)
            {
                Console.Write("Enter a 3 digits number: ");
                number = int.Parse(Console.ReadLine());
                while ((errorCount < 2) && ((number > 999) || (number < 100)))
                {
                    errorCount++;
                    Console.Write("Enter a 3 digits number: ");
                    number = int.Parse(Console.ReadLine());
                }
                if (errorCount == 2)
                {
                    terminate = !terminate;
                }
                else
                {
                    errorCount = 0;
                    Console.WriteLine("Your number is: {0}", number);
                    Console.Write("Enter a 3 digits number: ");
                    number = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Bye...");
        }
    }
}
