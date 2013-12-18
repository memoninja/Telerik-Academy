// 9. In the combinatorial mathematics, the Catalan numbers are calculated by the following formula:
//    Write a program to calculate the Nth Catalan number by given N.
//================================================================================================================================
// Exercise 10 is exercise 9
//================================================================================================================================
// First 26 Catalan members, according to Wikipedia:
// 1, 1, 2, 5, 14, 42, 132, 429, 1430, 4862, 16796, 58786, 208012, 742900, 2674440, 9694845, 35357670, 129644790, 477638700,
// 1767263190, 6564120420, 24466267020, 91482563640, 343059613650, 1289904147324, 4861946401452
//================================================================================================================================

using System;
using System.Numerics;

class CatalanNumbers
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
        int inputN;
        BigInteger nFactorial = 1;
        BigInteger twiceNFactorial = 1;
        BigInteger nFactorialPlusOne = 1;
        BigInteger catalanNumber = 1;

        //Using method ValidateInputInteger(string textToDisplay) to assign value
        inputN = ValidateInputInteger("Please enter number N: ") - 1; //Subtract 1 to compensate that first two Catalan members are 1

        for (int i = 1; i <= inputN * 2; i++) //Loop for calculating the factorials
        {
            twiceNFactorial *= i;

            if (i == inputN)
            {
                nFactorial = twiceNFactorial; //Assign the already calculated value
            }

            if (i == inputN + 1)
            {
                nFactorialPlusOne = twiceNFactorial; //Assign the already calculated value
            }
        }

        catalanNumber = twiceNFactorial / (nFactorialPlusOne * nFactorial); //Calculate wanted Catalan number

        Console.WriteLine(new string('=', 30));
        Console.WriteLine("Catalan number {0} is: {1}", inputN + 1, catalanNumber);
    }
}