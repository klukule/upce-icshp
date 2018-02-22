using System;

namespace CV01PR04
{
    public class InfiniteGame
    {
        private Random random = new Random();

        public void Start()
        {
            int numberToGuess = random.Next(0, 101);
            Console.WriteLine("I'm thinking number between 0-100 you can try and guess it");
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
                }
            }
        }
    }
}