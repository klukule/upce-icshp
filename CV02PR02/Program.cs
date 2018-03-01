using Fei.BaseLib;
using System;

namespace CV02PR02
{
    /// <summary>
    /// Main class
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// The menu defines
        /// </summary>
        private static (string, Action)[] Menu = new(string, Action)[]
                {
            ("Add/Edit element", ArrayWorker.AddElement),
            ("Print the array", ArrayWorker.PrintArray),
            ("Sort array in ascending order", ArrayWorker.SortAsc),
            ("Sort array in descending order", ArrayWorker.SortDesc),
            ("Find smallest element in array", ArrayWorker.FindSmallestNumber),
            ("Find first occurance of specified number", ArrayWorker.FindFirstOccurance),
            ("Find last occurance of specified number", ArrayWorker.FindLastOccurance),
            ("Exit", ()=>Environment.Exit(0)),
                };

        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        private static void Main(string[] args)
        {
            while (true)
            {
                PrintMenu();
                ProcessInput();
            }
        }

        /// <summary>
        /// Prints the menu.
        /// </summary>
        private static void PrintMenu()
        {
            for (int i = 0; i < Menu.Length; i++)
            {
                var item = Menu[i];
                Console.WriteLine("{0}. {1}", i + 1, item.Item1);
            }
        }

        /// <summary>
        /// Processes the input for the menu.
        /// </summary>
        private static void ProcessInput()
        {
            while (true)
            {
                try
                {
                    int input = Reading.ReadInt(string.Format("Write any number between 1 and {0} and press enter", Menu.Length));
                    if (input < 0 || input > Menu.Length)
                    {
                        Console.WriteLine("Wrong input, try again...");
                        continue;
                    }

                    Menu[input - 1].Item2.Invoke();
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Wrong input, try again...");
                }
            }
        }
    }
}