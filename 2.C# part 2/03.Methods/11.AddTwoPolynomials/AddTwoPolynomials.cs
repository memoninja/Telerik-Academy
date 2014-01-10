// 11. Write a method that adds two polynomials. Represent them as arrays of their coefficients as in the example below:
//		x2 + 5 = 1x2 + 0x + 5 -> (5,0,1)

using System;

class AddTwoPolynomials
{
    static void Main()
    {
        string firstPolinom;
        string secondPolinom;
        int[] sumOfPolinoms;

        //Using method "ValidateInputInteger(string textToPrint)" to validate the input string
        firstPolinom = ValidateInputInteger("Enter first polinom: ");
        secondPolinom = ValidateInputInteger("Enter second polinom: ");

        Console.WriteLine(new string('=', 40));

        //Call method "AddTwoPolinoms(string firstPolinom, string secondPolinom)" to add the polinoms
        AddTwoPolinoms(firstPolinom, secondPolinom);
    }

    /// <summary>
    /// Add two polinoms represented as arrays
    /// </summary>
    /// <param name="firstPolinom">First polinom to add</param>
    /// <param name="secondPolinom">Second polinom to add</param>
    private static void AddTwoPolinoms(string firstPolinom, string secondPolinom)
    {
        int[] sumOfPolinoms;
        int[] polinomToAdd;

        //Check for the greather string length and set the length of the array where the polinoms will be added
        if (firstPolinom.Length > secondPolinom.Length)
        {
            sumOfPolinoms = new int[firstPolinom.Length];
            ConvertStringToArrayOfInt(secondPolinom).CopyTo(sumOfPolinoms, 0); //Using method "ConvertStringToArrayOfInt(string stringToConvert)", to convert the string into array, and copy it

            polinomToAdd = new int[firstPolinom.Length];
            ConvertStringToArrayOfInt(firstPolinom).CopyTo(polinomToAdd, 0); //Using method "ConvertStringToArrayOfInt(string stringToConvert)", to convert the string into array, and copy it
        }
        else //(secondPolinom >= firstPolinom)
        {
            sumOfPolinoms = new int[secondPolinom.Length];
            ConvertStringToArrayOfInt(firstPolinom).CopyTo(sumOfPolinoms, 0); //Using method "ConvertStringToArrayOfInt(string stringToConvert)", to convert the string into array, and copy it

            polinomToAdd = new int[secondPolinom.Length];
            ConvertStringToArrayOfInt(secondPolinom).CopyTo(polinomToAdd, 0); //Using method "ConvertStringToArrayOfInt(string stringToConvert)", to convert the string into array, and copy it
        }

        //Loop to add polinoms, represented ad arrays
        for (int i = 0; i < sumOfPolinoms.Length; i++)
        {
            sumOfPolinoms[i] += polinomToAdd[i];
        }

        PrintArray(sumOfPolinoms);
    }

    /// <summary>
    /// Convert string into array of integers
    /// </summary>
    /// <param name="stringToConvert">String to be converted</param>
    /// <returns>Array of integers</returns>
    private static int[] ConvertStringToArrayOfInt(string stringToConvert)
    {
        int[] convertedNumber = new int[stringToConvert.Length];

        //Loop to convert string into array of digits
        for (int i = 0; i < convertedNumber.Length; i++)
        {
            convertedNumber[i] = stringToConvert[i] - '0';
        }

        return convertedNumber;
    }

    /// <summary>
    /// Print given polinom, represented as array
    /// </summary>
    /// <param name="ArrayToPrint">Array to be printed</param>
    private static void PrintArray(int[] ArrayToPrint)
    {
        for (int i = ArrayToPrint.Length - 1; i > 0; i--)
        {
            if (ArrayToPrint[i] != 0)
            {
                Console.Write("{0}*x^{1}", ArrayToPrint[i], i);
                Console.Write(" + ");
            }
        }

        Console.WriteLine(ArrayToPrint[0]);
    }

    /// <summary>
    /// Validate integer, input from the user. It must be greather than or equal 0
    /// </summary>
    /// <param name="textToPrint">Message to be printed</param>
    /// <returns>Validated integer</returns>
    private static string ValidateInputInteger(string textToPrint) //Method have one parameter
    {
        int givenInteger;

        Console.Write(textToPrint);

        while (true)
        {
            while (!int.TryParse(Console.ReadLine(), out givenInteger)) //Loop goes intil a correct integer is entered
            {
                Console.Write("Please enter correct integer: ");
            }

            //Check if given factorial sequence(range) is less than 0
            if (givenInteger < 0)
            {
                Console.WriteLine("N can not be less than 0! Please enter correct integer: ");
            }
            else
            {
                break;
            }
        }

        return givenInteger.ToString(); //The method returns the input integer, after it is validated
    }
}
