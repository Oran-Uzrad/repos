using System;

namespace Rainfall
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayRain;
            int totalRainfall = 0;
            int maxRainfallOneDay = 0;
            int dayOfMax = -1;
            int sequenceLength = 0;
            int sequenceMax = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.Write("Please enter rainfall for day {0}: ", i);
                dayRain = int.Parse(Console.ReadLine());

                totalRainfall += dayRain;

                if (dayRain > maxRainfallOneDay)
                {
                    maxRainfallOneDay = dayRain;
                    dayOfMax = i;
                }

                if (dayRain > 0)
                {
                    sequenceLength++;
                }
                else
                {
                    if (sequenceLength > sequenceMax)
                    {
                        sequenceMax = sequenceLength;
                    }
                    sequenceLength = 0;
                }
            }
            Console.WriteLine("Total rainfall for the year was: {0}mm", totalRainfall);
            Console.WriteLine("The maximum daily rainfall was {0}mm and it happened on day {1}", maxRainfallOneDay, dayOfMax);
            Console.WriteLine("Longest sequence of rainy days was {0}", sequenceMax);
        }
        
    }
}
