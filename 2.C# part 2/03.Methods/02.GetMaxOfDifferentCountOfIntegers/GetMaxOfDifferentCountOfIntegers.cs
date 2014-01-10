// 02. Write a method GetMax() with two parameters that returns the bigger of two integers.
//Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().

using System;

class GetMaxOfDifferentCountOfIntegers
{
    static void Main()
    {
        //Usign method "ValidateInputInteger(string textToPrint)" to validate the input integer
        int firstInteger = ValidateInputInteger("Please enter first integer: ");
        int secondInteger = ValidateInputInteger("Please enter second integer: ");
        int thirdInteger = ValidateInputInteger("Please enter third integer: ");

        Console.Write("Greathest of ({0}, {1}, {2}) is: ", firstInteger, secondInteger, thirdInteger);
        //Usign two nested methods "GetMax()" to find the greatest of the integers
        Console.WriteLine(GetMax(thirdInteger, GetMax(firstInteger, secondInteger)));
    }

    /// <summary>
    /// Find greather number
    /// </summary>
    /// <param name="firstInteger">first number to compare</param>
    /// <param name="secondInteger">second number to compare</param>
    /// <returns>Greather number</returns>
    private static int GetMax(int firstInteger, int secondInteger) //Method have two parameters
    {
        if (firstInteger > secondInteger)
        {
            return firstInteger;
        }
        else //If second integer is greather or equal, returns it
        {
            return secondInteger;
        }
    }

    /// <summary>
    /// Validate given integer
    /// </summary>
    /// <param name="textToPrint">Text to be printed</param>
    /// <returns>Validated integer</returns>
    private static int ValidateInputInteger(string textToPrint) //Check if input number is correct integer
    {
        int givenInteger;

        Console.Write(textToPrint);

        while (!int.TryParse(Console.ReadLine(), out givenInteger))
        {
            Console.Write("Please enter correct integer: ");
        }

        return givenInteger; //The method returns the input integer, after it is validated
    }
}
