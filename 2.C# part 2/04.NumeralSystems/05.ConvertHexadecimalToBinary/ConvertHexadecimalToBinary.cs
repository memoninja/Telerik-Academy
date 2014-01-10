// 05. Write a program to convert hexadecimal numbers to binary numbers (directly).

using System;
using System.Collections.Generic;
using System.Linq;

class ConvertHexadecimalToBinary
{
    static void Main()
    {
        //"List" is used instead of "string", because is faster

        string inputNumber;
        List<string> binRepresentation = new List<string>();

        inputNumber = ValidateHexadecimalNumber(); //Validate the input hex number, using method "ValidateHexadecimalNumber()"

        binRepresentation = ConvertToBinary(inputNumber); //Convert hex number to binary, using method "ConvertToBinary(string hexNumber)"

        Console.WriteLine(new string('=', 30));
        PrintList(binRepresentation); //Print list with binary representation. using method "PrintList(List<string> listToPrint)"
    }

    /// <summary>
    /// Convert hexadecimal number to binary
    /// </summary>
    /// <param name="hexNumber">Hexadecimal number to convert</param>
    /// <returns>List with binary representation</returns>
    private static List<string> ConvertToBinary(string hexNumber)
    {
        string currentDigit;
        List<string> binaryRepresentation = new List<string>();

        for (int i = 0; i < hexNumber.Length; i++)
        {
            //Convert current char to binary, using method "CheckHexadecimalSign(char hexSign)"
            currentDigit = CheckHexadecimalSign(hexNumber[i]);
            binaryRepresentation.Add(currentDigit);
        }

        return binaryRepresentation;
    }

    /// <summary>
    /// Convert hexadecimal sign into binary
    /// </summary>
    /// <param name="hexSign">Char to convert</param>
    /// <returns>String of binary representation</returns>
    private static string CheckHexadecimalSign(char hexSign)
    {
        switch (hexSign)
        {
            case '0': return "0000";
            case '1': return "0001";
            case '2': return "0010";
            case '3': return "0011";
            case '4': return "0100";
            case '5': return "0101";
            case '6': return "0110";
            case '7': return "0111";
            case '8': return "1000";
            case '9': return "1001";
            case 'A': return "1010";
            case 'B': return "1011";
            case 'C': return "1100";
            case 'D': return "1101";
            case 'E': return "1110";
            case 'F': return "1111";
            default: return "Error!";
        }
    }

    /// <summary>
    /// Print given list of strings
    /// </summary>
    /// <param name="listToPrint">List to print</param>
    private static void PrintList(List<string> listToPrint)
    {
        Console.Write("Binary: ");

        foreach (var element in listToPrint)
        {
            Console.Write(element);
        }

        Console.WriteLine();
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
                //Only 0-9 and A-F is allowed
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
