// 01. Write a program that reads an year from the console and checks whether it is a leap. Use DateTime.

using System;

namespace _01.IsLeapYear
{
    class IsLeapYear
    {
        static void Main()
        {
            ushort year;
            bool isLeap;

            year = ValidateYear(); //Validate input year, using method "ValidateYear()"
            //Check if given year is leap, using "DateTime.IsLeapYear(int year)". It returns "true" if is leap and "false" if it is not
            isLeap = DateTime.IsLeapYear(year);

            Console.WriteLine(new string('=', 20));
            Console.WriteLine("Is {0} leap: {1}", year, isLeap);
        }

        /// <summary>
        /// Validate given year
        /// </summary>
        /// <returns>Ushort, representing validated year</returns>
        static private ushort ValidateYear()
        {
            ushort validatedYear;

            Console.Write("Enter year: ");

            //Loop goes, until a correct year is entered. "DateTime.IsLeapYear(int year)" takes parameters between 1 and 9999!
            while (!(ushort.TryParse(Console.ReadLine(), out validatedYear) && validatedYear > 0 && validatedYear < 10000))
            {
                Console.Write("Enter correct year: ");
            }

            return validatedYear;
        }
    }
}
