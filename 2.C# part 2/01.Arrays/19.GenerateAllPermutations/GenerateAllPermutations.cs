// 19. * Write a program that reads a number N 
//  and generates and prints all the permutations of the numbers [1 … N].Example:
//	n = 3 -> {1, 2, 3}, {1, 3, 2}, {2, 1, 3}, {2, 3, 1}, {3, 1, 2}, {3, 2, 1}

using System;
using System.Collections.Generic;
using System.Linq;

class GenerateAllPermutations
{
    static void Main()
    {
        int givenN;

        givenN = ValidateInputInteger(); // Using method "ValidateInputInteger()"

        //Using method "PermutationsGenerator(int[] PermutationsArray, int currentIndex)", to generate all possible combinations
        PermutationsGenerator(new int[givenN], 0);
    }

    static int ValidateInputInteger() //Method to validate the input integer
    {
        int inputInteger;

        Console.Write("Please enter number N: ");

        while (!int.TryParse(Console.ReadLine(), out inputInteger)) //If input data is not a correct integer
        {
            Console.WriteLine("Please enter correct integer number!"); //message is show and thw user haave to enter integer number again
        }

        return inputInteger;
    }

    //Method to generate all possible combinations
    static void PermutationsGenerator(int[] PermutationsArray, int currentIndex)
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

        //assign values from 1 to the array's length, to PermutationsArray and increment current index on each iteration
        for (int i = 1; i <= PermutationsArray.Length; i++)
        {
            PermutationsArray[currentIndex] = i;
            PermutationsGenerator(PermutationsArray, currentIndex + 1);//Call recursivly method "PermutationsGenerator()"
        }
    }
}
