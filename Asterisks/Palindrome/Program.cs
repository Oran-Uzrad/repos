using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int rightMost;
            int leftMost;
            Console.WriteLine("Enter 3 digit number");
            x = int.Parse(Console.ReadLine());
            rightMost = x % 10;
            leftMost = x / 100;
            if (rightMost == leftMost)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("not Palindrome");
            }
        }
    }
}
