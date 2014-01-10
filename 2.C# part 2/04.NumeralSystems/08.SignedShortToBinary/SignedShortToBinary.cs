// 08. Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

using System;
using System.Text;

class SignedShortToBinary
{
    static void Main()
    {
        short shortInteger;
        string binaryRepresentation;

        shortInteger = ValidateInputShort(); //Validate that input integet is type "short", using method "ValidateInputShort()"

        binaryRepresentation = ConvertToBinary(shortInteger); //Convert to binary, using method "ConvertToBinary(short numToConvert)"

        Console.WriteLine(new string('=', 30));
        Console.WriteLine("Binary: {0}", binaryRepresentation);
    }

    /// <summary>
    /// Convert signed short to binary
    /// </summary>
    /// <param name="numToConvert">Number to convert</param>
    /// <returns>Binary representation</returns>
    private static string ConvertToBinary(short numToConvert)
    {
        int currentBit;
        StringBuilder binaryNumber = new StringBuilder(); //This is faster than usual string and operator "+"

        for (int i = 15; i >= 0; i--)
        {
            currentBit = (numToConvert >> i) & 1;
            binaryNumber.Append(currentBit); //On each iteration append the current bit to the string
        }

        return binaryNumber.ToString();
    }

    /// <summary>
    /// Validate input integer number
    /// </summary>
    /// <returns>Validated integer</returns>
    private static short ValidateInputShort()
    {
        short inputNumber;

        while (true) //Loop goes, until a correct short integer is entered
        {
            Console.Write("Enter short integer number: ");

            while (!short.TryParse(Console.ReadLine(), out inputNumber))
            {
                Console.Write("Enter correct short integer: ");
            }

            return inputNumber;
        }
    }
}
