// 14. Write a program that sorts an array of strings using the quick sort algorithm (find it in Wikipedia).

using System;
using System.Collections.Generic;
using System.Linq;

class QuickSortAlgorithm
{
    static void Main()
    {
        //The elements of the array can be entered sepated by space, comma or both!

        string givenArray;
        string[] givenArrayToNumbers;
        int[] arrayOfIntegers;
        char[] sequenceCharsToRemove = { ',', ' ' }; // This array is used in the "split method" to remove comma and space in the input array


        //This part is for entering the elements of the array!
        //===========================================================================================

        Console.WriteLine("Please enter a sequence of numbers to be sort.");
        Console.WriteLine("It is allowed to separate the numbers with comma and space \", \"");

        givenArray = Console.ReadLine();

        //Using "StringSplitOptions.RemoveEmptyEntries" to remove the empty idexes of the array that will be left after split() method
        givenArrayToNumbers = givenArray.Split(sequenceCharsToRemove, StringSplitOptions.RemoveEmptyEntries);

        arrayOfIntegers = new int[givenArrayToNumbers.Length];

        for (int i = 0; i < givenArrayToNumbers.Length; i++) //Loop to assign the input numbers to a int array (int[])
        {
            //This is a validation of the input string. If hte user type something different for a number, comma or space, the program will be terminated!
            if (!int.TryParse(givenArrayToNumbers[i], out arrayOfIntegers[i]))
            {
                Console.WriteLine(new string('=', 40));
                Console.WriteLine("Incorrect input integer!!!");
                return;
            }
        }

        //Sort the array using Quicksort algorithm, with method "QuickSortArray(int[] arrayToSort, int leftIndex, int rightIndex)"
        QuickSortArray(arrayOfIntegers, 0, (arrayOfIntegers.Length - 1));

        //Output
        Console.WriteLine(new string('=', 40));

        //Print the sorted array, using method "PrintArray(int[] arrayToPrint, string textToDisplay)"
        PrintArray(arrayOfIntegers, "Sorted array, using \"Quicksort\" algorithm!");
    }

    //Method to sort the different parts of the array, using Quicksort algorithm
    static int Partition(int[] arrayToSort, int leftIndex, int rightIndex, int pivotIndex)
    {
        int pivotValue = arrayToSort[pivotIndex]; // Assign the value at pivot index to a separate variable
        int storeIndex = leftIndex; //The comparison start from left to right, so ew seth the store index to the left most index
        int buffer;

        // Swap the values of the pivot index and right(last) index
        arrayToSort[pivotIndex] ^= arrayToSort[rightIndex];
        arrayToSort[rightIndex] ^= arrayToSort[pivotIndex];
        arrayToSort[pivotIndex] ^= arrayToSort[rightIndex];

        for (int i = leftIndex; i < rightIndex; i++) //Iterate through the array to sort the lower numbers to the left and greather remain to the right
        {
            if (arrayToSort[i] <= pivotValue)
            {
                //Swap the values of the current index and the stored index
                buffer = arrayToSort[i];
                arrayToSort[i] = arrayToSort[storeIndex];
                arrayToSort[storeIndex] = buffer;

                storeIndex++;
            }
        }

        // Swap the values of the stored index index and right(last) index, where is the pivot value
        buffer = arrayToSort[storeIndex];
        arrayToSort[storeIndex] = arrayToSort[rightIndex];
        arrayToSort[rightIndex] = buffer;

        return storeIndex;
    }

    //Method to set the bounds of the different parts of the array to be sorted
    static void QuickSortArray(int[] arrayToSort, int leftIndex, int rightIndex)
    {
        if (leftIndex < rightIndex)
        {
            int pivotNewIndex;
            //Set the position of the pivot. There are different ways to set pivot index. I set the middle index
            int pivotIndex = leftIndex + ((rightIndex - leftIndex) / 2);

            pivotNewIndex = Partition(arrayToSort, leftIndex, rightIndex, pivotIndex);

            QuickSortArray(arrayToSort, leftIndex, pivotNewIndex - 1); // Recursively call "QuickSortArray" for the left part of the current partition.
            QuickSortArray(arrayToSort, pivotNewIndex + 1, rightIndex); //We exclude the previous pivot index, because it is already on its place
        }
    }
    
    static void PrintArray(int[] arrayToPrint, string textToDisplay) //Print given array
    {
        Console.WriteLine(textToDisplay);
        Console.Write('{');

        //Loop to print the array
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
}