// 06. Write a program to convert binary numbers to hexadecimal numbers (directly).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ConvertBinaryToHexadecimal
{
    static void Main()
    {
        string binaryNumber;
        char[] hexRepresentation;

        binaryNumber = ValidateBinaryNumber(); //Validate binary number, using method "ValidateBinaryNumber()"

        //Convert binary number into hexadecimal, using method "ConvertToHexadecimal(binaryNumber)"
        hexRepresentation = ConvertToHexadecimal(binaryNumber);

        PrintArray(hexRepresentation); //Print the hexadecimal number
    }

    /// <summary>
    /// Convert given binary number to hexadecimal
    /// </summary>
    /// <param name="decimalNumber">Number to convert</param>
    /// <returns>Hexadecimal number</returns>
    private static char[] ConvertToHexadecimal(string decimalNumber)
    {
        List<char> listOfBinary;
        string[] listOf4Bits;
        char[] hexNumber;

        //Convert the binary number into list of chars and assign it to a "List<char>"
        listOfBinary = new List<char>(decimalNumber.ToList());

        //Add leading zeros, if needed, using method "AddZeros(List<char> binaryList)"
        AddZeros(listOfBinary);

        //Set the list of binary number into an array of strings of 4 bits
        listOf4Bits = SetStringOf4Bits(listOfBinary);

        //Set the length of the array, where will be the hexadecimal number, according to the count of the 4 bits array
        hexNumber = new char[listOf4Bits.Length];

        for (int i = 0; i < listOf4Bits.Length; i++)
        {
            switch (listOf4Bits[i])
            {
                case "0000": hexNumber[i] = '0'; break;
                case "0001": hexNumber[i] = '1'; break;
                case "0010": hexNumber[i] = '2'; break;
                case "0011": hexNumber[i] = '3'; break;
                case "0100": hexNumber[i] = '4'; break;
                case "0101": hexNumber[i] = '5'; break;
                case "0110": hexNumber[i] = '6'; break;
                case "0111": hexNumber[i] = '7'; break;
                case "1000": hexNumber[i] = '8'; break;
                case "1001": hexNumber[i] = '9'; break;
                case "1010": hexNumber[i] = 'A'; break;
                case "1011": hexNumber[i] = 'B'; break;
                case "1100": hexNumber[i] = 'C'; break;
                case "1101": hexNumber[i] = 'D'; break;
                case "1110": hexNumber[i] = 'E'; break;
                case "1111": hexNumber[i] = 'F'; break;
                default: Console.WriteLine("Error!"); break;
            }
        }

        return hexNumber;
    }

    /// <summary>
    /// Set strings of 4 bits
    /// </summary>
    /// <param name="binaryList">List of bits</param>
    /// <returns>Array of strings of 4 bits</returns>
    private static string[] SetStringOf4Bits(List<char> binaryList) //Set string of 4 bits, so we can get correcponding hexidecimal number
    {
        int countOfFours = binaryList.Count / 4;
        string[] stringsOf4Bits = new string[countOfFours];
        int counter = 0;
        int currentIndex = 0;
        int foursCounter = 0;

        while (foursCounter < countOfFours) //Loop to count the current four bits
        {
            StringBuilder str = new StringBuilder(); //Using "StringBuilder", because is faster the operator "+"
            counter = 0;

            while (counter < 4) //Group elements by 4
            {
                str.Append(binaryList[currentIndex]);

                counter++;
                currentIndex++; //Increment the index on each iteration, so we iterate through the whole array
            }

            stringsOf4Bits[foursCounter] = str.ToString();
            foursCounter++;
        }

        return stringsOf4Bits;
    }

    /// <summary>
    /// Add leading zeros if needed
    /// </summary>
    /// <param name="binaryList">List of binary number</param>
    private static void AddZeros(List<char> binaryList)
    {
        //Add zeros only if the remainder is not 0
        int remainder = binaryList.Count % 4;

        if (remainder != 0)
        {
            remainder = 4 - (binaryList.Count % 4);

            binaryList.Reverse(); //Revers the order, so we add leading zeros

            for (int i = 0; i < remainder; i++)
            {
                binaryList.Add('0');
            }

            binaryList.Reverse(); //Again revers, so we get the original order
        }
    }

    /// <summary>
    /// Validate binary number
    /// </summary>
    /// <returns>Validated binary number</returns>
    private static string ValidateBinaryNumber()
    {
        string binaryNumber = string.Empty;
        bool isCorrectBinary = false;

        //If some of the elements in the array differ from 1 and 0, an empty string is returned
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

    /// <summary>
    /// Print given array
    /// </summary>
    /// <param name="hexRepresentation">Array to print</param>
    private static void PrintArray(char[] hexRepresentation)
    {
        Console.WriteLine(new string('=', 35));
        Console.Write("Hexadecimal representation: ");

        foreach (var element in hexRepresentation)
        {
            Console.Write(element);
        }

        Console.WriteLine();
    }
}
