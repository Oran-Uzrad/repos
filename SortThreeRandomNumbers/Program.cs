using System;

namespace SortThreeRandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int num1, num2, num3, temp;
            num1 = rnd.Next(1, 11);
            num2 = rnd.Next(1, 11);
            num3 = rnd.Next(1, 11);

            Console.WriteLine("Starting with:     num1 = {0}, num2 = {1}, num3 = {2}", num1, num2, num3);
           
            // First swap

            if (num1 > num2)
            {
                temp = num2;
                num2 = num1;
                num1 = temp;
            }
            Console.WriteLine("After first swap:  num1 = {0}, num2 = {1}, num3 = {2}", num1, num2, num3);

            // Second swap

            if (num2 > num3)
            {
                temp = num3;
                num3 = num2;
                num2 = temp;
            }
            Console.WriteLine("After second swap: num1 = {0}, num2 = {1}, num3 = {2}", num1, num2, num3);

            // Third swap

            if (num1 > num2)
            {
                temp = num2;
                num2 = num1;
                num1 = temp;
            }
            Console.WriteLine("After third swap:  num1 = {0}, num2 = {1}, num3 = {2}", num1, num2, num3);
        }
    }
}
