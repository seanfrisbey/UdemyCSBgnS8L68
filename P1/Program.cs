/***********************************************************
 * Write a program and ask the user to enter a few number
 * separated by a hyphen. Work out if the numbers are
 * consecutive. For example, if the input is "5-6-7-8-9"
 * or "20-19-18-17-16", display a message: "Consecutive";
 * otherwise, display "Not Consecutive".
 **********************************************************/

using System;

namespace P1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter 5 integers separated with hyphens: ");
            var numbersString = Console.ReadLine();
            Console.WriteLine();

            var message = areNumbersConsecutive(numbersString) ? "The numbers you provided were consecutive." : "The numbers you provided were not consecutive.";
            Console.WriteLine(message);
        }

        static bool areNumbersConsecutive(string inputString)
        {
            var numbers = inputString.Split('-');
            bool ascending = false;

            for (var i = 1; i < numbers.Length; i++)
            {
                var difference = (Convert.ToInt32(numbers[i]) - Convert.ToInt32(numbers[i - 1]));

                if (difference == 1) //if ascending by 1
                {
                    if (i > 1 && ascending == false)
                    {
                        return false;
                    }

                    ascending = true;
                }
                else if (difference == -1) //if descending by 1
                {
                    if (i > 1 && ascending == true)
                    {
                        return false;
                    }

                    ascending = false;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}
