// 16. * We are given an array of integers and a number S.
//      Write a program to find if there exists a subset of the elements of the array that has a sum S. Example:
//	    arr={2, 1, 2, 4, 3, 5, 2, 6}, S=14 -> yes (1+2+5+6)

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //If try to input some incorrect data in the array the program will "say": Sum was not found

        int[] givenArray;
        int sumS;
        int maxVariations;
        List<int> currentNumbers = new List<int>();
        bool isSumFound = false;

        givenArray = ValidateInputIntegerArray(); //Using method "ValidateInputIntegerArray()"
        sumS = ValidateInputInteger(); //Usign method "ValidateInputInteger()"
        //Faster way to pow up number is with "for" loop, but...
        maxVariations = ((int)Math.Pow(2, givenArray.Length)) - 1; //Max variations (2^n-1)

        Console.WriteLine(new string('=', 45));
        Console.WriteLine("All possible variations that have sum {0} are:", sumS);

        //Main logic of the exercise
        for (int i = 1; i < maxVariations; i++) //Loop to go through all possible variations. Max variations (2^n-1)
        {
            int currentSum = 0; //On each iteration set the current sum to 0
            currentNumbers.Clear(); //On each iteration remove all elements from the list

            for (int j = 0; j < givenArray.Length; j++) //Loop to go through the input array elements
            {
                int mask = 1 << j;
                if ((mask & i) != 0) //Check if the bit of the current variation, at corresponding array position is 0 or 1.
                {                    // If it is 0, we add the corresponding element of the array, to the current sum
                    currentSum += givenArray[j];
                    currentNumbers.Add(givenArray[j]); //Add thee array element in tha "List"
                }
            }

            if (currentSum == sumS) //If the current sum is equal to the wanted sum, we print the "List" on the console
            {
                isSumFound = true;

                for (int index = 0; index < currentNumbers.Count; index++)
                {
                    Console.Write(currentNumbers[index]);
                    
                    if (index < currentNumbers.Count - 1)
                    {
                        Console.Write(",");
                    }
                }
                Console.WriteLine();
            }
        }

        if (!isSumFound) // If the wanted sum is not found, print a message
        {
            Console.WriteLine("The sum {0} was Not found!", sumS);
        }
    }

    static int[] ValidateInputIntegerArray() //Method to validate the input array of integers
    {
        string givenArray;
        string[] givenArrayToNumbers;
        int[] arrayOfIntegers;
        char[] sequenceCharsToRemove = { ',', ' ' }; // This array is used in the "split method" to remove comma and space in the input array

        Console.WriteLine("Please enter a sequence of numbers to be checked.");
        Console.WriteLine("It is allowed to separate the numbers with comma and space \", \"");

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
                break;
            }
        }

        return arrayOfIntegers;
    }

    static int ValidateInputInteger() //Method to validate the input integer
    {
        int inputInteger;

        Console.Write("Please enter integer number(sum) \"S\": ");

        while (!int.TryParse(Console.ReadLine(), out inputInteger))
        {
            Console.WriteLine("Please enter correct integer number!");
        }

        return inputInteger;
    }
}