// 12. Extend the program to support also subtraction and multiplication of polynomials.

using System;
using System.Collections.Generic;

class ExtendExercise11
{
    static void Main()
    {
        string firstPolinom;
        string secondPolinom;
        List<int> sumOfPolinoms = new List<int>(); ;

        //Using method "ValidateInputInteger(string textToPrint)" to validate the input string
        firstPolinom = ValidateInputInteger("Enter first polinom: ");
        secondPolinom = ValidateInputInteger("Enter second polinom: ");

        Console.WriteLine(new string('=', 40));

        //Call method "AddTwoPolinoms(string firstPolinom, string secondPolinom)" to add the polinoms
        AddTwoPolinoms(firstPolinom, secondPolinom);

        //Call method "SubtractTwoPolinoms(string firstPolinom, string secondPolinom)" to subtract the polinoms
        SubtractTwoPolinoms(firstPolinom, secondPolinom);

        //Call method "MultiplyTwoPolinoms(string firstPolinom, string secondPolinom)" to multiply the polinoms
        MultiplyTwoPolinoms(firstPolinom, secondPolinom);
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

        Console.WriteLine("Addition of polinoms:");
        PrintArray(sumOfPolinoms); //Print the sum of the polinoms with method "PrintArray(int[] ArrayToPrint)"
        Console.WriteLine(new string('=', 40));
    }

    /// <summary>
    /// Subtract two polinoms represented as arrays
    /// </summary>
    /// <param name="firstPolinom">First polinom to subtract</param>
    /// <param name="secondPolinom">Second polinom to subtract</param>
    private static void SubtractTwoPolinoms(string firstPolinom, string secondPolinom)
    {
        int[] subOfPolinoms;
        int[] polinomToAdd;

        //Check for the greather string length and set the length of the array where the polinoms will be added
        if (firstPolinom.Length > secondPolinom.Length)
        {
            subOfPolinoms = new int[firstPolinom.Length];
            ConvertStringToArrayOfInt(secondPolinom).CopyTo(subOfPolinoms, 0); //Using method "ConvertStringToArrayOfInt(string stringToConvert)", to convert the string into array, and copy it

            polinomToAdd = new int[firstPolinom.Length];
            ConvertStringToArrayOfInt(firstPolinom).CopyTo(polinomToAdd, 0); //Using method "ConvertStringToArrayOfInt(string stringToConvert)", to convert the string into array, and copy it
        }
        else //(secondPolinom >= firstPolinom)
        {
            subOfPolinoms = new int[secondPolinom.Length];
            ConvertStringToArrayOfInt(firstPolinom).CopyTo(subOfPolinoms, 0); //Using method "ConvertStringToArrayOfInt(string stringToConvert)", to convert the string into array, and copy it

            polinomToAdd = new int[secondPolinom.Length];
            ConvertStringToArrayOfInt(secondPolinom).CopyTo(polinomToAdd, 0); //Using method "ConvertStringToArrayOfInt(string stringToConvert)", to convert the string into array, and copy it
        }

        //Loop to add polinoms, represented ad arrays
        for (int i = 0; i < subOfPolinoms.Length; i++)
        {
            subOfPolinoms[i] -= polinomToAdd[i];
        }

        Console.WriteLine("Subtraction of polinoms:");
        PrintArray(subOfPolinoms); //Print the subtract of the polinoms with method "PrintArray(int[] ArrayToPrint)"
        Console.WriteLine(new string('=', 40));
    }

    /// <summary>
    /// Multiply two polinoms
    /// </summary>
    /// <param name="firstPolinom">First polinom to multiply</param>
    /// <param name="secondPolinom">Second polinom to multiply</param>
    private static void MultiplyTwoPolinoms(string firstPolinom, string secondPolinom)
    {
        int[] multiplyOfPolinoms = new int[firstPolinom.Length + secondPolinom.Length + 1];

        //Two nested loops to iterate through each index for both arrays
        for (int i = 0; i < firstPolinom.Length; i++)
        {
            for (int j = 0; j < secondPolinom.Length; j++)
            {
                //The index of "multiplyOfPolinoms" is "i+j", because we have indexes like: 1+2 and 2+1, which are the same
                multiplyOfPolinoms[i + j] += (firstPolinom[i] - '0') * (secondPolinom[j] - '0');
            }
        }

        Console.WriteLine("Multiplication of polinoms:");
        PrintArray(multiplyOfPolinoms); //Print the multiplication of the polinoms with method "PrintArray(int[] ArrayToPrint)"
        Console.WriteLine(new string('=', 40));
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
