﻿// 01. Write a program that reads an integer number and calculates and prints its square root.
//     If the number is invalid or negative, print "Invalid number". In all cases finally print "Good bye".
//     Use try-catch-finally.

namespace _01.CalcSqrtUseTryCatchFinally
{
    using System;

    class CalcSqrtUseTryCatchFinally
    {
        private static void Main()
        {
            try
            {
                double squareRoot = CalcSquareRoot(); // Calculate square root, exceptions can be thrown
                Console.WriteLine("Square root is: {0}", squareRoot);
            }
            // List of possible exceptions
            catch (ArgumentNullException) // If input is "null" - try with "Ctrl + Z"
            {
                Console.WriteLine("Invalid number");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Invalid number");
            }
            catch (FormatException) // If input is different format, like "double" or "float"
            {
                Console.WriteLine("Invalid number");
            }
            catch (OverflowException) // If input is negative number
            {
                Console.WriteLine("Invalid number");
            }
            catch (Exception)// If any of the above listed "exceptions" can't handle, this takes care
            {
                Console.WriteLine("Invalid number");
            }
            finally // No matter what, this is executed
            {
                Console.WriteLine("Good bye");
            }
        }

        /// <summary>
        /// Calculate square root of input integer
        /// </summary>
        private static double CalcSquareRoot()
        {
            double squareRoot;
            uint inputNumber;

            Console.Write("Enter integer: ");
            inputNumber = uint.Parse(Console.ReadLine()); // This operation can throw exceptions

            squareRoot = Math.Sqrt(inputNumber);

            return squareRoot;
        }
    }
}
