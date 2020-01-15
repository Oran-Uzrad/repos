using System;

namespace _5023NamesDraw
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[5];
            Random rnd = new Random();
            int nextIndex;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Next Name: ");
                names[i] = Console.ReadLine();
            }
            for (int i = 0; i < 5; i++)
            {
                nextIndex = rnd.Next(0, 5);
                while (names[nextIndex] == "")
                {
                    nextIndex = rnd.Next(0, 5);
                }
                Console.WriteLine(names[nextIndex]);
                names[nextIndex] = "";
            }
        }
    }
}
