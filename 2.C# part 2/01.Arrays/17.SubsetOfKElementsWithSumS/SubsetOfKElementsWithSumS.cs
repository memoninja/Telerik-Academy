// 17. * Write a program that reads three integer numbers N, K and S and an array of N elements from the console.
//       Find in the array a subset of K elements that have sum S or indicate about its absence.

using System;
using System.Collections.Generic;
using System.Linq;

class SubsetOfKElementsWithSumS
{
    static void Main(string[] args)
    {
        int givenN;
        int givenK;
        int sumS;
        int[] givenArray;
        List<int> subsetList = new List<int>();
        int maxVariations;
        bool isSumFound = false;

        givenN = ValidateInputInteger("Please enter number N: ");
        givenK = ValidateInputInteger("Please enter number K: ");
        sumS = ValidateInputInteger("Please enter sum S: ");
        givenArray = ValidateInputIntegerArray(givenN);

        //Faster way to pow up number is with "for" loop, but...
        maxVariations = ((int)Math.Pow(2, givenN)) - 1; //Max variations (2^n-1)

        Console.WriteLine(new string('=', 45));
        Console.WriteLine("Subset array of {0} numbers that have sum {1} is:", givenK, sumS);

        //Main logic of the exercise
        for (int i = 1; i < maxVariations; i++) //Loop to go through all possible variations. Max variations (2^n-1)
        {
            int currentSum = 0; //On each iteration set the current sum to 0
            int elementsCounter = 0;
            subsetList.Clear(); //On each iteration remove all elements from the list

            for (int j = 0; j < givenArray.Length; j++) //Loop to go through the input array elements
            {
                int mask = 1 << j;
                if ((mask & i) != 0 && elementsCounter < givenK) //Check if the bit of the current variation, at corresponding array position is 0 or 1.
                {                    // If it is 0, we add the corresponding element of the array, to the current sum
                    if (currentSum < sumS)
                    {
                        currentSum += givenArray[j];
                        subsetList.Add(givenArray[j]); //Add the array element in tha "List"
                        elementsCounter++; //Track for the count of the elements that equals "sumS", it have to be equal to "givenK" to display the elements
                    }
                }
            }

            if (currentSum == sumS && elementsCounter == givenK) //If the current sum is equal to the wanted sum,
            {                                                    //and the number of elements is equal to "givenK", and print the "List" on the console
                isSumFound = true; //Flag that the wanted sum is found

                for (int index = 0; index < subsetList.Count; index++)
                {
                    Console.Write(subsetList[index]);

                    if (index < subsetList.Count - 1)
                    {
                        Console.Write(",");
                    }
                }
                Console.WriteLine();
                break; //If you want to see all possible combinations that equals "sumS", remove this break;
            }
        }

        if (!isSumFound) // If the wanted sum is not found, print a message
        {
            Console.WriteLine("The sum {0} was Not found!", sumS);
        }


    }

    static int ValidateInputInteger(string textToDisplay) //Method to validate the input integer
    {
        int inputInteger;

        Console.Write("{0}", textToDisplay);

        while (!int.TryParse(Console.ReadLine(), out inputInteger))
        {
            Console.WriteLine("Please enter correct integer number!");
        }

        return inputInteger;
    }

    static int[] ValidateInputIntegerArray(int arrayLengrh) //Method to validate the input integer array
    {
        int[] arrayToValidate = new int[arrayLengrh];

        for (int i = 0; i < arrayToValidate.Length; i++)
        {
            Console.Write("Please enter array element {0}: ", i);
            arrayToValidate[i] = ValidateInputInteger(""); //Using another method - "ValidateInputInteger(string textToDisplay)"
        }

        return arrayToValidate;
    }
}