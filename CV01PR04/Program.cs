using System;

namespace CV01PR04
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                new FiniteGame().Start();
                Console.WriteLine("Game over, press [R] to restart, else you'll exit the game");

                if (Console.ReadKey().Key == ConsoleKey.R)
                    continue;
                else
                    break;
            }
        }
    }
}