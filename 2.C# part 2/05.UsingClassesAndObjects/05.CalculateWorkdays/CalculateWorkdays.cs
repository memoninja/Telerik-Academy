// 05. Write a method that calculates the number of workdays between today and given date, passed as parameter.
//     Consider that workdays are all days from Monday to Friday except a fixed list of public holidays
//     specified preliminary as array.

using System;

namespace _05.CalculateWorkdays
{
    class CalculateWorkdays
    {
        static void Main()
        {
            DateTime today = DateTime.Today;
            DateTime givenDate;
            DateTime[] holidays;
            int workdays;

            DateTime startDate;
            DateTime endDate;

            holidays = new[] //Holidays for 2014
{
   new DateTime(2014, 1, 1),
   new DateTime(2014, 3, 3),
   new DateTime(2014, 4, 18),
   new DateTime(2014, 5, 1),
   new DateTime(2014, 5, 2),
   new DateTime(2014, 5, 5),
   new DateTime(2014, 5, 6),
   new DateTime(2014, 9, 22),
   new DateTime(2014, 12, 24),
   new DateTime(2014, 12, 25),
   new DateTime(2014, 12, 26),
   new DateTime(2014, 12, 31),
};

            givenDate = ValidateInputDate(); //Validate input date, using method "ValidateInputDate()"

            //Check which date is more foreward in time
            if (givenDate.CompareTo(today) > 0)
            {
                endDate = givenDate;
                startDate = today;
            }
            else
            {
                endDate = today;
                startDate = givenDate;
            }

            //Count the workdays, using method "CountWorkdays(DateTime startDate, DateTime endDate, DateTime[] holidays)"
            workdays = CountWorkdays(startDate, endDate, holidays);

            Console.WriteLine("Workdays: {0}", workdays);
        }

        /// <summary>
        /// Count workdays in given period
        /// </summary>
        /// <param name="startDate">Start date of period</param>
        /// <param name="endDate">End date of period</param>
        /// <param name="holidays">Days that are non working</param>
        /// <returns>Count of workdays</returns>
        private static int CountWorkdays(DateTime startDate, DateTime endDate, DateTime[] holidays)
        {
            int workdays = 0;
            bool isHoliday = false;
            TimeSpan oneDay = new TimeSpan(1, 0, 0, 0); //Period to add(one day), until we get to the wanted date

            //Iterate through all dates to end date. Increment "workdays" if is not weekend or holiday
            for (; startDate <= endDate; startDate = startDate.Add(oneDay))
            {
                if (!startDate.DayOfWeek.Equals(DayOfWeek.Saturday) && !startDate.DayOfWeek.Equals(DayOfWeek.Sunday)) //Check is weekend
                {
                    isHoliday = CheckIsHoliday(holidays, startDate); //Check if is holiday, using method "CheckIsHoliday(DateTime[] holidays, DateTime date)"

                    if (!isHoliday)
                    {
                        workdays++;
                    }
                }
            }

            return workdays;
        }

        /// <summary>
        /// Check if date is holiday or not
        /// </summary>
        /// <param name="holidays">Array of holidays</param>
        /// <param name="date">Date to check</param>
        /// <returns>Is holiday or not</returns>
        private static bool CheckIsHoliday(DateTime[] holidays, DateTime date)
        {
            for (int i = 0; i < holidays.Length; i++) //Iterate through the array of holidays and compare given date
            {
                if (date.Equals(holidays[i]))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Validate given date
        /// </summary>
        /// <returns>Validated date</returns>
        private static DateTime ValidateInputDate()
        {
            DateTime validatedDate = new DateTime();

            Console.Write("Enter date: ");

            while (!DateTime.TryParse(Console.ReadLine(), out validatedDate))
            {
                Console.Write("Enter correct date: ");
            }

            return validatedDate;
        }
    }
}
