// 20. Write a program that reads two numbers N and K
//     and generates all the variations of K elements from the set [1..N]. Example:
//     N = 3, K = 2  {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}


using System;
using System.Collections.Generic;
using System.Linq;

class ProCombinationsOfNAndKgram
{
    static void Main()
    {
        int givenN;
        int givenK;

        // Using method "ValidateInputInteger(string textToDisplay)"
        givenN = ValidateInputInteger("Please enter number N: ");
        givenK = ValidateInputInteger("Please enter number K: ");

        //Using method "PermutationsGenerator(int[] PermutationsArray, int currentIndex, int maxNumber)", to generate all possible combinations
        PermutationsGenerator(new int[givenK], 0, givenN);
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
    static void PermutationsGenerator(int[] PermutationsArray, int currentIndex, int maxNumber)
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
        for (int i = 1; i <= maxNumber; i++)
        {
            PermutationsArray[currentIndex] = i;
            PermutationsGenerator(PermutationsArray, currentIndex + 1, maxNumber);//Call recursivly method "PermutationsGenerator()"
        }
    }
}
