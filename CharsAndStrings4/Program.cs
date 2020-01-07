using System;

namespace CharsAndStrings4
{
    class Program
    {
        static void Main(string[] args)
        {
            String str = "Japanese Style";
            int strLength = str.Length;
            char c1 = str[0];
            char c2 = str[7];
            char c3 = str[8];
            char c4 = str[str.Length - 1];
            Console.WriteLine("str: " + str);
            Console.WriteLine("strLength: " + strLength);
            Console.WriteLine("c1: " + c1);
            Console.WriteLine("c2: " + c2);
            Console.WriteLine("c3: " + c3);
            Console.WriteLine("c4: " + c4);
            Console.ReadLine();
        }
    }
}
