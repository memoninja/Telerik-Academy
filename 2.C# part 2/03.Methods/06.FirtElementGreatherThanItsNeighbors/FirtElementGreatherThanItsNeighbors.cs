// 06. Write a method that returns the index of the first element in array that is bigger than its neighbors,
//     or -1, if there’s no such element.
//     Use the method from the previous exercise.

using System;

class FirtElementGreatherThanItsNeighbors
{
    static void Main()
    {
        //The program print the index of the first number that is greather than it's neighbors

        int[] givenArray;
        int indexOfGreatherElement;

        givenArray = ValidateInputIntegerArray(); //Using method "ValidateInputIntegerArray();" to validate the entered array of integers

        //Assigned the returned integer from method "CompareNeighboringElements(int[] arrayToSearch)"
        indexOfGreatherElement = CompareNeighboringElements(givenArray);

        Console.WriteLine("Index of greather element: {0}", indexOfGreatherElement);
    }

    //Method is private, because we do not want to be used anywhere else
    //Method to compare neighboring elements in an array
    //Return type is "int"
    private static int CompareNeighboringElements(int[] arrayToSearch) //Mathod is with one parameters
    {
        //Loop to iterate through the array and compare neighbor elements. 
        //Start from 1 and go to array's length - 1, because we access the neighbor indexes (+1 and -1 of current index)
        //If wanted element is found return it's index, else return -1
        for (int i = 1; i < arrayToSearch.Length - 1; i++) 
        {
            if (arrayToSearch[i] > arrayToSearch[i - 1] && arrayToSearch[i] > arrayToSearch[i + 1])
            {
                return i;
            }
        }

        return -1;
    }

    //Method is private, because we do not want to be used anywhere else
    //Return type is "int[]"
    private static int[] ValidateInputIntegerArray() //Method to validate the input array of integers
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

        return arrayOfIntegers; //Return array of integer after they are validate
    }
}
