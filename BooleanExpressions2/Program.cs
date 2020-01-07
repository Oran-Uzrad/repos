using System;

namespace BooleanExpressions2
{
    class BooleanExpressions2
    {
        static void Main(string[] args)
        {
            Header h = new Header();
            h.PrintHeader();

            bool b;
            int x, y, z;

            Console.Write("Enter x: ");
            x= int.Parse(Console.ReadLine());
            Console.Write("Enter y: ");
            y = int.Parse(Console.ReadLine());
            Console.Write("Enter z: ");
            z = int.Parse(Console.ReadLine());
            Console.WriteLine();

            // 1. x is greater than 90
            b = (x > 90);
            Console.WriteLine("1. x is greater than 90: " + b);

            // 2. y is greater than 2000
            // Add your code here

            // 3. z is at least 75
            // Add your code here

            // 4. Sum of x and y is not zero
            // Add your code here

            // 5. x and y are the same
            // Add your code here

            // 6. Sum of x and y equalz z
            // Add your code here

            // 7. x and y are the same
            // Add your code here

            // 8. z is an odd number (מספר אי זוגי)
            // Add your code here

            // 9. x is between -5 and 5
            // Add your code here

            // 10. x is greater than y and greater than z
            // Add your code here

            // 11. x and y is greater than z
            b = (x > y) && (y > z);
            Console.WriteLine("11. x and y is greater than z: " + b);

            // 12. At least one of x or y is greater than 10
            // Add your code here

            // 13. x is odd and y is even or vice versa
            // Add your code here

            // 14. x is divisible by 3 and by 4
            // Add your code here

            // 15. x is a three digits number
            // Add your code here

            // 16. x is a three digits number and at least one of the digits is 5
            // Add your code here


        }
    }
}

    class Header
    {
        public void PrintHeader()
        {
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Boolean expressions Assignment - Summary");
            Console.WriteLine("(a && b) - Logical AND");
            Console.WriteLine("(a || b) - Logical OR");
            Console.WriteLine("!a - Logical NOT");
            Console.WriteLine("(a == b) - Equals");
            Console.WriteLine("(a != b) - Not Equals");
            Console.WriteLine("(a > b) - Greater Than");
            Console.WriteLine("(a > b) - Greater or Equal");
            Console.WriteLine("(a < b) - Less Than");
            Console.WriteLine("(a <= b) - Less than or Equal");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine();
        }
    }

