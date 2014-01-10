// 01. Write a program to convert decimal numbers to their binary representation.

using System;
using System.Collections.Generic;
using System.Linq;

class ConvertDecimalToBinary
{
    static void Main()
    {
        List<int> binaryRepresentation = new List<int>();
        int numberToConvert = ValidateInputInteger(); //Using method "ValidateInputInteger()" to validate the input integer

        binaryRepresentation = DecimalToBinary(numberToConvert); //Using method "DecimalToBinary(int numberToConvert)" to convert decimal number to binary system

        PrintList(binaryRepresentation); //Using method "PrintList(List<int> listToPrint)" to print the number in binary system
    }

    /// <summary>
    /// Convert decimal number to binary, using binary operator
    /// </summary>
    /// <param name="numberToConvert">Number to convert</param>
    /// <returns>Binary representation</returns>
    private static List<int> DecimalToBinary(int numberToConvert)
    {
        int currentBit;
        List<int> binaryRepresentation = new List<int>();

        //Loop to iterate through the 32 bits of the given number
        for (int i = 0; i < 32; i++)
        {
            currentBit = (numberToConvert >> i) & 1; //Using binary operator "&", to get the value of bit at current position
            binaryRepresentation.Add(currentBit);
        }

        return binaryRepresentation;    
    }

    /// <summary>
    /// Print "List<int>"
    /// </summary>
    /// <param name="listToPrint">List to be printed</param>
    private static void PrintList(List<int> listToPrint)
    {
        Console.WriteLine(new string('=', 40));
        Console.Write("Binary: ");

        for (int i = listToPrint.Count - 1; i >= 0; i--) //Loopt to iterate through all elements of the list
        {
            Console.Write(listToPrint[i]);
        }

        Console.WriteLine();
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
            Console.Write("Enter number to convert to binary: ");

            while (!int.TryParse(Console.ReadLine(), out inputNumber))
            {
                Console.Write("Enter correct integer: ");
            }

            return inputNumber;
        }
    }
}
