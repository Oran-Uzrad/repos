using System;

namespace Omer2060_3
{
    class Program
    {
        static void Main(string[] args)
        {
            char num;
            Console.WriteLine("insert a ccapital Letter");
            num = char.Parse(Console.ReadLine());
            Console.WriteLine("the little latter is:" + (char) (num + 32));
            Console.ReadLine();

            // Add your code here
        }
    }
}
