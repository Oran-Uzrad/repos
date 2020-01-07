using System;

namespace ww1Program
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

            Console.WriteLine("Insert the first number: ");

            /* 
                Read the first number
            */

            num1 = int.Parse(Console.ReadLine());

            // Write a message to the screen to enter the first number

            Console.WriteLine("Insert the second number: ");

            // Read the first number

            num2 = int.Parse(Console.ReadLine());

            // Add the two numbers

            sum = num1 + num2;

            // Print a message with the result to the screen

            Console.WriteLine("The sum of the two numbers you entered is: " + sum);
        }
    }
}

/*
 * Hello World!
Insert the first number:
90
Insert the second number:
7
The sum of the two numbers you entered is: 97

C:\Program Files\dotnet\dotnet.exe(process 21360) exited with code 0.
To automatically close the console when debugging stops, enable Tools->Options->Debugging->Automatically close the console when debugging stops.
Press any key to close this window. . .
*/

