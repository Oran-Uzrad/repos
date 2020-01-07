using System;

namespace OneOfEach4000_87
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String ---> ");
            string s = Console.ReadLine();
            bool err = false;
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i + 1; j < s.Length; j++)
                {
                    if ( s[i] == s[j])
                    {
                        err = true;
                    }
                }
            }
            if (!err)
            {
                Console.WriteLine("OK");
            }
            else
            {
                Console.WriteLine("You have duplicates");
            }
        }
    }
}
