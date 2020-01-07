using System;

namespace ReverseInteger4000_85
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int lsd;
            int newNumber = 0;
            Console.WriteLine("Number--> ");
            number = int.Parse(Console.ReadLine());
            while(number != 0)
            {
                lsd = number % 10;
                newNumber = newNumber * 10 + lsd;
                number = number / 10;
            }
            Console.WriteLine(newNumber);
        }
    }
}
