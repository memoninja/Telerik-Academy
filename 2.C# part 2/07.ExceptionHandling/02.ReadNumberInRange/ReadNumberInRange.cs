// 02. Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end].
//     If an invalid number or non-number text is entered, the method should throw an exception.
//     Using this method write a program that enters 10 numbers:
//	   a1, a2, … a10, such that 1 < a1 < … < a10 < 100

using System;

namespace _02.ReadNumberInRange
{
    class ReadNumberInRange
    {
        static void Main()
        {
            int startNumber = 1;
            int endNumber = 100;

            ReadTenNumbers(startNumber, endNumber); //Read ten numbers from the console, using method "ReadTenNumbers(int start, int end)"
        }

        /// <summary>
        /// Read sequence of ten integer numbers
        /// </summary>
        /// <param name="start">Lower bound</param>
        /// <param name="end">Upper bound</param>
        private static void ReadTenNumbers(int start, int end)
        {
            try
            {
                int currentNumber = 1;

                for (int i = 1; i < 11; i++) //Loop to read 10 numbers from the console
                {
                    Console.Write("Number {0}: ", i);

                    int previousNumber = currentNumber;
                    currentNumber = int.Parse(Console.ReadLine());

                    if (start >= currentNumber || end <= currentNumber) //Check if number is in bounds
                    {
                        throw new ArgumentOutOfRangeException("currentNumber", "Number must be in range 1 - 100!");
                    }

                    if (previousNumber >= currentNumber) //Check if numbers are ascending order
                    {
                        throw new ArgumentOutOfRangeException("currentNumber", "Each number must be greather than the previous!");
                    }
                }
                
            }
            // List of possible exceptions
            catch (ArgumentNullException exc) // If input is "null" - try with "Ctrl + Z"
            {
                Console.WriteLine(exc.Message);
                Console.WriteLine(exc.StackTrace);
            }
            catch (ArgumentOutOfRangeException exc)
            {
                Console.WriteLine(exc.Message);
                Console.WriteLine(exc.StackTrace);
            }
            catch (OverflowException exc)
            {
                Console.WriteLine(exc.Message);
                Console.WriteLine(exc.StackTrace);
            }
            catch (FormatException exc)
            {
                Console.WriteLine("Only integer number are allowed!");
                Console.WriteLine(exc.Message);
                Console.WriteLine(exc.StackTrace);
            }
        }
    }
}
