// 04. Write a program, that reads from the console an array of N integers and an integer K, sorts the array
//     and using the method Array.BinSearch() finds the largest number in the array which is ≤ K. 

using System;
using System.Collections.Generic;
using System.Linq;

class UsingBinSearchToFindLargestElement
{
    //String.Join(", ", array)
    static int partitionSizeForQuickSort = 3;

    static void Main(string[] args)
    {
        //First sort the array with Quicksort algorithm. After the current partition size get smaller than "partitionSizeForQuickSort"
        //Sort the array with Insertionsort algorithm.
        //We can directly use "Array.Sort()", but after all, we have to practice

        int givenN;
        int givenK;
        int[] givenArray;
        int indexFromBinarySearch;

        //Validate input data, using method "ValidateSequenceLengthInteger(string textToDisplay)"
        givenN = ValidateSequenceLengthInteger("Please enter number N: ");

        //Validate input data, using method "ValidateInputInteger(string textToDisplay)"
        givenK = ValidateInputInteger("Please enter number K: ");
        
        givenArray = new int[givenN]; //Set the array length to "givenN"

        //Assign values to the array, using "ValidateInputIntegerArray(int arrayLengrh)"
        givenArray = ValidateInputIntegerArray(givenN);

        Console.WriteLine(new string('=', 50));

        //Sort the array using Quicksort algorithm, with method "QuickSortArray(int[] arrayToSort, int leftIndex, int rightIndex)"
        QuickSortArray(givenArray, 0, (givenArray.Length - 1));

        //Print the sorted array, using method "PrintArray(int[] arrayToPrint, string textToDisplay)"
        PrintArray(givenArray, "Sorted array, after using \"Quicksort\" algorithm");

        Console.WriteLine(new string('=', 50));

        //Sort the array using Insertionsort algorithm, with method "InsertionSortArray(int[] arrayToSort)"
        InsertionSortArray(givenArray);

        //Print the sorted array, using method "PrintArray(int[] arrayToPrint, string textToDisplay)"
        PrintArray(givenArray, "Sorted array, after using \"Insertionsort\" algorithm");

        Console.WriteLine(new string('=', 50));

        //Using "Array.BinarySearch()" to find the wanted number "givenK"
        indexFromBinarySearch = Array.BinarySearch(givenArray, givenK);

        //"Array.BinarySearch()" returns negative integer if the number is Not found. That negative integer is the index where is supposed to be the wanted number, plus 1
        if (indexFromBinarySearch < 0)
        {
            //Make the negative returned integer to positive.
            indexFromBinarySearch *= -1; 

            //Check if that integer, after we make it positive, is less than 2, if so the supposed index of the wanted number is 0, This means that there is no lower number in the array!
            if (indexFromBinarySearch < 2)
            {
                Console.WriteLine("There is neither {0}, nor lower number!", givenK);
            }
            else //If the integer is 2 or greather, we subtract 2 to find the index of the number that is closest to wanted number and less than it.
            {
                indexFromBinarySearch -= 2;
                Console.WriteLine("Lower number closest to {0} is: number {1} on index: {2}", givenK, givenArray[indexFromBinarySearch], indexFromBinarySearch);
            }
        }
        else //If number is found "Array.BinarySearch()" returns integer 0 or greather, and we print it
        {
            Console.WriteLine("Number {0} is on index: {1}", givenK, indexFromBinarySearch);
        }
    }

    //Method to sort the different parts of the array, using Quicksort algorithm
    static int Partition(int[] arrayToSort, int leftIndex, int rightIndex, int pivotIndex)
    {
        int pivotValue = arrayToSort[pivotIndex];
        int storeIndex = leftIndex;
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
        if (partitionSizeForQuickSort < (rightIndex - leftIndex)) //Quicksort is used while the current partition is larger than "partitionSizeForQuickSort", when it get smaller, insertion sort is used
        {
            int pivotNewIndex;
            int pivotIndex = leftIndex + ((rightIndex - leftIndex) / 2); //Set the position of the pivot

            pivotNewIndex = Partition(arrayToSort, leftIndex, rightIndex, pivotIndex);

            QuickSortArray(arrayToSort, leftIndex, pivotNewIndex - 1); // Recursively call "QuickSortArray" for the left part of the current partition.
            QuickSortArray(arrayToSort, pivotNewIndex + 1, rightIndex); //We exclude the previous pivot index, because it is already on its place
        }
    }

    static void InsertionSortArray(int[] arrayToSort) //Insertion sort algorithm is used after Quicksort sort the array for partition with size larger than "partitionSizeForQuickSort"
    {
        for (int i = 1; i < arrayToSort.Length; i++)
        {
            for (int j = i; j > 0; j--)
            {
                //If previous element is lower, swap current and previous element values
                if (arrayToSort[j - 1] > arrayToSort[j])
                {
                    arrayToSort[j - 1] ^= arrayToSort[j];
                    arrayToSort[j] ^= arrayToSort[j - 1];
                    arrayToSort[j - 1] ^= arrayToSort[j];
                }
            }
        }
    }

    static int ValidateSequenceLengthInteger(string textToDisplay) //Method to validate the input data
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

    static int ValidateInputInteger(string textToDisplay) //Method to validate the input integer
    {
        int validatedInteger;

        Console.Write(textToDisplay);

        while (!int.TryParse(Console.ReadLine(), out validatedInteger))
        {
            Console.WriteLine("Please enter a correct integer number!");
        }

        return validatedInteger;
    }

    static int[] ValidateInputIntegerArray(int arrayLengrh) //Method to validate the input integer array
    {
        int[] arrayValidatedArray = new int[arrayLengrh];

        for (int i = 0; i < arrayValidatedArray.Length; i++)
        {
            Console.Write("Please enter array element {0}: ", i);
            arrayValidatedArray[i] = ValidateInputInteger(""); //Using another method - "ValidateInputInteger(string textToDisplay)"
        }

        return arrayValidatedArray;
    }

    static void PrintArray(int[] arrayToPrint, string textToDisplay) //Print given array
    {
        Console.WriteLine(textToDisplay);

        Console.Write('{');
        Console.Write(String.Join(", ", arrayToPrint));
        Console.WriteLine('}');
    }
}
