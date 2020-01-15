using System;

namespace SudokuSolver011520
{
    class Program
    {
        public static int solveCalled = 0;
        public static int solveReturnTrue = 0;
        public static int solveReturnFalse = 0;
        public static int checkMatrixCalled = 0;
        static void Main(string[] args)
        { 
            int[,] na = new int[9, 9];                  
            bool[,] fa = new bool[9, 9];                
            LoadMatrix(na, fa, 1);
            // ReadFixed(na, fa);
            Console.WriteLine("Challenge: ");
            PrintMatrix(na, fa);
            Console.Write("Hit any key to solve...");
            Console.ReadLine();
            if (Solve(na , fa , 0 , 0 ))
            {
                Console.WriteLine("Solution: ");
                PrintMatrix(na, fa);
            }
            else
            {
                Console.WriteLine("No Solution");
            }
            Console.WriteLine("Statistics:");
            Console.WriteLine("\tSolve called: {0}", solveCalled);
            Console.WriteLine("\tSolve returned true: {0}", solveReturnTrue);
            Console.WriteLine("\tSolve returned false: {0}", solveReturnFalse);
            Console.WriteLine("\tCheckMatrix called: {0}", checkMatrixCalled);
        }

        static bool Solve(int[,] n , bool[,] f , int row , int col)
        {
            int nextRow;
            int nextCol;
            int val;

            solveCalled++;
            
            nextRow = row + (col / 8);
            nextCol = (col + 1) % 9;

            if (f[row, col])                           
            {
                if (nextRow == 9)                       
                {
                    return CheckMatrix(n);
                }
                else
                {
                    return Solve(n, f, nextRow, nextCol);
                }
            }
            else
            {
                val = 1;
                n[row, col] = val;
                while (val < 10)
                {
                    if (!CheckMatrix(n))
                    {
                        val++;
                        n[row, col] = val;
                    }
                    else
                    {
                        if (nextRow < 9)
                        {
                            if (!Solve(n, f, nextRow, nextCol))
                            {
                                val++;
                                n[row, col] = val;
                            }
                            else
                            {
                                solveReturnTrue++;
                                return true;
                            }
                        } 
                        else
                        {
                            return true;
                            solveReturnTrue++;
                        }
                    }
                }
                solveReturnFalse++;
                n[row, col] = 0;
                return false;
            }
        }

        static bool CheckLine(int[] line)
        {
            bool check = true;
            int count;
            for (int i = 1; i <= 9; i++)
            {
                count = 0;
                for (int j = 0; j < line.Length; j++)
                {
                    if (line[j] == i)
                    {
                        count++;
                    }
                }
                if (count > 1)
                {
                    check = false;
                }
            }
            return check;
        }

        static bool CheckRow(int[,] matrix, int lineIndex)
        {
            int[] line = new int[9];
            bool check;
            for (int i = 0; i < 9; i++)
            {
                line[i] = matrix[lineIndex, i];
            }
            check = CheckLine(line);
            return check;
        }

        static bool CheckColumn(int[,] matrix, int colIndex)
        {
            int[] line = new int[9];
            bool check;
            for (int i = 0; i < 9; i++)
            {
                line[i] = matrix[i, colIndex];
            }
            check = CheckLine(line);
            return check;
        }

        static bool CheckBox(int[,] matrix, int boxI , int boxJ)
        {
            int[] line = new int[9];
            int lineIndex = 0;
            bool check;
            
            for (int i = boxI; i <= (boxI + 2); i++)
            {
                for (int j = boxJ; j <= (boxJ + 2); j++)
                {
                    line[lineIndex] = matrix[i , j];
                    lineIndex++;
                }
                    
            }
            check = CheckLine(line);
            return check;
        }

        static bool CheckAllRows(int [,] matrix)
        {
            bool check = true;
            for (int i = 0; i < 9; i++)
            {
                if (!CheckRow(matrix , i))
                {
                    check = false;
                }
            }
            return check;
        }

        static bool CheckAllColumns(int[,] matrix)
        {
            bool check = true;
            for (int i = 0; i < 9; i++)
            {
                if (!CheckColumn(matrix, i))
                {
                    check = false;
                }
            }
            return check;
        }

        static bool CheckAllBoxes(int[,] matrix)
        {
            bool check = true;
            for (int i = 0; i < 9; i += 3)
            {
                for (int j = 0; j < 9; j += 3)
                {
                    if (!CheckBox(matrix , i , j))
                    {
                        check = false;
                    }
                }
            }
            return check;
        }

