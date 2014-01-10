// 06. You are given a sequence of positive integer values written into a string, separated by spaces.
//     Write a function that reads these values from given string and calculates their sum. Example:
//     string = "43 68 9 23 318" -> result = 461

using System;

namespace _06.SumNumbersInString
{
    class SumNumbersInString
    {
        static void Main()
        {
            string sequenceOfNumbers;
            string[] numbersToSum;
            int sum;
            char[] separator = { ' ', ',', '/', '-' }; //Chars allowed to separate the numbers in the string

            Console.Write("Enter numbers: ");
            sequenceOfNumbers = Console.ReadLine();

            //Split the string into array of string, by removing the chars in the "separator"
            numbersToSum = sequenceOfNumbers.Split(separator, StringSplitOptions.RemoveEmptyEntries);

            sum = SumNumbers(numbersToSum); //Sum the numbers in the string array, using method "SumNumbers(string[] numbers)"

            Console.WriteLine(new string('=', 30));
            Console.WriteLine("Sum is: {0}", sum);
        }

        /// <summary>
        /// Sum numbers in array of strings
        /// </summary>
        /// <param name="numbers">Array to sum</param>
        /// <returns>Sum of the elements in the array</returns>
        private static int SumNumbers(string[] numbers)
        {
            int sum = 0;
            int currentNumber;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (int.TryParse(numbers[i], out currentNumber)) //Check if correct integer is entered
                {
                    sum += currentNumber;
                }
                else
                {
                    Console.WriteLine("Invalid input data!");
                    Environment.Exit(1); //If is not correct integer the program is terminated
                }
            }

            return sum;
        }
    }
}
