using System;

namespace CV01PR03
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string rc = Console.ReadLine();
            if (rc.Contains("/"))
            {
                rc = rc.Split('/')[0];
            }

            if (rc.TryParseGender(out Gender gender))
            {
                Console.WriteLine(gender);
            }
            else
            {
                Console.WriteLine("Incorrect format.");
            }

            Console.ReadKey();
        }
    }
}