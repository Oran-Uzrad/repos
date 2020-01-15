using System;

namespace _5026_Multidimentional_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int[] line;
            int[,] sdkNums = {
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

            x = GetCell(sdkNums, 0, 0);
            Console.WriteLine(x);
            x = GetCell(sdkNums, 4, 8);
            Console.WriteLine(x);
            line = GetRow(sdkNums, 3);
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine(line[i]);
            }
            line = GetColumn(sdkNums, 4);
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine(line[i]);
            }
        }

        // GetCell takes a reference to a 9x9 array, a and b as parameters 
        // and returns the value in the row a and column b
        // Complete the code of the method
        static int GetCell( int[,] arr ,int a , int b)
        {
            int returnValue = 0;
            return returnValue;
        }

        // GetRow takes a reference to a 9x9 array and a row index as parameters
        // The method returns a reference to a uni dimentional array of size 9 that 
        // contains the values of the row indicated by the row parameter
        // Complete the code of the method
        static int[] GetRow(int[,] arr, int row)
        {
            int[] returnArr = new int[9];
            return returnArr;
        }

        // GetColumn takes a reference to a 9x9 array and a column index as parameters
        // The method returns a reference to a uni dimentional array of size 9 that 
        // contains the values of the column indicated by the col parameter
        // Complete the code of the method
        static int[] GetColumn(int[,] arr, int col)
        {
            int[] returnArr = new int[9];
            return returnArr;
        }
    }
}
