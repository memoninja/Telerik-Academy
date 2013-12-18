// 05. You are given an array of strings.
//     Write a method that sorts the array by the length of its elements
//     (the number of characters composing them).

using System;
using System.Collections.Generic;
using System.Linq;

class SortArrayOfStringsByLength
{
    static void Main()
    {
        int arrayLength;
        string[] stringArray;

        //Using method "ValidateSequenceLengthInteger(string textToDisplay)" to validate the array length
        arrayLength = ValidateArrayLengthInteger("Please enter array length: ");

        stringArray = new string[arrayLength]; //Assign length of the array of strings

        EnterElementsToStringArray(stringArray); //Enter values to each index, by method "EnterElementsToStringArray(string[] arrayToEnterElements)"

        SortStringsByLength(stringArray); //Sorting the array with Insertionsort algorith, by method "SortStringsByLength(string[] arrayToSort)"

        Console.WriteLine(new string('=', 40));

        PrintArray(stringArray, "Sorted array be elemetns length!"); //Print the sorted array, by method "PrintArray(string[] arrayToPrint, string textToDisplay)"
    }

    static void SortStringsByLength(string[] arrayToSort) //Sort the array with Insertionsort algorithm
    {
        for (int i = 1; i < arrayToSort.Length; i++)
        {
            for (int j = i; j > 0; j--)
            {
                //If previous element length is lower, swap current and previous element values
                if (arrayToSort[j - 1].Length > arrayToSort[j].Length)
                {
                    string buffer = arrayToSort[j - 1];
                    arrayToSort[j - 1] = arrayToSort[j];
                    arrayToSort[j] = buffer;
                }
            }
        }
    }

    static void EnterElementsToStringArray(string[] arrayToEnterElements)
    {
        for (int i = 0; i < arrayToEnterElements.Length; i++) //Loop to assign values to each index of the given array
        {
            Console.Write("Enter element at index {0}:  ", i);
            arrayToEnterElements[i] = Console.ReadLine();
        }

    }

    static int ValidateArrayLengthInteger(string textToDisplay) //Method to validate the input data
    {
        int validatedInteger;

        Console.Write(textToDisplay);

        while (true) //If number is invalide or is less than 1, the input will no be accepted
        {
            while (!int.TryParse(Console.ReadLine(), out validatedInteger))
            {
                Console.WriteLine("Please enter a correct integer number!");
            }

            if (validatedInteger > 0) //Array index can Not be negative! Also there is no point to set 0
            {
                break;
            }
            else
            {
                Console.WriteLine("Please enter positive integer, greather than 0!");
            }
        }

        return validatedInteger;
    }

    static void PrintArray(string[] arrayToPrint, string textToDisplay) //Print given array
    {
        Console.WriteLine(textToDisplay);

        for (int i = 0; i < arrayToPrint.Length; i++) //Loop to print the value of each index
        {
            Console.WriteLine("Index {0}: {1}", i, arrayToPrint[i]);
        }
    }
}
