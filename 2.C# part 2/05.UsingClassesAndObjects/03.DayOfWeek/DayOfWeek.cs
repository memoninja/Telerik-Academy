// 03. Write a program that prints to the console which day of the week is today. Use System.DateTime.

using System;

namespace _03.DayOfWeek
{
    class DayOfWeek
    {
        static void Main()
        {
            //Assing the current date, according to the user computer calendar
            DateTime today = DateTime.Today; //We can use "DateTime.Now" too

            Console.WriteLine("Today is: {0}", today.DayOfWeek);
        }
    }
}
