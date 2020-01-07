using System;

namespace GradesStatistics
{
    class Program
    {
        static void Main(string[] args)
        {

            const int higestGradePossible = 100;
            const int lowestGradePossible = 0; 
            const int passingGrade = 55;
            const int excelGrade = 90;

            int currentGrade;
            int numberOfGrades = 0;
            int maxGrade = lowestGradePossible;
            int nextMaxGrade = lowestGradePossible;
            int minGrade = higestGradePossible;
            int numberOfExcels = 0;
            int numberOfFailures = 0;
            bool highestPossibleFlag = false;
            int sumOfGrades = 0;

            Console.Write("Enter Next Grade: ");
            currentGrade = int.Parse(Console.ReadLine());
            while (currentGrade != -1)
            {
                // Count the number of grades
                numberOfGrades++;

                // Sum the grades
                sumOfGrades += currentGrade;

                // Check if current grade is the highest so far
                if (currentGrade >= maxGrade)
                {
                    nextMaxGrade = maxGrade;
                    maxGrade = currentGrade;
                }
                else if (currentGrade > nextMaxGrade)
                {
                    nextMaxGrade = currentGrade;
                }

                // Check if current grade is the lowest so far
                if ( currentGrade < minGrade)
                {
                    minGrade = currentGrade;
                }

                // Count the number of excel grades
                if ( currentGrade >= excelGrade)
                {
                    numberOfExcels++;
                }

                // Count the number of failing grades
                if (currentGrade < passingGrade)
                {
                    numberOfFailures++;
                }

                // Update the highest flag
                if (currentGrade == higestGradePossible)
                {
                    highestPossibleFlag = true;
                }

                // Read next grade
                Console.Write("Enter Next Grade: ");
                currentGrade = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Number of Grades Entered: {0}", numberOfGrades);
            Console.WriteLine("Highest Grade: {0}", maxGrade);
            Console.WriteLine("Lowest Grade: {0}", minGrade);
            Console.WriteLine("The difference between the highest grade and the next one down is: {0}", maxGrade - nextMaxGrade);
            Console.WriteLine("Number of Excel Grades: {0}", numberOfExcels);
            Console.WriteLine("Number of Failing Grades: {0}", numberOfFailures);
            if (highestPossibleFlag)
            {
                Console.WriteLine("We have as least one highest possible");
            }
            else
            {
                Console.WriteLine("No highest possible grade");

            }
            Console.WriteLine("Grades Average: {0}", ( (double) sumOfGrades / (double) numberOfGrades));
        }
    }
}
