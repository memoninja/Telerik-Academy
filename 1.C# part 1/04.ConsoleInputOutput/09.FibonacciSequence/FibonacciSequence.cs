// 9. Write a program to print the first 100 members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …

using System;
using System.Numerics;

class FibonacciSequence
{
    static void Main()
    {
        byte fibonacciSequenceLength = 100;
        BigInteger previousNumber = 1;  //Using variable of type BigInteger because of the very big numbers which have to be calculated
        BigInteger currentNumber = 0; // Couldn't think up of better names
        BigInteger sumOf2Previous;
        // First way with just two variables

        //Console.WriteLine(0);

        ////Loop for calculating and printing sequence of Fibonacci
        //for (byte i = 0; i < fibonacciSequenceLength / 2; i++)
        //{
        //    previousNumber += currentNumber;
        //    currentNumber += previousNumber;

        //    Console.WriteLine(previousNumber);
        //    Console.WriteLine(currentNumber);
        //}


        // Second way with three variables

        Console.WriteLine("Member   1 : 0");

        // Loop for calculating and printing sequence of Fibonacci
        for (int i = 1; i < fibonacciSequenceLength; i++)
        {
            //Sum of the last two numbers of the sequence
            sumOf2Previous = previousNumber + currentNumber;

            Console.WriteLine("Member {0, 3} : {1}", (i + 1), sumOf2Previous);

            //Using two variables to keep the current last two numbers of the sequence
            previousNumber = currentNumber;
            currentNumber = sumOf2Previous;
        }
    }
}