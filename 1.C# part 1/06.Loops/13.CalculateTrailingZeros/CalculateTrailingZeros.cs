/** 
    Write a program that calculates for given N how many trailing zeros present at the end of the number N!. Examples:
	N = 10  N! = 3628800  2
	N = 20  N! = 2432902008176640000  4
	Does your program work for N = 50 000?
	Hint: The trailing zeros in N! are equal to the number of its prime divisors of value 5. Think why!
*/

using System;
using System.Numerics;

class CalculateTrailingZeros
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
        int inputNumber;
        int counter = 0;
        BigInteger nFactorial = 1;

        //Using method ValidateInputInteger(string textToDisplay) to assign value
        inputNumber = ValidateInputInteger("Please enter integer number to check: ");

        for (int i = 1; i <= inputNumber; i++) //Loop for calculating N factorial
        {
            nFactorial *= i;

            if (i % 5 == 0) // Counting the prime divisors of value 5
            {
                counter++;
            }
        }

        Console.WriteLine(new string('=', 40));
        Console.WriteLine("N = {0} -> {0}! = {1} -> {2}", inputNumber, nFactorial, counter);
    }
}