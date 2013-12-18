// 7. Write a program that reads a number N and calculates the sum of the first N members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
// Each member of the Fibonacci sequence (except the first two) is a sum of the previous two members.

using System;
using System.Numerics;

class NMembersOfFibonacciSequence
{
    //This method validate the number entered by the user
    static int ValidateInputInteger(string textToDisplay)
    {
        int inputNumber;

        Console.Write(textToDisplay);

        while (true)
        {
            //Try to parse integer until a correct number is entered by the user
            while (!int.TryParse(Console.ReadLine(), out inputNumber))
            {
                Console.WriteLine("Please enter a correct integer!");
            }

            if (inputNumber > 1) //Check, if number is greather than 1 the loop stops and the program continue
            {
                break;
            }
            else
            {
                Console.WriteLine("Please enter a correct integer, note that it must be greather than 1!");
            }
        }

        return inputNumber; //The method returns "inputNumber"
    }

    static void Main()
    {
        int fibonacciSequenceLength; //This variable is of type "int" just in case, I hope that the user will not try so big integers
        BigInteger previousNumber = 1;  //Using variable of type BigInteger because of the very big numbers which have to be calculated
        BigInteger currentNumber = 0; // Couldn't think up of better names
        BigInteger sumOf2Previous;
        BigInteger totalSum = 0;

        //Using method ValidateInputInteger(string textToDisplay) to assign value
        fibonacciSequenceLength = ValidateInputInteger("Please enter Fibonacci sequence length N: ");

        Console.WriteLine(new string('=', 40));
        Console.WriteLine("Member   1 : 0");

        // Loop for calculating and printing sequence of Fibonacci
        for (int i = 1; i < fibonacciSequenceLength; i++)
        {
            sumOf2Previous = previousNumber + currentNumber; //Sum of the last two numbers of the sequence
            totalSum += sumOf2Previous; //Total sum of the current sequence

            Console.WriteLine("Member {0, 3} : {1}", (i + 1), sumOf2Previous);

            //Using two variables to keep the current last two numbers of the sequence
            previousNumber = currentNumber;
            currentNumber = sumOf2Previous;
        }

        Console.WriteLine(new string('=', 40));
        Console.WriteLine("Total sum of Fibonacci sequense is: {0}", totalSum);
    }
}