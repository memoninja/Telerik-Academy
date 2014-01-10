// 07. Write a program to convert from any numeral system of given base s
//     to any other numeral system of base d(2 ≤ s, d ≤  16).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ConvertFromSBasedNumberToDBased
{
    static void Main()
    {
        //Program works from 2 to 36 based numeral system

        int numberBaseS;
        int numberBaseD;
        string numberToConvert;
        int decNumber = 0;
        List<char> baseDNumber;

        //Validate the input number, using method "ValidateInputInteger(string textToDisplay)"
        numberBaseS = ValidateInputInteger("Enter number base \"s\": ");
        numberBaseD = ValidateInputInteger("Enter number base \"d\": ");

        Console.Write("Enter number to convert: ");
        numberToConvert = Console.ReadLine();

        //Convert the input "s" based number to decimal
        decNumber = ConvertToDecimal(numberToConvert, numberBaseS);

        //Convert the converted to decimal number to "d" based numbers
        baseDNumber = ConvertToBaseD(decNumber, numberBaseD);

        Console.Write("Number in {0} based system: ", numberBaseD);
        PrintList(baseDNumber); //Print the converted "d" based number
    }

    private static List<char> ConvertToBaseD(int numberToConvert, int numberBaseD)
    {
        List<char> remainders = new List<char>();
        int remainder = 0;

        //Divide the number by 16, on each iteration and assign the remainder to the list of hexadecimal chars
        while (numberToConvert > 0)
        {
            remainder = numberToConvert % numberBaseD;
            numberToConvert /= numberBaseD;

            //Check if we can directly add the digit or we have to convert it to letter
            if (remainder < 10)
            {
                remainders.Add((char)(remainder + '0'));
            }
            else
            {
                switch (remainder)
                {
                    case 10: remainders.Add('A'); break;
                    case 11: remainders.Add('B'); break;
                    case 12: remainders.Add('C'); break;
                    case 13: remainders.Add('D'); break;
                    case 14: remainders.Add('E'); break;
                    case 15: remainders.Add('F'); break;
                    case 16: remainders.Add('G'); break;
                    case 17: remainders.Add('H'); break;
                    case 18: remainders.Add('I'); break;
                    case 19: remainders.Add('J'); break;
                    case 20: remainders.Add('K'); break;
                    case 21: remainders.Add('L'); break;
                    case 22: remainders.Add('M'); break;
                    case 23: remainders.Add('N'); break;
                    case 24: remainders.Add('O'); break;
                    case 25: remainders.Add('P'); break;
                    case 26: remainders.Add('Q'); break;
                    case 27: remainders.Add('R'); break;
                    case 28: remainders.Add('S'); break;
                    case 29: remainders.Add('T'); break;
                    case 30: remainders.Add('U'); break;
                    case 31: remainders.Add('V'); break;
                    case 32: remainders.Add('W'); break;
                    case 33: remainders.Add('X'); break;
                    case 34: remainders.Add('Y'); break;
                    case 35: remainders.Add('Z'); break;
                    default:                 
                        Console.WriteLine("Error!");
                        Environment.Exit(1);
                        break;
                }
            }
        }

        return remainders;
    }

    private static int ConvertToDecimal(string numberToConvert, int numberBase)
    {
        int decimalNumber = 0;
        int baseOnPower;
        int[] givenNumberDigits = NumberCharsToInts(numberToConvert); //Convert the input string into array of chars

        Array.Reverse(givenNumberDigits); //Revers the order of the array, because we need to track the power of the current digit

        //Two nested loops to convert binary number to decimal
        for (int i = 0; i < givenNumberDigits.Length; i++)
        {
            baseOnPower = 1;

            for (int j = 0; j < i; j++)
            {
                baseOnPower *= numberBase;
            }

            decimalNumber += (givenNumberDigits[i]) * baseOnPower;
        }

        return decimalNumber;
    }

    /// <summary>
    /// Convert hexadecimal letters into numbers
    /// </summary>
    /// <param name="numberToConvert">String with ddcimal number to be converted</param>
    /// <returns>Array of numbers</returns>
    private static int[] NumberCharsToInts(string numberToConvert)
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
                    case 'G': hexadecimalToDigits[i] = 16; break;
                    case 'H': hexadecimalToDigits[i] = 17; break;
                    case 'I': hexadecimalToDigits[i] = 18; break;
                    case 'J': hexadecimalToDigits[i] = 19; break;
                    case 'K': hexadecimalToDigits[i] = 20; break;
                    case 'L': hexadecimalToDigits[i] = 21; break;
                    case 'M': hexadecimalToDigits[i] = 22; break;
                    case 'N': hexadecimalToDigits[i] = 23; break;
                    case 'O': hexadecimalToDigits[i] = 24; break;
                    case 'P': hexadecimalToDigits[i] = 25; break;
                    case 'Q': hexadecimalToDigits[i] = 26; break;
                    case 'R': hexadecimalToDigits[i] = 27; break;
                    case 'S': hexadecimalToDigits[i] = 28; break;
                    case 'T': hexadecimalToDigits[i] = 29; break;
                    case 'U': hexadecimalToDigits[i] = 30; break;
                    case 'V': hexadecimalToDigits[i] = 31; break;
                    case 'W': hexadecimalToDigits[i] = 32; break;
                    case 'X': hexadecimalToDigits[i] = 33; break;
                    case 'Y': hexadecimalToDigits[i] = 34; break;
                    case 'Z': hexadecimalToDigits[i] = 35; break;
                    default:
                        Console.WriteLine("Error!");
                        Environment.Exit(1);
                        break;
                }
            }
        }

        return hexadecimalToDigits;
    }

    /// <summary>
    /// Validate input integer number
    /// </summary>
    /// <returns>Validated integer</returns>
    private static int ValidateInputInteger(string textToDisplay)
    {
        int inputNumber;

        while (true) //Loop goes, until a correct integer is entered
        {
            Console.Write(textToDisplay);

            while (!(int.TryParse(Console.ReadLine(), out inputNumber) && inputNumber > 1))
            {
                Console.Write("Enter correct integer: ");
            }

            return inputNumber;
        }
    }

    /// <summary>
    /// Print "List<int>"
    /// </summary>
    /// <param name="listToPrint">List to be printed</param>
    private static void PrintList(List<char> listToPrint)
    {
        for (int i = listToPrint.Count - 1; i >= 0; i--) //Loopt to iterate through all elements of the list
        {
            Console.Write(listToPrint[i]);
        }

        Console.WriteLine();
    }
}
