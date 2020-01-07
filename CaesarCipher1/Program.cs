using System;

namespace CaesarCipher1
{
    class Program
    {
        static void Main(string[] args)
        {
            int key;
            string abc = "abcdefghijklmnopqrstuvwxyz";
            while (true)
            {
                Console.Write("Key (1-26)?--> ");
                key = int.Parse(Console.ReadLine());
                Console.Write("Open Text?--> ");
                string openText = Console.ReadLine();
                Console.Write("Ciphered Text--> ");
                for (int i = 0; i < openText.Length; i++)
                {
                    if ((openText[i] >= 'a') && (openText[i] <= 'z'))
                    {
                        Console.Write(abc[((openText[i] - 'a') + key) % 26]);
                    }
                    else
                    {
                        Console.Write(openText[i]);
                    }
                }
                Console.WriteLine("\n");
            }
            
        }
    }
}
