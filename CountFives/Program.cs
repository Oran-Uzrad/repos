using System;

namespace CountFives
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int randomNumber;
            int iterationCounter = 0;
            int fivesCounter = 0;

            randomNumber = rnd.Next(0, 10);
            iterationCounter++;
            if (randomNumber == 5)
            {
                fivesCounter++;
            }

            randomNumber = rnd.Next(0, 10);
            iterationCounter++;
            if (randomNumber == 5)
            {
                fivesCounter++;
            }

            randomNumber = rnd.Next(0, 10);
            iterationCounter++;
            if (randomNumber == 5)
            {
                fivesCounter++;
            }

            Console.WriteLine("Iterations: {0} Fives: {1}", iterationCounter, fivesCounter);

        }
    }
}
