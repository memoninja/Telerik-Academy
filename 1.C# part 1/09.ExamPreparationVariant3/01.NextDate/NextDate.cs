using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.NextDate
{
    class NextDate
    {
        static void Main(string[] args)
        {

            /*This program are made only to practice, so there are not enough comments!
              The programs are made just to score 100 points!
              No additional optimization were made!
              Sorry if the code is unreadable!!!
              Do not have time to make it readable!
            */

            // 100 Points

            int day;
            int month;
            int year;

            day = int.Parse(Console.ReadLine());
            month = int.Parse(Console.ReadLine());
            year = int.Parse(Console.ReadLine());



            DateTime givenDate = new DateTime(year, month, day);
            DateTime newDate = givenDate.AddDays(1);

            day = newDate.Day;
            month = newDate.Month;
            year = newDate.Year;

            Console.WriteLine("{0}.{1}.{2}", day, month, year);
        }
    }
}
