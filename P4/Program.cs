/***********************************************************
 * Write a program and ask the user to enter a few words
 * separated by a space. Use the words to create a variable
 * name with PascalCase. For example, if the user types:
 * "number of students", display "NumberOfStudents". Make
 * sure that the program is not dependent on the input. So,
 * if the user types "NUMBER OF STUDENTS", the program
 * should still display "NumberOfStudents".
 **********************************************************/

using System;

namespace P4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a few words separated by spaces: ");
            var inputString = Console.ReadLine();
            Console.WriteLine(toVariableName(inputString));
        }

        static string toVariableName(string inputString)
        {
            var variableName = "";
            foreach (var word in inputString.Split(' '))
            {
                variableName += char.ToUpper(word[0]) + word.ToLower().Substring(1);
            }

            return variableName;
        }
    }
}
