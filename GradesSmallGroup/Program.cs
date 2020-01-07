using System;

namespace GradesSmallGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int count = 0;
            int maxGrade = -1;
            Console.Write("Enter Grade: ");
            a = int.Parse(Console.ReadLine());
            while (a != -1)
            {
                count++;
                Console.Write("Enter Grade: ");
                a = int.Parse(Console.ReadLine());

                // max grade
                if (a > maxGrade)
                {
                    maxGrade = a;
                }
            }
            Console.WriteLine("The number of grade is: {0}", count);
            Console.WriteLine("The max grade is: {0}", maxGrade);
            Console.ReadLine();
        }
    }
}
