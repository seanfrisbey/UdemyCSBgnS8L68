/***********************************************************
 * Write a program and ask the user to enter an English
 * word. Count the number of vowels (a, e, o, u, i) in the
 * word. So, if the user enters "inadequate", the program
 * should display 6 on the console.
 **********************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5
{
    class Program
    {
        static void Main(string[] args)
        {
            var vowels = new List<char>{ 'a', 'e', 'i', 'o', 'u' };
            Console.Write("Please enter an English word: ");
            var inputWord = Console.ReadLine().ToLower();

            var numberOfVowels = 0;
            for (var i = 0; i < inputWord.Length; i++)
            {
                if (vowels.Contains(inputWord[i]))
                {
                    numberOfVowels++;
                }
            }

            Console.WriteLine("There are {0} vowels in the word.", numberOfVowels);
        }
    }
}
