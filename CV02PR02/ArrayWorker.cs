using Fei.BaseLib;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CV02PR02
{
    /// <summary>
    /// Class which contains some example methods used in menu
    /// </summary>
    public static class ArrayWorker
    {
        /// <summary>
        /// The fake array
        /// </summary>
        /// <remarks>
        /// We use <see cref="System.Collections.Generic.Dictionary{TKey, TValue}"/>, as an array, since we want to allow user top dynamiccally add/remove elements, without need to resize array manually
        /// </remarks>
        private static Dictionary<int, int> FakeArray = new Dictionary<int, int>();

        /// <summary>
        /// Adds the element.
        /// </summary>
        public static void AddElement()
        {
            int key;
            while (true)
            {
                try
                {
                    key = Reading.ReadInt(string.Format("Write an index to add/modify"));
                    if (key >= 0)
                        break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Wrong input, try again...");
                }
            }

            while (true)
            {
                try
                {
                    int value = Reading.ReadInt(string.Format("Write the value"));
                    if (FakeArray.ContainsKey(key))
                    {
                        FakeArray[key] = value;
                    }
                    else
                    {
                        FakeArray.Add(key, value);
                    }
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Wrong input, try again...");
                }
            }
        }

        /// <summary>
        /// Prints the array.
        /// </summary>
        public static void PrintArray()
        {
            Console.WriteLine("Here is your array, length = {0}:", FakeArray.Count);
            if (FakeArray.Count == 0)
            {
                Console.WriteLine("No elements in array, please add some");
            }
            foreach (var item in FakeArray)
            {
                Console.WriteLine("[ {0} => {1} ]", item.Key, item.Value);
            }
        }

        /// <summary>
        /// Sorts the array ascending.
        /// </summary>
        public static void SortAsc()
        {
            FakeArray = FakeArray.OrderBy(obj => obj.Key).ToDictionary(obj => obj.Key, obj => obj.Value);
        }

        /// <summary>
        /// Sorts the array descending.
        /// </summary>
        public static void SortDesc()
        {
            FakeArray = FakeArray.OrderByDescending(obj => obj.Key).ToDictionary(obj => obj.Key, obj => obj.Value);
        }

        /// <summary>
        /// Finds the smallest number.
        /// </summary>
        public static void FindSmallestNumber()
        {
            if (FakeArray.Count == 0)
            {
                Console.WriteLine("There are no elements in the array, please add some first");
            }
            else
            {
                var Values = FakeArray.Values.OrderBy(obj => obj).ToArray();
                Console.WriteLine("I've found number {0} to be lowest in the array", Values[0]);
            }
        }

        /// <summary>
        /// Finds the first occurance.
        /// </summary>
        public static void FindFirstOccurance()
        {
            while (true)
            {
                try
                {
                    int value = Reading.ReadInt(string.Format("Write the number you want to find"));
                    if (FakeArray.ContainsValue(value))
                    {
                        foreach (var item in FakeArray)
                        {
                            if (item.Value == value)
                            {
                                Console.WriteLine("Index of value {0} is {1}", value, item.Key);
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("There is no number like this in array");
                    }
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Wrong input, try again...");
                }
            }
        }

        /// <summary>
        /// Finds the last occurance.
        /// </summary>
        public static void FindLastOccurance()
        {
            while (true)
            {
                try
                {
                    int value = Reading.ReadInt(string.Format("Write the number you want to find"));
                    if (FakeArray.ContainsValue(value))
                    {
                        int index = 0; // Assigned, just so C# suts the hell up (since we already know, that there is index in the array)
                        foreach (var item in FakeArray)
                        {
                            if (item.Value == value)
                            {
                                index = item.Key;
                            }
                        }
                        Console.WriteLine("Index of value {0} is {1}", value, index);
                    }
                    else
                    {
                        Console.WriteLine("There is no number like this in array");
                    }
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