using System;

namespace CV01PR04
{
    public class FiniteGame
    {
        private Random random = new Random();
        private const ushort maxMoves = 10;

        public void Start()
        {
            int numberToGuess = random.Next(0, 101);
            ushort remainingMoves = maxMoves;
            Console.WriteLine($"I'm thinking number between 0-100 you can try and guess it, and you have {maxMoves} to guess it");
            while (true)
            {
                string line = Console.ReadLine();
                if (int.TryParse(line, out int number))
                {
                    if (numberToGuess == number)
                    {
                        Console.WriteLine("You got this...");
                        break;
                    }

                    Console.WriteLine(number < numberToGuess ? "Your number is lower" : "Your number is bigger");
                    remainingMoves--;

                    if (remainingMoves == 0)
                    {
                        Console.WriteLine("You lost :P");
                        break;
                    }

                    Console.WriteLine($"You have {remainingMoves} remaining...");
                }
            }
        }
    }
}