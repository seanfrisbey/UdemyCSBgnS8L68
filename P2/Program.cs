/***********************************************************
 * Write a program and ask the user to enter a few numbers
 * separated by a hyphen. If the user simply presses Enter,
 * without supplying an input, exit immediately; otherwise,
 * check to see if there are duplicates. If so, display
 * "Duplicate" on the console.
 **********************************************************/

using System;
using System.Collections.Generic;

namespace P2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a series of integers separated by hyphens: ");
            var numbersString = Console.ReadLine();
            Console.WriteLine();

            var message = areThereDuplicates(numbersString) ? "A duplicate exists in your series of numbers." : "No duplicates exist in your series of numbers.";

            Console.WriteLine(message);
        }

        static bool areThereDuplicates(string inputString)
        {
            var numbers = new List<int>();

            foreach (var number in inputString.Split('-'))
                numbers.Add(Convert.ToInt32(number));

            numbers.Sort();

            for (var i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    return true;
                }
            }
            return false;
        }
    }
}