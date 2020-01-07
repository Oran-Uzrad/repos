using System;

namespace TimeCalc
{
    class Program
    {
        static void Main(string[] args)
        {

            // 1. Define variables

            string currentTime;
            double shekelAmount;
            const double rate = 0.5;
            string currentTimeHourStr = "";
            int currentTimeHourInt;
            string currentTimeMinutesStr = "";
            int currentTimeMinutesInt;
            int parkingPeriod;
            int parkingPeriodHours;
            int parkingPeriodMinutes;
            int expirationTimeMinutes;
            int expirationTimeHour;
            string expirationTimeHourStr = "";
            string expirationTimeMinutesStr = "";
            string expirationTimeStr;

            // 2. Get current time and shekels paid

            Console.Write("Enter current time: ");
            currentTime = Console.ReadLine();
            Console.Write("Enter shekel ampun: ");
            shekelAmount = double.Parse(Console.ReadLine());

            // 3. Parse current time string to hours and minutes

            currentTimeHourStr = currentTimeHourStr + currentTime[0] + currentTime[1];
            currentTimeHourInt = int.Parse(currentTimeHourStr);
            currentTimeMinutesStr = currentTimeMinutesStr + currentTime[3] + currentTime[4];
            currentTimeMinutesInt = int.Parse(currentTimeMinutesStr);

            // 4. Calculate parking period

            parkingPeriod = (int) Math.Round(shekelAmount / rate);

            // 5. Break parking period to hours and minutes

            parkingPeriodHours = parkingPeriod / 60;
            parkingPeriodMinutes = parkingPeriod % 60;

            // 6. Calculate time of expiration

            expirationTimeMinutes = (currentTimeMinutesInt + parkingPeriodMinutes) % 60;
            expirationTimeHour = currentTimeHourInt + parkingPeriodHours;
            expirationTimeHour = expirationTimeHour + ((currentTimeMinutesInt + parkingPeriodMinutes) / 60);
            expirationTimeHour = expirationTimeHour % 24;

            // 7. Build the otput string and print it out
            
            if (expirationTimeHour < 10)
            {
                expirationTimeHourStr = expirationTimeHourStr + "0" + expirationTimeHour;
            }
            else
            {
                expirationTimeHourStr = expirationTimeHourStr + expirationTimeHour;
            }
            if (expirationTimeMinutes < 10)
            {
                expirationTimeMinutesStr = expirationTimeMinutesStr + "0" + expirationTimeMinutes;
            }
            else
            {
                expirationTimeMinutesStr = expirationTimeMinutesStr + expirationTimeMinutes;
            }
            expirationTimeStr = "Expiration time: " + expirationTimeHourStr + ":" + expirationTimeMinutesStr;
            Console.WriteLine(expirationTimeStr);

            Console.ReadLine();

        }
    }
}
