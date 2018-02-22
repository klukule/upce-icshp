using System;

namespace CV01PR01
{
    internal class Program
    {
        private const string NAME = "Josef Novák";
        private const string STREET = "Jindrišská 16";
        private const string CITY = "111 50, Praha 1";

        private static void Main(string[] args)
        {
            Console.WriteLine(NAME);
            Console.WriteLine(STREET);
            Console.WriteLine(CITY);

            Console.WriteLine();

            Console.WriteLine("{0}\n{1}\n{2}", NAME, STREET, CITY);

            Console.WriteLine();

            Console.WriteLine($"{NAME}\n{STREET}\n{CITY}");

            Console.ReadKey();
        }
    }
}