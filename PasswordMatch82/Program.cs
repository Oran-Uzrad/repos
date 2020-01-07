using System;

namespace PasswordMatch82
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "abcddddddddd";
            string s2 = "acbddddddddd";
            int matchCount = 0;
            double matchRatio;

            if (s1.Length != s2.Length)
            {
                Console.WriteLine("Error");
            }
            else
            {
                if ((s1.Length <6) || (s2.Length <6))
                {
                    Console.WriteLine("Error");
                }
                else
                {
                    for (int i = 0; i< s1.Length; i++)
                    {
                        if (s1[i] == s2[i])
                        {
                            matchCount++;
                        }
                    }
                    matchRatio = (double)matchCount / (double)s1.Length;
                    if (matchRatio >= 0.8)
                    {
                        Console.WriteLine("OK");
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }
                }
            }
        }
    }
}
