using System;

namespace _5024SudokuLine
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] l = { 1, 2, 4, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine(CheckSudokuLine(l));
        }

        static bool CheckSudokuLine(int[] line)
        {
            int count;
            bool goodLine = true;
            for (int i = 1; i <= 9; i++)
            {
                count = 0;
                for (int j = 0; j < 9; j++)
                {
                    if (line[j] == i)
                    {
                        count++;
                    }
                }
                if (count != 1)
                {
                    goodLine = false;
                }

            }
            return (goodLine);
        }
    }
}
