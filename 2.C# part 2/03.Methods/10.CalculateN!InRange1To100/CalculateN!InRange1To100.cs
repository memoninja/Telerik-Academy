// 10. Write a program to calculate n! for each n in the range [1..100].
//Hint: Implement first a method that multiplies a number represented as array of digits by given integer number. 

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int factorialRange;
        int[] factorial;

        //Validate the input number and assign it to the variable, using method "ValidateInputInteger(string textToPrint)"
        factorialRange = ValidateInputInteger("Enter factorial range n: ");

        Console.WriteLine(new string('=', 70));
        Console.WriteLine("Factorials to {0} are:", factorialRange);

        //Calculate the factorial and assign it to an array, using method "CalculateFactorial(int nFactorial)"
        factorial = CalculateFactorial(factorialRange);
    }

    //Calculate factorial(n!) by given range(n)
    //Return type is "int[]" - array
    private static int[] CalculateFactorial(int nFactorial) //Method have one parameter
    {
        int[] previousFac = new int[1];
        List<int> currenntFac = new List<int>();
        int remainder = 0;
        int nCounter = 1;
        int currentSum = 0;

        previousFac[0] = 1;

        while (nCounter <= nFactorial) //Loop goes until we reach the input range of the factorial
        {
            //Each of the values in the array is multiplied by the current "n" of the factorial sequence
            //On each iteration we track the value of the remainder, we have to include in the next iteration 
            for (int i = 0; i < previousFac.Length; i++)
            {
                currentSum = remainder + (nCounter * previousFac[i]);

                if (currentSum >= 10)
                {
                    currenntFac.Add(currentSum % 10);
                    remainder = currentSum / 10;
                }
                else //If currentSum < 10
                {
                    currenntFac.Add(currentSum);
                    remainder = 0;
                }
            }

            //If we reach the array end there is still remainder to add. It is added digit by digit, not the whole number
            if (remainder > 0)
            {
                while (remainder > 0)
                {
                    currenntFac.Add(remainder % 10);
                    remainder /= 10;
                }

                remainder = 0; //When we finish with adding the remainde, we set it to 0
            }

            previousFac = new int[currenntFac.Count]; //Set the needed length for the next interation
            currenntFac.CopyTo(previousFac); //Copy the values of the current factorial(List<int>) to an array
            currenntFac.Clear(); //Cleear the list, because we copied it to the array, and we need it empty for the next iteration

            PrintArray(previousFac); //Print the factorial on each iteration, using method "PrintArray(int[] arrayToPrint)"

            nCounter++; //Increment the current factorial sequence "n", on each iteration
        }

        return previousFac; //After adding is done, we return the array of digits
    }

    //Check if input number is correct integer
    //Return type is "int"
    private static int ValidateInputInteger(string textToPrint) //Method have one parameter
    {
        int givenInteger;

        Console.Write(textToPrint);

        while (true)
        {
            while (!int.TryParse(Console.ReadLine(), out givenInteger)) //Loop goes intil a correct integer is entered
            {
                Console.Write("Please enter correct integer: ");
            }

            //Check if given factorial sequence(range) is less than 0
            if (givenInteger < 0)
            {
                Console.WriteLine("N can not be less than 0! Please enter correct integer: ");
            }
            else
            {
                break;
            }
        }

        return givenInteger; //The method returns the input integer, after it is validated
    }

    //Print given array
    //Return type is "void" - return nothing
    private static void PrintArray(int[] arrayToPrint) //Method have one parameter
    {
        for (int i = arrayToPrint.Length - 1; i >= 0; i--)
        {
            Console.Write(arrayToPrint[i]);
        }

        Console.WriteLine();
    }
}
