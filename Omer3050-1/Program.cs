using System;

namespace Omer3050_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // If you want to use Random you need to put this line
            Random rnd = new Random();
            int x = rnd.Next(1, 11);
            int y = rnd.Next(1, 11);
            // int z = rnd.Next(1, 11);
            Console.WriteLine("the first number that was picked is:" + x);
            Console.WriteLine("the second number that was picked is:" + y);
            // Console.WriteLine("the third number that was picked is:" + z);

            if( x > y)
            {
                Console.WriteLine("The smallest number is: {0}", y);
                Console.WriteLine("The biggest number is: {0}", x);
            }
            else
            {
                Console.WriteLine("The smallest number is: {0}", x);
                Console.WriteLine("The biggest number is: {0}", y);
            }
            Console.ReadLine();
        }
    }
}
