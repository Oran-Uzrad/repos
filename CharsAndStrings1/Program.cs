using System;

namespace CharsAndStrings1
{
    class Program
    {
        static void Main(string[] args)
        {
            char c;

            Console.WriteLine("1. Size of char: {0} bytes", sizeof(char));
            Console.WriteLine("2. Size of int: {0} bytes", sizeof(int));
            
            c = 'a';
            Console.WriteLine("3. c: {0}", c);
            c = (char) (c + 1);
            Console.WriteLine("4. c: {0}", c);
            c = (char)(c - 2);
            Console.WriteLine("5. c: {0}", c);

            Console.ReadLine();
        }
    }
}
