using System;

namespace ArrayOfStrings1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1;
            string[] arr2 = { "Jaguar", "Wolf", "Lion", "Mouse" };
            string[] arr3 = new string[4];

            arr3[2] = "Shark";
            arr1 = arr3;
            arr3[1] = "Turtle";
            arr1[0] = "Ostrich";

            Console.Write("{0}{1}{2} ", arr1[0][0], arr2[3][2], arr3[1][3]);
            Console.Write("{0}{1} ", arr3[0][0], arr2[1][3]);
            Console.WriteLine("{0}{1}{2}{3}", arr2[0][0], arr1[2][2], arr2[2][1], arr3[1][4]);
        }
    }
}
