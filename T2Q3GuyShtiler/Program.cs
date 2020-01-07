using System;

namespace T2Q3GuyShtiler
{
    class Program
    {
        static void Main(string[] args)
        {
            string pw;
            int count = 0;
            Console.Write("Enter pw: ");
            pw = Console.ReadLine();
            for (int i = 0; i < pw.Length; i++)
            {
                if (((pw[i] >= 'A') && (pw[i] <= 'Z')) || ((pw[i] >= 'a') && (pw[i] <= 'z')))
                {
                    count++;
                }
            }
            if (count > pw.Length * 0.5)
            {
                Console.WriteLine("The pw is legal");
            }
            else
            {
                Console.WriteLine("The pw is ilegal {0}", count);
            }
        }
    }
}
