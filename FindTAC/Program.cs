using System;

namespace FindTAC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter dNA string: ");
            string dna = Console.ReadLine();
            int TacCount = 0;

            for (int i = 2; i < dna.Length; i++)
            {
                if ((dna[i] == 'C') && (dna[i-1] == 'A') && (dna[i-2] == 'T'))
                {
                    TacCount++;
                }
            }
            Console.WriteLine("Number of TACs is: {0}", TacCount);
        }
    }
}
