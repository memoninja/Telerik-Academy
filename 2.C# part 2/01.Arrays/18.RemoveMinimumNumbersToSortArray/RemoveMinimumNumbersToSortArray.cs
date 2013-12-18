// 18. * Write a program that reads an array of integers and removes from it a minimal number of elements
//       in such way that the remaining array is sorted in increasing order.
//       Print the remaining sorted array. Example:
//       {6, 1, 4, 3, 0, 3, 6, 4, 5} -> {1, 3, 3, 4, 5}

using System;
using System.Linq;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        int[] givenIntegerArray;
        int[] longestSequenceArray;

        givenIntegerArray = ValidateInputIntegerArray(); //Using method "ValidateInputIntegerArray()"
        if (givenIntegerArray == null) //If the input data is incorrect the method "ValidateInputIntegerArray()" will return "null", if so the program is terminated!
        {
            return;
        }

        longestSequenceArray = FindMaxIncreasingSequence(givenIntegerArray); // Using method "FindMaxIncreasingSequence(int[] givenArray)"
        PrintArray(longestSequenceArray); // Using method "PrintArray(int[] arrayToPrint)"
    }

    static int[] FindMaxIncreasingSequence(int[] givenArray) //Method to find the longest increasing sequence
    {
        int[] sequencesLength = new int[givenArray.Length];
        int[] sortedArray; //Array to store the longest increasing sequence, after it is found and sorted
        int currentMaxSequenceLength = 0; //Count of the current element maximum sequence length

        sequencesLength[0] = 1; //It is one, because the length of single number, as a sequence is 1

        for (int i = 1; i < givenArray.Length; i++) //Loop to iterate through the inupt array
        {
            currentMaxSequenceLength = 0; //Set it to 0 at each iteration.

            for (int j = 0; j < i; j++) //Loop to iterate through the array until it reaches the current position of the 'i'. Check the numbers before 'i'
            {
                //Check if previous element is not greather. The sequence of the current element 'j' must be greather, after all we are searching for the longest sequence :)
                if (givenArray[j] <= givenArray[i] && currentMaxSequenceLength < sequencesLength[j])
                {
                    currentMaxSequenceLength = sequencesLength[j];
                }
                //Always add 1 to the "currentMaxSequenceLength", because the length of the current element itself is 1
                sequencesLength[i] = currentMaxSequenceLength + 1;
            }
        }

        sortedArray = SortGivenArray(givenArray, sequencesLength); //Call method "SortGivenArray(int[] arrayToSort, int[] arrayOfSequences)"

        return sortedArray; //return the array after we find the longest sequence and e sort it.
    }

    static int[] SortGivenArray(int[] arrayToSort, int[] arrayOfSequences) //Method to sort given array by array of sequences
    {
        int[] sortedArray = new int[arrayOfSequences.Max()]; //Call method "Max()" to take the maximal number(sequence length) in the array. You have to add "using System.Linq;" to use this method(Max)
        int maxSequenceLength = arrayOfSequences.Max(); 

        for (int i = arrayToSort.Length - 1; i >= 0; i--) //Loop ti iterate backwards 
        {
            if (arrayOfSequences[i] == maxSequenceLength)
            {
                sortedArray[maxSequenceLength - 1] = arrayToSort[i]; //If there is a match, assign the value of current element in "arrayToSort" to the sorted array
                maxSequenceLength--; //Decrement if the current sequence length mathes the array of sequences
            }
        }

        return sortedArray; //return the array after it is sorted
    }

    static void PrintArray(int[] arrayToPrint) //Method to print given array
    {
        Console.WriteLine(new string('=', 40));

        Console.Write('{');

        for (int i = 0; i < arrayToPrint.Length; i++)
        {
            Console.Write(arrayToPrint[i]);

            if (i < arrayToPrint.Length - 1)
            {
                Console.Write(", ");
            }
        }

        Console.WriteLine('}');
    }

    static int[] ValidateInputIntegerArray() //Method to validate the input array of integers
    {
        string givenArray;
        string[] givenArrayToNumbers;
        int[] arrayOfIntegers;
        char[] sequenceCharsToRemove = { ',', ' ' }; // This array is used in the "split method" to remove comma and space in the input array

        Console.WriteLine("Please enter a sequence of numbers to be checked.");
        Console.WriteLine("It is allowed to separate the numbers with comma and/or space \", \"");

        givenArray = Console.ReadLine();

        //Using "StringSplitOptions.RemoveEmptyEntries" to remove the empty idexes of the array that will be left after split() method
        givenArrayToNumbers = givenArray.Split(sequenceCharsToRemove, StringSplitOptions.RemoveEmptyEntries);

        arrayOfIntegers = new int[givenArrayToNumbers.Length];

        for (int i = 0; i < givenArrayToNumbers.Length; i++) //Loop to assign the input numbers to a int array (int[])
        {
            //This is a validation of the input string. If the user type something different for a number, comma or space, the program will be terminated!
            if (!int.TryParse(givenArrayToNumbers[i], out arrayOfIntegers[i]))
            {
                Console.WriteLine(new string('=', 40));
                Console.WriteLine("Incorrect input integer!!!");
                return arrayOfIntegers = null;
            }
        }

        return arrayOfIntegers; //Return array of integer after they are validate
    }
}