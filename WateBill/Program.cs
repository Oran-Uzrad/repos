using System;

namespace WateBill
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double Consumption;
            double sum;
            double ave;
            double lowRateAlloc;
            Console.Write("Enter number of people in household: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("EnternMonthly consumption: ");
            Consumption = Double.Parse(Console.ReadLine());

            lowRateAlloc = n * 3.4;
            sum = Math.Min(lowRateAlloc, Consumption) * 6.5;
            sum = sum + Math.Max(0, Consumption - (n * 3.4)) * 11.3;
            sum = sum * 1.17;
            ave = sum / Consumption;

            Console.WriteLine("Pay: {0}, Ave: {1}", sum, ave);

        }
    }
}
