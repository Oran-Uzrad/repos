using System;

namespace PeleDNA
{
    class Program
    {
        static void Main(string[] args)
        {
            // string DNA = "ACAAGATGCCATTGTCCCCCGGCCTCCTGCTGCTGCTGCTCTCCGGGGCCACGGCCACCGCTGCCCTGCCCCTGGAGGGTGGCCCCACCGGCCGAGACAGCGAGCATATGCAGGAAGCGGCAGGAATAAGGAAAAGCAGCCTCCTGACTTTCCTCGCTTGGTGGTTTGAGTGGACCTCCCAGGCCAGTGCCGGGCCCCTCATAGGAGAGGAAGCTCGGGAGGTGGCCAGGCGGCAGGAAGGCGCACCCCCCCAGCAATCCGCGCGCCGGGACAGAATGCCCTGCAGGAACTTCTTCTGGAAGACCTTCTCCTCCTGCAAATAAAACCTCACCCATGAATGCTCACGCAAGTTTAATTACAGACCTGAA";
            string DNA = "GGGGGGGGACCCGGGGGGGGGGGGGG";
            int longyet = 0;
            int count = 0;
            int where = 0;
            char lookingfor = 'G';
            for (int i = 0; i < DNA.Length; i++)
            {
                if (DNA[i] == lookingfor) { count += 1; }
                else { count = 0; }
                if (count > longyet) { longyet = count; where = i - longyet + 2; }
            }
            Console.WriteLine("The longest sequence of " + lookingfor + "'s is " + longyet + " at the position of " + where + ".");
        }
    }
}
