// 08. Write a program that finds the sequence of maximal sum in given array. Example:
//	{2, 3, -6, -1, 2, -1, 6, 4, -8, 8} -> {2, -1, 6, 4}
//	Can you do it with only one loop (with single scan through the elements of the array)?

using System;

class MaximalSumInGivenArray
{
    static void Main(string[] args)
    {
        string givenArray;
        string[] givenArrayToNumbers;
        int[] arrayOfIntegers;
        char[] sequenceCharsToRemove = { ',', ' ' }; // This array is used in the "split method" to remove comma and space in the input array

        int maximalSum = 0;
        int currentSum = 0;
        int starIndexOfMaxSum = 0;
        int endIndexOfMaxSum = 0;

        Console.WriteLine("Please enter a sequence of numbers to be checked.");
        Console.WriteLine("It is allowed to separate the numbers with comma and space \", \"");
        
        givenArray = Console.ReadLine();
        // Using "StringSplitOptions.RemoveEmptyEntries" to remove the empty idexes of the array  that will be left after split() method
        givenArrayToNumbers = givenArray.Split(sequenceCharsToRemove, StringSplitOptions.RemoveEmptyEntries);

        arrayOfIntegers = new int[givenArrayToNumbers.Length];

        for (int i = 0; i < givenArrayToNumbers.Length; i++) // Loop to assign the input numbers to a int array (int[])
        {
            //This is a validation of the input string. If hte user type something different for a number, comma or space, the program will be terminated!
            if (!int.TryParse(givenArrayToNumbers[i], out arrayOfIntegers[i]))
            {
                Console.WriteLine(new string('=', 40));
                Console.WriteLine("Incrrect input string!!!");
                return;
            }
        }

        //Logic of the exercise
        for (int i = 0; i < arrayOfIntegers.Length; i++) //Loop to sum the elements of the array
        {
            if (currentSum < 0) //If current sum is less than 0 the current sum become 0, 
            {
                currentSum = 0;
                starIndexOfMaxSum = i; // Start index of secquence is set to the current index of the array, so we can track the sequence and print it
            }
            
            currentSum += arrayOfIntegers[i];

            if (currentSum > maximalSum) //If current sum is greather than maximal sum, the current sum values is assigned to maximal sum
            {
                maximalSum = currentSum;
                endIndexOfMaxSum = i; //End index of secquence is set to the current index of the array, so we can track the sequence and print it
            }
        }

        //Printing the ouput!
        Console.Write('{');
        // Loop to print the maximal sequence
        for (int i = starIndexOfMaxSum; i <= endIndexOfMaxSum; i++)
        {
            Console.Write(arrayOfIntegers[i]);
            if (i < endIndexOfMaxSum)// Check if the current number is not the last of the sequence, and put comma and space
            {
                Console.Write(", ");
            }
        }
        Console.Write('}');

        Console.WriteLine(" -> {0}", maximalSum);
    }
}