using System;

namespace Asterisks1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            while (true)
            {
                
                Console.Clear();
                System.Threading.Thread.Sleep(200);
                for (int i = 0; i < 20; i++)
                {
                    for (int j = 0; j < 20; j++)
                    {
                        if (i <= j)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                    System.Threading.Thread.Sleep(500);

                }
            }
            
            Console.ReadLine();
        }
    }
}
