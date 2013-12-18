// 5. Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).

using System;
using System.Numerics;

class Program
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
        int nSequence;
        int kSequence;

        BigInteger nFact = 1;
        BigInteger kFact = 1;
        BigInteger nMinusKFact = 1;
        BigInteger result;

        //Using method ValidateInputInteger(string textToDisplay) to assign value
        kSequence = ValidateInputInteger("Please enter K! sequence: ");
        nSequence = ValidateInputInteger("Please enter N! sequence: ");

        Console.WriteLine(new string('=', 30));

        if (kSequence <= nSequence) //Check if 1<N<K, if not program is terminated
        {
            Console.WriteLine("1 < N < K");
            return;
        }

        for (int i = 1; i <= kSequence; i++) //Loop for calculating K!
        {
            kFact *= i;

            if (i == nSequence)
            {
                nFact = kFact; //Assign the already calculated value N!
            }

            if (i == kSequence - nSequence)
            {
                nMinusKFact = kFact; //Assign the already calculated value (K-N)!
            }
        }

        result = (nFact * kFact) / nMinusKFact; //Calculating: N!*K! / (K-N)!

        Console.WriteLine("{0}! * {1}! / ({1} - {0})! = {2}", nSequence, kSequence, result);
    }
}