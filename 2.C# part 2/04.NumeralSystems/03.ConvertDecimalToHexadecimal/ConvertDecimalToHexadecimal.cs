// 03. Write a program to convert decimal numbers to their hexadecimal representation.

using System;
using System.Collections.Generic;
using System.Linq;

class ConvertDecimalToHexadecimal
{
    static void Main()
    {
        int givenNumber;
        List<char> hexadecimalNumber = new List<char>();

        givenNumber = ValidateInputInteger(); //Validate the input integer and then assign it to variable

        hexadecimalNumber = ConvertToHexadecimal(givenNumber); //Use method "ConvertToHexadecimal(int numberToConvert)" to convert number to hexadecimal

        Console.WriteLine(new string('=', 40));
        Console.Write("Hexadecimal representation: ");
        PrintList(hexadecimalNumber); //Usign method "PrintList(List<char> listToPrint)" to print the hexadecimal number
    }

    /// <summary>
    /// Convert decimal number to hexadecimal
    /// </summary>
    /// <param name="numberToConvert">Number to be converted</param>
    /// <returns>List of hexadecimal representation</returns>
    private static List<char> ConvertToHexadecimal(int numberToConvert)
    {
        List<char> remainders = new List<char>();
        int remainder = 0;

        //Divide the number by 16, on each iteration and assign the remainder to the list of hexadecimal chars
        while (numberToConvert > 0)
        {
            remainder = numberToConvert % 16;
            numberToConvert /= 16;

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
                    default: Console.WriteLine("Error!"); break;
                }
            }
        }

        return remainders;
    }

    /// <summary>
    /// Validate input integer number
    /// </summary>
    /// <returns>Validated integer</returns>
    private static int ValidateInputInteger()
    {
        int inputNumber;

        while (true) //Loop goes, until a correct integer is entered
        {
            Console.Write("Enter number to convert to hexadecimal: ");

            while (!(int.TryParse(Console.ReadLine(), out inputNumber) && inputNumber >= 0))
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
