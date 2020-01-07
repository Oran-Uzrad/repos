using System;

namespace AnimationAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            const int size = 20;
            const int arrowSize = 10;
            while (true)
            {

                Console.Clear();
                for (int i = 0; i < size ; i++)
                {
                    for (int j = 0; j < size ; j++) 
                    {
                        if (i == j)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                        
                    }
                    Console.WriteLine();
                    System.Threading.Thread.Sleep(100);
                }

                Console.Clear();

                for (int i = 0; i < 20; i++)
                {
                    for (int j = 0; j < 20; j++)
                    {
                        if ((i == j) || ((i == size -1) && (j >= (size - arrowSize))) || ((j == size - 1) && (i >= (size - arrowSize))))
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
                System.Threading.Thread.Sleep(500);
                
            }
        }
    }
}
