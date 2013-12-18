// 21. Write a program that reads two numbers N and K
//     and generates all the combinations of K distinct elements from the set [1..N]. Example:
//	   N = 5, K = 2 -> {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}

using System;
using System.Collections.Generic;
using System.Linq;

class CombinationsOfKDistinctElements
{
    static void Main()
    {
        int givenN;
        int givenK;

        // Using method "ValidateInputInteger(string textToDisplay)"
        givenN = ValidateInputInteger("Please enter number N: ");
        givenK = ValidateInputInteger("Please enter number K: ");

        //Using method "PermutationsGenerator(int[] PermutationsArray, int currentIndex, int maxNumber)", to generate all possible combinations
        PermutationsGenerator(new int[givenK], 0, givenN, 1);
    }

    static int ValidateInputInteger(string textToDisplay) //Method to validate the input integer
    {
        int inputInteger;

        Console.Write(textToDisplay);

        while (!int.TryParse(Console.ReadLine(), out inputInteger)) //If input data is not a correct integer
        {
            Console.WriteLine("Please enter correct integer number!"); //message is show and thw user haave to enter integer number again
        }

        return inputInteger;
    }

    //Method to generate all possible combinations
    static void PermutationsGenerator(int[] PermutationsArray, int currentIndex, int maxNumber, int currentValue)
    {
        if (currentIndex >= PermutationsArray.Length) //If current index reaches the bounds of the array, the recursion stops
        {
            for (int i = 0; i < PermutationsArray.Length; i++) // and display the combinations
            {
                Console.Write(PermutationsArray[i]);
            }
            Console.WriteLine();
            return;
        }

        //assign values from 1 to maxNumber to the array and increment current index on each iteration
        //increment currentValues on each iteration and recursion, so we do not use the same number in two recursions. Note that incremention is made in the method(recursion) too!!!
        for (int i = currentValue; i <= maxNumber; i++)
        {
            PermutationsArray[currentIndex] = i;
            PermutationsGenerator(PermutationsArray, currentIndex + 1, maxNumber, i + 1);//Call recursivly method "PermutationsGenerator()"

        }
    }
}
