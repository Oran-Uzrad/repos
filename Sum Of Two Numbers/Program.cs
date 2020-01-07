using System;

namespace Sum_Of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int num1;
            int num2;
            int sum;

            // Write a message to the screen to enter the first number
            // כתוב הודעה למסך להקליד את המספר הראשון

            Console.WriteLine("Insert the first number: ");

            // Read the first number
            // קרא את המספר הראשון

            num1 = int.Parse(Console.ReadLine());

            // Write a message to the screen to enter the first number
            // כתוב הודעה למסך להקליד את המספר הראשון

            Console.WriteLine("Insert the first number: ");

            // Read the first number
            // קרא את המספר הראשון

            num2 = int.Parse(Console.ReadLine());

            // Add the two numbers
            // חבר את שני המספרים

            sum = num1 + num2;

            // Print a message with the result to the screen
            // הדפס את התוצאה למסך

            Console.WriteLine("The sum of the two numbers you entere is: " + sum);


        }
    }
}
