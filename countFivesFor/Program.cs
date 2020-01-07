using System;

namespace countFivesFor
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Random rnd = new Random();
            int randomNumber;
            int iterationCounter = 0;
            int fivesCounter = 0;
            int i;

            for (i = 0; i < 1000; i++)
            {
                randomNumber = rnd.Next(0, 10);
                iterationCounter++;
                if (randomNumber == 5)
                {
                    fivesCounter++;
                }
            }

            Console.WriteLine("Iterations: {0} Fives: {1}", iterationCounter, fivesCounter);
        }
    }
}
