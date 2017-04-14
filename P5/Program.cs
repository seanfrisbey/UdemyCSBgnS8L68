/***********************************************************
 * Write a program and ask the user to enter an English
 * word. Count the number of vowels (a, e, o, u, i) in the
 * word. So, if the user enters "inadequate", the program
 * should display 6 on the console.
 **********************************************************/

using System;
using System.Collections.Generic;

namespace P5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter an English word: ");
            var inputWord = Console.ReadLine().ToLower();
            Console.WriteLine("There are {0} vowels in the word.", getNumberOfVowels(inputWord));
        }

        static int getNumberOfVowels(string inputWord)
        {
            var vowels = new List<char> { 'a', 'e', 'i', 'o', 'u' };
            var numberOfVowels = 0;
            for (var i = 0; i < inputWord.Length; i++)
            {
                if (vowels.Contains(inputWord[i]))
                {
                    numberOfVowels++;
                }
            }

            return numberOfVowels;
        }
    }
}