        static bool CheckMatrix(int[,] matrix)
        {
            bool check = true;
            checkMatrixCalled++;
            if (!CheckAllRows(matrix))
            {
                check = false;
            }

            if (!CheckAllColumns(matrix))
            {
                check = false;
            }

            if (!CheckAllBoxes(matrix))
            {
                check = false;
            }
            return check;
        }

        static void LoadMatrix(int[,] numMatrix, bool[,] fixedMatrix, int test)
        {
            int[,] m = GetMatrixReference(test);
            for (int i = 0; i < 9; i++ )
            {
                for ( int j = 0; j < 9; j++)
                {
                    numMatrix[i, j] = m[i, j];
                    fixedMatrix[i, j] = (m[i, j] != 0);
                }
            }
            return;
        }

        static int[,] GetMatrixReference(int index)
        {
            int[][,] testsRefs = new int[20][,];
            testsRefs[0] = new int[9, 9]    {
                                                { 0 , 0 , 0 , 0 , 0 , 0 , 0 , 2 , 6 } ,
                                                { 7 , 2 , 0 , 0 , 3 , 0 , 9 , 8 , 0 } ,
                                                { 0 , 5 , 0 , 0 , 2 , 4 , 1 , 0 , 7 } ,
                                                { 9 , 3 , 0 , 0 , 7 , 2 , 0 , 0 , 0 } ,
                                                { 4 , 0 , 0 , 5 , 0 , 3 , 0 , 0 , 9 } ,
                                                { 0 , 0 , 0 , 9 , 1 , 0 , 0 , 4 , 3 } ,
                                                { 3 , 0 , 4 , 2 , 5 , 0 , 0 , 6 , 0 } ,
                                                { 0 , 7 , 6 , 0 , 8 , 0 , 0 , 1 , 5 } ,
                                                { 1 , 8 , 0 , 0 , 0 , 0 , 0 , 0 , 0 }
                                            };
            testsRefs[1] = new int[9, 9]    {
                                                { 0 , 0 , 0 , 0 , 4 , 0 , 0 , 0 , 0 } ,
                                                { 2 , 0 , 9 , 8 , 0 , 0 , 0 , 6 , 0 } ,
                                                { 3 , 1 , 0 , 0 , 0 , 0 , 0 , 0 , 4 } ,
                                                { 0 , 9 , 0 , 0 , 0 , 2 , 0 , 7 , 8 } ,
                                                { 0 , 0 , 0 , 7 , 0 , 1 , 0 , 0 , 0 } ,
                                                { 1 , 2 , 0 , 4 , 0 , 0 , 0 , 5 , 0 } ,
                                                { 8 , 0 , 0 , 0 , 0 , 0 , 0 , 9 , 5 } ,
                                                { 0 , 7 , 0 , 0 , 0 , 5 , 3 , 0 , 2 } ,
                                                { 0 , 0 , 0 , 0 , 6 , 0 , 0 , 0 , 0 }
                                            };
            return testsRefs[index];
        }

        static void PrintMatrix(int[,] n , bool[,] f)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (f[i , j])
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("{0}  ", n[i, j]);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    { 
                        if (n[i , j] == 0)
                        {
                            Console.Write("-  ");
                        }
                        else
                        {
                            Console.Write("{0}  ", n[i, j]);
                        }
                    }
                }
                Console.WriteLine();
            }
        }

        static void ReadFixed(int[,] n , bool[,] f)
        {
            int row, col, val;
            string[] numsStr;
            Console.Write("Enter constraint ('row column value', or 'done'): ");
            string inputStr = Console.ReadLine();
            while (inputStr != "done")
            {
                numsStr = inputStr.Split(' ');
                row = int.Parse(numsStr[0]);
                col = int.Parse(numsStr[1]);
                val = int.Parse(numsStr[2]);
                Console.WriteLine("{0} {1} {2}", row, col, val);
                if (((row < 1) || (row > 9)) ||
                        ((col < 1) || (col > 9)) ||
                        ((val < 1) || (val > 9))) 
                {
                    Console.Write("Ilegal input string, ");
                    Console.Write("Enter constraint ('row column value', or 'done'): ");
                }
                else
                {
                    n[row - 1, col - 1] = val;
                    f[row - 1, col - 1] = true;
                }
                Console.Write("Enter constraint ('row column value', or 'done'): ");
                inputStr = Console.ReadLine();
            }
        }
    }
}
