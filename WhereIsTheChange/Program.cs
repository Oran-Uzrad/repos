using System;

namespace WhereIsTheChange
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 3;
            WhereIsTheChange(num);
            Console.WriteLine("num in main is " + num);
        }

        static void WhereIsTheChange(int num)
        {
            num = num + 5;
            Console.WriteLine("num in method is " + num);
        }
    }
}
