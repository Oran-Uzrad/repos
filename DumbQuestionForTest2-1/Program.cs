using System;

namespace DumbQuestionForTest2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int errorCount = 0;
            while (errorCount < 3)
            {
                Console.Write("Enter a 3 digits number: ");
                number = int.Parse(Console.ReadLine());
                if ((number > 999) || (number < 100))
                {
                    errorCount++;
                }
                else
                {
                    Console.WriteLine("Your number is: {0}", number);
                    errorCount = 0;
                }
            }
            Console.WriteLine("Bye Bye...");
        }
    }
}
