// 04. Write a program that finds the maximal sequence of equal elements in an array.
// Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1} -> {2, 2, 2}.

using System;

class MaximalSequenceOfEqualElements
{
    static void Main(string[] args)
    {
        // The program is made to work like the example in the description, but not only for digits!
        // You can separate the chars with comma and space: ", ", if you want to!
        // If the sequences length are the same the program will print the first sequence as maximal

        string givenArray;

        int currentSequenceLength = 0;
        int maximalSequenceLength = 0;
        char sequenceChar = (char)32;

        Console.WriteLine("Please enter a sequence to be check.\nNote that the chars can be separated with comma and space \", \"");
        givenArray = Console.ReadLine(); // String is array of char, so we can compare the symbol directly
        
        for (int i = 0; i < givenArray.Length - 3; i += 3) // Loop to compare the chars in the string
        {
            if (givenArray[i] == givenArray[i + 3]) // Check if the current char and the next one are the same
            {
                currentSequenceLength++;
                if (currentSequenceLength > maximalSequenceLength) // If current sequence length is greather than the maximal
                {                                                  // we assign it for maximal length
                    sequenceChar = givenArray[i];
                    maximalSequenceLength = currentSequenceLength;
                }
            }
            else
            {
                currentSequenceLength = 0; // If the current char and the next one are not the same set "currentSequenceLength" to zero
            }
        }

        if (maximalSequenceLength > 0) // Check if there is a sequence and add 1, because for the first two char of the sequence we have only 1(1 point)
        {
            maximalSequenceLength += 1;
        }

        Console.WriteLine(new string('=', 50));
        Console.WriteLine("maximal sequence length: {0}", maximalSequenceLength);

        Console.Write('{');
        for (int i = 0; i < maximalSequenceLength; i++) // Loop to print the maximal sequence
        {
            Console.Write(sequenceChar);
            if (i < maximalSequenceLength - 1) // Check if the current symbol is not the last of the sequence, and put comma and space
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine('}');
    }
}