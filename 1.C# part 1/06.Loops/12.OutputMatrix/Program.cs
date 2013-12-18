// 12. Write a program that reads from the console a positive integer number N (N < 20) and outputs a matrix like the following:

using System;

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

            if (inputNumber > 1 && inputNumber < 20) //Check, if number is greather than 1 the loop stops and the program continue
            {
                break;
            }
            else
            {
                Console.WriteLine("Please enter a correct integer, note that it must be\ngreather than 1 and less than 20!");
            }
        }

        return inputNumber; //The method returns "inputNumber"
    }

    static void Main()
    {
        int inputNumberN;
        int currentRowLength;

        //Using method ValidateInputInteger(string textToDisplay) to assign value
        inputNumberN = ValidateInputInteger("Please enter positive integer number N: ");

        Console.WriteLine(new string('=', 40));

        for (int i = 0; i < inputNumberN; i++) //Using 2 nested loops to draw the matrix
        {
            currentRowLength = inputNumberN + i; // Calculate the "length" of the current row

            for (int j = i + 1; j <= currentRowLength; j++)
            {
                Console.Write(j);
            }

            Console.WriteLine(); //Start printing on next line
        }
    }
}