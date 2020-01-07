using System;

namespace Test2BQ3Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter password: ");
            int letterCounter = 0;              // Counts the number of letters
            string pw = Console.ReadLine();
            for (int i = 0; i < pw.Length; i++)
            {
                if (((pw[i] >= 'a') && (pw[i] <= 'z')) || ((pw[i] >= 'A') && (pw[i] <= 'Z'))) // Since letters are together in the ascii table
                {
                    letterCounter++;            // increment the number of letters
                }
            }
            Console.WriteLine("There are {0} letters in the password", letterCounter);
            if (letterCounter >= (pw.Length / 2))   // Check if at least half is letters
            {
                Console.WriteLine("The password is legal");
            }
            else
            {
                Console.WriteLine("The password is illegal");
            }
        }
    }
}
