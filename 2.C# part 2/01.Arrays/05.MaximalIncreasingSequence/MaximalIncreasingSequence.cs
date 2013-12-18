// 05. Write a program that finds the maximal increasing sequence in an array.
// Example: {3, 2, 3, 4, 2, 2, 4} -> {2, 3, 4}.

using System;

class MaximalIncreasingSequence
{
    static void Main(string[] args)
    {
        // The program is made to work like the example in the description
        // You can separate the chars with comma and space: ", ", if you want to!
        // If the sequences length are the same the program will print the first sequence as maximal

        string givenArray;
        string[] givenArrayToNumbers;
        int[] arrayOfIntegers;

        int currentSequenceLength = 0;
        int maximalSequenceLength = 0;
        int maxNumberOfMaximalSequence = 0;
        char[] sequenceCharsToRemove = { ',', ' '}; // This array is used in the "split method" to remove comma and space int the input array

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
        for (int i = 0; i < arrayOfIntegers.Length - 1; i++) // Loop to compare the numbers in the in the array
        {
            if (arrayOfIntegers[i + 1] == arrayOfIntegers[i] + 1) // Check if current number plus 1 equals the next number
            {
                currentSequenceLength++;

                if (currentSequenceLength > maximalSequenceLength) // If current sequence length is greather than the maximal
                {                                                  // we assign it for maximal length
                    maxNumberOfMaximalSequence = arrayOfIntegers[i + 1];
                    maximalSequenceLength = currentSequenceLength;
                }
            }
            else
            {
                currentSequenceLength = 0; // If the current number and the next one are not in sequence set "currentSequenceLength" to zero
            }
        }

        if (maximalSequenceLength > 0) // Check if there is a sequence and add 1, because for the first two numbers of the sequence we have only 1(1 point)
        {
            maximalSequenceLength += 1;
        }

        //Printing output
        Console.WriteLine(new string('=', 50));
        Console.WriteLine("maximal sequence length: {0}", maximalSequenceLength);

        Console.Write('{');
        // Loop to print the maximal sequence
        for (int i = maxNumberOfMaximalSequence - maximalSequenceLength + 1; i <= maxNumberOfMaximalSequence; i++)
        {
            Console.Write(i);
            if (i < maxNumberOfMaximalSequence) // Check if the current number is not the last of the sequence, and put comma and space
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine('}');
    }
}