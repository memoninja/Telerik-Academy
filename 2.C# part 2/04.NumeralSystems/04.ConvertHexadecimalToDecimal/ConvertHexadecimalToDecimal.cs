// 04. Write a program to convert hexadecimal numbers to their decimal representation.

using System;
using System.Collections.Generic;
using System.Linq;

class ConvertHexadecimalToDecimal
{
    static void Main()
    {
        string numberToConvert;
        int decimalRepresentation;

        numberToConvert = ValidateHexadecimalNumber(); //Validate input number, using method "ValidateHexadecimalNumber()"
        decimalRepresentation = ConvertToDecimal(numberToConvert); //Conveert input number into decimal number, using method "ConvertToDecimal(string numberToConvert)"

        Console.WriteLine(new string('=', 30));
        Console.WriteLine("Decimal representation: {0}", decimalRepresentation);
    }

    /// <summary>
    /// Convert hexadecimal number to decimal
    /// </summary>
    /// <param name="numberToConvert">Hexadecimal number</param>
    /// <returns>Decimal number</returns>
    private static int ConvertToDecimal(string numberToConvert)
    {
        int decimalNumber = 0;
        int numberBase;
        //Convert theletter into numbers, using method "HexadecimalLettersToNumbers(string numberToConvert)"
        int[] arrayToConvert = HexadecimalLettersToNumbers(numberToConvert);

        Array.Reverse(arrayToConvert); //Revers the array, because we need to track the current power

        //Loop to iterate through the array and multiply the digit by the current power
        for (int i = 0; i < arrayToConvert.Length; i++)
        {
            numberBase = 1;

            for (int j = 0; j < i; j++)
            {
                numberBase *= 16;
            }

            decimalNumber += arrayToConvert[i] * numberBase;
        }

        return decimalNumber;
    }

    /// <summary>
    /// Convert hexadecimal letters into numbers
    /// </summary>
    /// <param name="numberToConvert">String with ddcimal number to be converted</param>
    /// <returns>Array of numbers</returns>
    private static int[] HexadecimalLettersToNumbers(string numberToConvert)
    {
        string decimalNumber = numberToConvert.ToUpper();
        int[] hexadecimalToDigits = new int[decimalNumber.Length];

        for (int i = 0; i < decimalNumber.Length; i++)
        {
            if (decimalNumber[i] >= '0' && decimalNumber[i] <= '9')
            {
                hexadecimalToDigits[i] = decimalNumber[i] - '0';
            }
            else
            {
                switch (decimalNumber[i])
                {
                    case 'A': hexadecimalToDigits[i] = 10; break;
                    case 'B': hexadecimalToDigits[i] = 11; break;
                    case 'C': hexadecimalToDigits[i] = 12; break;
                    case 'D': hexadecimalToDigits[i] = 13; break;
                    case 'E': hexadecimalToDigits[i] = 14; break;
                    case 'F': hexadecimalToDigits[i] = 15; break;
                    default: Console.WriteLine("Error!"); break;
                }
            }
        }

        return hexadecimalToDigits;
    }

    /// <summary>
    /// Validate input hexadecimal number
    /// </summary>
    /// <returns>Validatet hexadecimal string</returns>
    private static string ValidateHexadecimalNumber()
    {
        string hexadecimalNumber = string.Empty;
        bool isCorrectHexadecimal = false;

        while (!isCorrectHexadecimal)
        {
            isCorrectHexadecimal = true;

            Console.Write("Enter hexadecimal number: ");
            hexadecimalNumber = Console.ReadLine();
            hexadecimalNumber = hexadecimalNumber.ToUpper();

            for (int i = 0; i < hexadecimalNumber.Length; i++)
            {
                if ((hexadecimalNumber[i] < '0' || hexadecimalNumber[i] > '9') && (hexadecimalNumber[i] < 'A' || hexadecimalNumber[i] > 'F')) // 
                {
                    Console.WriteLine("Incorrect hexadecimal!");
                    isCorrectHexadecimal = false;
                    break;
                }
            }
        }

        return hexadecimalNumber;
    }
}
