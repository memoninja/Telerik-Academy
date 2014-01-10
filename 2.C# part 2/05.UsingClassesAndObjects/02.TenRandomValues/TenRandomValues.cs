// 02. Write a program that generates and prints to the console 10 random values in the range [100, 200].

using System;

namespace _02.TenRandomValues
{
    class TenRandomValues
    {
        static void Main()
        {
            byte numbersCount = 10;

            //Print 10 random number between 100 and 200, using method "PrintRandomNumbers(byte numbersCount)"
            PrintRandomNumbers(numbersCount);
        }

        /// <summary>
        /// Print random numbers between 100 and 200, including
        /// </summary>
        /// <param name="numbersCount">Count of number to print</param>
        private static void PrintRandomNumbers(byte numbersCount)
        {
            ////Use variables instead of directly putting numbers. Read for "Magic numbers"
            int lowerBound = 100;
            int upperBound = 201;
            Random generateRandomNumbers = new Random();

            for (int i = 0; i < numbersCount; i++)
            {
                //Ser upper bound to 201, because ".Next" do not include upper bound: [100, 201)
                Console.WriteLine(generateRandomNumbers.Next(lowerBound, upperBound));
            }
        }
    }
}
