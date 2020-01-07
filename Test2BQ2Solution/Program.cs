using System;

namespace Test2BQ2Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayRainfall;                    // Keeps the daily rainfall
            int totalRainForTheYear = 0;        // Keeps the accumulating rainfall
            int numberOfBackToBack = 0;         // Number of back to back rainy days
            int numberOfMRS = 0;                // Number of Meaningful rain system
            for (int i = 1; i <= 10; i++)      // I limited the loop to 10, so I can test it. Otherwise should be 365
            {
                Console.Write("Please enter rainfall for day {0}: ", i);
                dayRainfall = int.Parse(Console.ReadLine());
                if( dayRainfall > 0)
                {
                    totalRainForTheYear += dayRainfall;     // Add tje daily rainfor to the total
                    numberOfBackToBack++;                   // Increment the back to back counter
                    if (numberOfBackToBack == 3)            // Everytime we see the third rainy day we increment the number of MRS
                    {
                        numberOfMRS++;
                    }
                }
                else
                {
                    numberOfBackToBack = 0;                 // Clear the back to back counter if on a dry day
                }
            }
            Console.WriteLine("Total rain for the year: {0}, Number of MRS: {1}", totalRainForTheYear, numberOfMRS);
        }
    }
}
