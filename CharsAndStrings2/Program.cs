using System;

namespace CharsAndStrings2
{
    class Program
    {
        static void Main(string[] args)
        {
            char cUpper = 'A';
            char cLower = 'a';

            Console.WriteLine(" {0} (code: {1}) --> {2} (code: {3})", cUpper, (int)cUpper, cLower, (int)cLower);
            cUpper = (char) (cUpper + 1);
            cLower = (char)(cLower + 1);
            Console.WriteLine(" {0} (code: {1}) --> {2} (code: {3})", cUpper, (int)cUpper, cLower, (int)cLower);
            cUpper = (char)(cUpper + 1);
            cLower = (char)(cLower + 1);
            Console.WriteLine(" {0} (code: {1}) --> {2} (code: {3})", cUpper, (int)cUpper, cLower, (int)cLower);
            cUpper = (char)(cUpper + 1);
            cLower = (char)(cLower + 1);
            Console.WriteLine(" {0} (code: {1}) --> {2} (code: {3})", cUpper, (int)cUpper, cLower, (int)cLower);
            cUpper = (char)(cUpper + 1);
            cLower = (char)(cLower + 1);
            Console.WriteLine(" {0} (code: {1}) --> {2} (code: {3})", cUpper, (int)cUpper, cLower, (int)cLower);

            Console.ReadLine();
        }
    }
}
