// 02. Write a program to convert binary numbers to their decimal representation.

using System;
using System.Collections.Generic;
using System.Linq;

class ConvertBinaryToDecimal
{
    static void Main()
    {
        string binaryNumber;
        int binNumberToDecimal;

        //Using method "ValidateBinaryNumber()" to validate the input binary number
        binaryNumber = ValidateBinaryNumber();

        //Using method "ConvertToDecimal(string binaryNumber)" to convert the binary number to decimal
        binNumberToDecimal = ConvertToDecimal(binaryNumber);

        Console.WriteLine(new string('=', 30));
        Console.WriteLine("Decimal number: {0}", binNumberToDecimal);
    }

    /// <summary>
    /// Convert binary number to decimal
    /// </summary>
    /// <param name="binaryNumber">Number to convert</param>
    /// <returns>Decimal number</returns>
    private static int ConvertToDecimal(string binaryNumber)
    {
        int decimalNumber = 0;
        int numberBase;
        char[] bits = binaryNumber.ToCharArray(); //Convert the input string into array of chars

        Array.Reverse(bits); //Revers the order of the array, because we need to track the power of the current digit

        //Two nested loops to convert binary number to decimal
        for (int i = 0; i < bits.Length; i++)
        {
            numberBase = 1;

            for (int j = 0; j < i; j++)
            {
                numberBase *= 2;
            }

            decimalNumber += (bits[i] - '0') * numberBase;
        }

        return decimalNumber;
    }

    /// <summary>
    /// Validate binary number
    /// </summary>
    /// <returns>Validated binary number</returns>
    private static string ValidateBinaryNumber()
    {
        string binaryNumber = string.Empty;
        bool isCorrectBinary = false;

        //Loop goes until a correct binary is entered
        while (!isCorrectBinary)
        {
            isCorrectBinary = true;

            Console.Write("Enter binary number: ");
            binaryNumber = Console.ReadLine();

            for (int i = 0; i < binaryNumber.Length; i++)
            {
                if (binaryNumber[i] != '1' && binaryNumber[i] != '0')
                {
                    Console.WriteLine("Incorrect number!");
                    isCorrectBinary = false;
                    break;
                }
            }
        }

        return binaryNumber;
    }
}
