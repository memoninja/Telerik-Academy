// 07. Write a method that reverses the digits of given decimal number. Example: 256 -> 652

using System;

class ReverseDigitsOfDecimalNumber
{
    static void Main()
    {
        int givenNumber;
        int reversedNumber;

        givenNumber = ValidateInputInteger("Enter number to reverse: "); //Using method "ValidateInputInteger(string textToPrint)" to validate the input number

        reversedNumber = ReverseNumberDigits(givenNumber); //Using method "ReverseNumberDigits(int numberToReverse)" to reverse the order of the digits

        Console.WriteLine(new string('=', 40));
        Console.WriteLine("Reversed number: {0}", reversedNumber);
    }

    /// <summary>
    /// Revers digits of number
    /// </summary>
    /// <param name="numberToReverse">Number to reverse</param>
    /// <returns>Reversed number</returns>
    private static int ReverseNumberDigits(int numberToReverse) //Method have one parameter
    {
        char[] numberToCharArray;
        int reversedNumber;
        
        //Check if number is negative, and make it positive if so. Use a boolena for a flag, if number is negative, so we can make it negative again
        bool isNegative = false;

        if (numberToReverse < 0)
        {
            numberToReverse *= -1;

            isNegative = true;
        }

        numberToCharArray = numberToReverse.ToString().ToCharArray(); //Convert number to char array

        Array.Reverse(numberToCharArray); //Use "Array.Reverse()" to reverse the order of the elements(digits) in the array

        reversedNumber = int.Parse(new string(numberToCharArray)); //Convert char array back to integer

        if (isNegative) //If given number was negative, make it back to negative
        {
            reversedNumber *= -1;
        }

        return reversedNumber; //return the reversed number
    }

    /// <summary>
    /// Check if input number is correct integer
    /// </summary>
    /// <param name="textToPrint">Text to display</param>
    /// <returns>Return validated number</returns>
    private static int ValidateInputInteger(string textToPrint) //Method have one parameter
    {
        int givenInteger;

        Console.Write(textToPrint);

        while (!int.TryParse(Console.ReadLine(), out givenInteger)) //Loop goes on, until a correct integer is entered
        {
            Console.Write("Please enter correct integer: ");
        }

        return givenInteger; //The method returns the input integer, after it is validated
    }
}
