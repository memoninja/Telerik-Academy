// 10. Write a program that finds in given array of integers a sequence of given sum S (if present).
//   Example:	{4, 3, 1, 4, 2, 5, 8}, S=11 -> {4, 2, 5}

using System;

class FindSequenceOfGivenSum
{
    static void Main(string[] args)
    {
        // The program is made to work like the example in the description, but not only for digits!
        // You can separate the chars with comma and space: ", ", if you want to!

        string givenArray;
        string[] givenArrayToNumbers;
        int[] arrayOfIntegers;
        char[] sequenceCharsToRemove = { ',', ' ' }; // This array is used in the "split method" to remove comma and space in the input array

        int givenSumS;
        int currentSum = 0;
        int starIndexOfGivenSum = 0;
        int endIndexOfGivenSum = 0;
        bool isSumFound = false;

        Console.WriteLine("Please enter a sequence of numbers to be checked.");
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

        Console.WriteLine("Please enter sum \"S\" to be found!");
        while (!int.TryParse(Console.ReadLine(), out givenSumS)) //Loopt to validate that a correct integer for sum "S" is entered.
        {
            Console.WriteLine("Please enter a correct integer number!");
        }

        //Main logic of the exercise
        for (int i = 0; i < arrayOfIntegers.Length - 1; i++) //Loop to iterate trought the array
        {
            if (isSumFound) //If the sum is found break this loop too, we do not need to do checks any more
            {
                break;
            }

            currentSum = arrayOfIntegers[i]; //Assign current element value to current sum

            if (currentSum == givenSumS) //Check If sum is equal to one of the elements in the array
            {
                isSumFound = true;
                starIndexOfGivenSum = i;
                endIndexOfGivenSum = i;
                break;
            }

            for (int j = i + 1; j < arrayOfIntegers.Length; j++) //Nested loop to iterate trought the array
            {
                currentSum += arrayOfIntegers[j]; // Add current element value to the current sum

                if (currentSum == givenSumS)// Check if sum is found and break the current loop and keep the indexes of the first and last number of the sequence, so we can print it
                {
                    isSumFound = true;
                    starIndexOfGivenSum = i;
                    endIndexOfGivenSum = j;
                    break;
                }
            }
        }

        //Printing the ouput!
        Console.WriteLine(new string('=', 40));

        if (isSumFound) //Check if wanted sum is found
        {
            Console.Write('{');
            // Loop to print the sequence
            for (int i = starIndexOfGivenSum; i <= endIndexOfGivenSum; i++)
            {
                Console.Write(arrayOfIntegers[i]);
                if (i < endIndexOfGivenSum)// Check if the current number is not the last of the sequence, and put comma and space
                {
                    Console.Write(", ");
                }
            }
            Console.Write('}');
            Console.WriteLine(" -> {0}", givenSumS);
        }
        else
        {
            Console.WriteLine("Wanted sum was Not found!");
        }
    }
}