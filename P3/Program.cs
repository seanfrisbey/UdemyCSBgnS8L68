/***********************************************************
 * Write a program and ask the user to enter a time value in
 * the 24-hour time format (e.g. 19:00). A valid time should
 * be between 00:00 and 23:59. If the time is valid, display
 * "Ok"; otherwise, display "Invalid Time". If the user
 * doesn't provide any values, consider it as invalid time.
 **********************************************************/

using System;

namespace P3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a time in 24-hour format, formatted as HH:MM: ");
            var inputString = Console.ReadLine();
            var message = isValidTime(inputString) ? "OK." : "Invalid time entered.";

            Console.WriteLine(message);
        }

        static bool isValidTime(string inputString)
        {
            if (String.IsNullOrWhiteSpace(inputString))
                return false;

            var timeParts = inputString.Split(':');

            try
            {
                var hours = Convert.ToInt32(timeParts[0]);
                var minutes = Convert.ToInt32(timeParts[1]);

                if (hours >= 0 && hours <= 23 && minutes >= 0 && minutes <= 59)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
        }
    }
}