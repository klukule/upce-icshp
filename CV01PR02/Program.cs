using System;

namespace CV01PR02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //0x41
            //0x5A
            byte cChar = 0x41;

            for (int i = 0; i < 26; i++)
            {
                Console.WriteLine((char)cChar);
                cChar++;
            }

            Console.WriteLine();
            // --------------------------------------------------------
            cChar = 0x41;

            while (cChar <= 0x5A)
            {
                Console.WriteLine((char)cChar);
                cChar++;
            }

            Console.WriteLine();
            // --------------------------------------------------------
            cChar = 0x41;

            do
            {
                Console.WriteLine((char)cChar);
                cChar++;
            } while (cChar <= 0x5A);

            Console.ReadKey();
        }
    }
}