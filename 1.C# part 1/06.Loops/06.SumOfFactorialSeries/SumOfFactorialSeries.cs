// 6. Write a program that, for a given two integer numbers N and X, calculates the sumS = 1 + 1!/X + 2!/X^2 + … + N!/X^N

using System;

class SumOfFactorialSeries
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
        int inputX;
        int nFactorial = 1;
        int currentXSquare;
        double sumS = 1.0d;

        //Using method ValidateInputInteger(string textToDisplay) to assign value
        inputN = ValidateInputInteger("Please enter number N: ");
        inputX = ValidateInputInteger("Please enter number X: ");

        for (int i = 1; i <= inputN; i++) //Loop for summing: 1 + (1!/X) + (2!/X^2)...
        {
            currentXSquare = inputX;
            nFactorial = 1;

            for (int j = i; j > 1; j--) //Loop for calculating N! and X square
            {
                nFactorial *= j;
                currentXSquare *= inputX;
            }

            sumS += (double)nFactorial / currentXSquare; //Calculating the total sum for each iteration
        }

        Console.WriteLine(new string('=', 60));
        Console.WriteLine("S = 1 + 1!/{0} + 2!/{0}^2 + ... + {1}!/{0}^{1} = {2}", inputX, inputN, sumS);
    }
}