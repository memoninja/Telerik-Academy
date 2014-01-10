// 09. Write a method that return the maximal element in a portion of array of integers starting at given index.
//     Using it write another method that sorts an array in ascending / descending order.
//     (12, 4 ,6 ,9, 0, 31, 7, 10)

using System;

class SortArrayAndFindElementInPortionOfArray
{
    static void Main()
    {
        int[] givenArray;
        int startIndex;
        int endIndex;
        int indexOfMaxElement;

        //Validate given input integer array, using "ValidateInputIntegerArray()"
        givenArray = ValidateInputIntegerArray();

        //Validate given input integer, using "ValidateInputInteger(string textToPrint, int arrayLength)"
        startIndex = ValidateInputInteger("Enter start index: ", givenArray.Length);
        endIndex = ValidateInputInteger("Enter end index: ", givenArray.Length);

        //Assing the index with maximal value, using method "FindMaximalElement(int startIndex, int endIndex, int[] arrayToSearch)"
        indexOfMaxElement = FindMaximalElement(startIndex, endIndex, givenArray);

        Console.WriteLine(new string('=', 60));
        Console.WriteLine("Index of maximal element: {0}", indexOfMaxElement);
        Console.WriteLine("Maximal value: {0}", givenArray[indexOfMaxElement]);

        //Sort the array, using method "SortArrayOfIntegers(int[] arrayToSort)"
        SortArrayOfIntegers(givenArray);

        //Print the array, using method "PrintArray(int[] arrayToPrint)"
        PrintArray(givenArray);
    }

    //Sort given array, using method "FindMaximalElement(int startIndex, int endIndex, int[] arrayToSearch)"
    //Return type is "int"
    private static void SortArrayOfIntegers(int[] arrayToSort) //Method have one parameter
    {
        int currentIndexOfMaxEl = 0;
        int buffer = 0;

        //Loop to decrease the area of search for maximal element. 
        for (int i = arrayToSort.Length - 1; i >= 0; i--)
        {
            //Using method to find the index of the maximal element
            currentIndexOfMaxEl = FindMaximalElement(0, i, arrayToSort);

            //Swap the last index with the maximal element. This is the way to sort the array
            buffer = arrayToSort[currentIndexOfMaxEl];
            arrayToSort[currentIndexOfMaxEl] = arrayToSort[i];
            arrayToSort[i] = buffer;
        }
    }

    //Find index of the maximal element in given porion of array
    //You can choose the exact part of array you want to search. Use start and end index.
    //Return type is "int"
    private static int FindMaximalElement(int startIndex, int endIndex, int[] arrayToSearch) //Method have three parameter
    {
        int maximalElement = int.MinValue;
        int indexOfMaxElement = 0;

        //Loop to check each index of the array
        for (int i = startIndex; i <= endIndex; i++)
        {
            if (arrayToSearch[i] > maximalElement)
            {
                maximalElement = arrayToSearch[i];
                indexOfMaxElement = i;
            }
        }

        return indexOfMaxElement; //Return the index of the maximal element
    }

    //Check if input number is correct integer
    //Return type is "int"
    private static int ValidateInputInteger(string textToPrint, int arrayLength) //Method have one parameter
    {
        int givenInteger;

        Console.Write(textToPrint);

        while (true)
        {
            while (!int.TryParse(Console.ReadLine(), out givenInteger))
            {
                Console.Write("Please enter correct integer: ");
            }

            //Check if index is greather than array length or less than 0
            if (givenInteger < 0 || givenInteger >= arrayLength)
            {
                Console.WriteLine("Index can not be less than 0 or greather than array length!");
                Console.Write("Please enter correct integer: ");
            }
            else
            {
                break;
            }
        }

        return givenInteger; //The method returns the input integer, after it is validated
    }

    //Method to validate the input array of integers
    //Return type is "int[]" - array
    private static int[] ValidateInputIntegerArray() //Method have no parameters
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
                Environment.Exit(1);
            }
        }

        return arrayOfIntegers; //Return array of integer after they are validated
    }

    //Method to print given array of integers
    //Return type is void - return nothing
    private static void PrintArray(int[] arrayToPrint) //Method have one parameter
    {
        Console.WriteLine(new string('=', 60));
        Console.WriteLine(String.Join(", ", arrayToPrint));
    }
}
