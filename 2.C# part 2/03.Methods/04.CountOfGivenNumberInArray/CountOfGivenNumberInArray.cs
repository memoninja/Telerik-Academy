// 04. Write a method that counts how many times given number appears in given array.
//     Write a test program to check if the method is working correctly.

using System;

class CountOfGivenNumberInArray
{
    static void Main()
    {
        int givenNumber;
        int[] givenArray;
        int countOfNumber;

        givenArray = ValidateInputIntegerArray(); //Using method "ValidateInputIntegerArray();" to validate the entered array of integers
        givenNumber = ValidateInputInteger("Please eneter number to search for: "); //Using method "ValidateInputInteger(string textToPrint)" to validate the input integer number
        countOfNumber = CountOfGivenNumber(givenNumber, givenArray); //Using method "CountOfGivenNumber(int numberToCount, int[] arrayToSearch)" to count how many times "numberToCount" appear in "arrayToSearch"

        Console.WriteLine(new string('=', 40));
        Console.WriteLine("Number {0} appears {1} times.", givenNumber, countOfNumber);
    }

    //Method to count how manu times a given number appears in an array
    //"numberToCount" is the number we search for in array "arrayToSearch"
    private static int CountOfGivenNumber(int numberToCount, int[] arrayToSearch) //Method is with two parameters
    {
        int countOfNumber = 0;

        for (int i = 0; i < arrayToSearch.Length; i++) //Loop to iterate through the array
        {
            if (arrayToSearch[i] == numberToCount)
            {
                countOfNumber++;
            }
        }

        return countOfNumber; //Return the count of input number, in the array
    }

    //Method is private, because we do not want to be used anywhere else
    //Check if input number is correct integer
    private static int ValidateInputInteger(string textToPrint) //Method have one parameter
    {
        int givenInteger;

        Console.Write(textToPrint);

        while (!int.TryParse(Console.ReadLine(), out givenInteger))
        {
            Console.Write("Please enter correct integer: ");
        }

        return givenInteger; //The method returns the input integer, after it is validated
    }

    //Method is private, because we do not want to be used anywhere else
    //Method to validate the input array of integers
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
}
