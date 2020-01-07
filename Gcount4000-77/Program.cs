using System;

namespace Gcount4000_77
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter DNA String: ");
            string dna = Console.ReadLine();
            int gCount = 0;
            int gMax = 0; 
            for ( int i = 0; i < dna.Length; i++)
            {
                if ( dna[i] == 'G')
                {
                    gCount++;
                }
                else
                {
                    if (gCount > gMax)
                    {
                        gMax = gCount;
                    }
                    gCount = 0;
                }
            }
            if (gCount > gMax)
            {
                gMax = gCount;
            }
            Console.WriteLine("Longest G Series: {0}", gMax);
        }
    }
}
