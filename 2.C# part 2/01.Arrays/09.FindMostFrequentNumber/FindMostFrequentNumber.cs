// 09. Write a program that finds the most frequent number in an array. Example:
//	   {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3} -> 4 (5 times)

using System;

class FindMostFrequentNumber
{
    static void Main(string[] args)
    {
        // The program is made to work like the example in the description, but not only for digits!
        // You can separate the chars with comma and space: ", ", if you want to!
        // If the sequences length are the same the program will print the first sequence as maximal!

        string givenArray;
        string[] givenArrayToNumbers;
        int[] arrayOfIntegers;
        char[] sequenceCharsToRemove = { ',', ' ' }; // This array is used in the "split method" to remove comma and space in the input array

        int maxFrequentNumber;
        int currentNumberFrequencyCounter = 1;
        int maximalFrequencyOfNumber = 1;

        Console.WriteLine("Please enter a sequence of numbers to be checked.");
        Console.WriteLine("It is allowed to separate the numbers with comma and space \", \"");

        givenArray = Console.ReadLine();
        //Using "StringSplitOptions.RemoveEmptyEntries" to remove the empty idexes of the array that will be left after split() method
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
        maxFrequentNumber = arrayOfIntegers[0];

        for (int i = 0; i < arrayOfIntegers.Length - 1; i++) // 2 nested Loop to iterate trought the array
        {
            currentNumberFrequencyCounter = 1;
            for (int j = i + 1; j < arrayOfIntegers.Length; j++)
            {
                if (arrayOfIntegers[i] == arrayOfIntegers[j])// If find same digits add 1 to the counter
                {
                    currentNumberFrequencyCounter++;
                }

                if (currentNumberFrequencyCounter > maximalFrequencyOfNumber) // Compare if current counter is greather than the maximal and assign the value if it is
                {
                    maximalFrequencyOfNumber = currentNumberFrequencyCounter;
                    maxFrequentNumber = arrayOfIntegers[i]; //Keep the current most frequent number, so we can print it, if it is the most frequent one
                }
            }
        }

        //Printing the ouput!
        Console.WriteLine(new string('=', 40));
        Console.WriteLine("{0} -> ({1} times)",maxFrequentNumber, maximalFrequencyOfNumber);
    }
}