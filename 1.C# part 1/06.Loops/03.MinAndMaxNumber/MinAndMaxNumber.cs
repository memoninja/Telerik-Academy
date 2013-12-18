// 3. Write a program that reads from the console a sequence of N integer numbers and returns the minimal and maximal of them.

using System;

class MinAndMaxNumber
{
    //Method to parse the input data to integer
    static int ValidateInputInteger(string textToDisplay)
    {
        int inputNumber;

        Console.WriteLine(textToDisplay);

        //Loop to parse the input data from the user to integer number
        while (!int.TryParse(Console.ReadLine(), out inputNumber))
        {
            Console.WriteLine("Please enter a correct integer number!");
        }

        return inputNumber; //The method returns "inputNumber"
    }


    static void Main()
    {
        int sequenceLength;
        int[] numbersToCheck; //Using array to store the input numbers
        int minimal;
        int maximal;

        //Using method "ValidateInputInteger(string textToDisplay)" to assign values to sequenceLength
        sequenceLength = ValidateInputInteger("Please enter the sequence length");
        numbersToCheck = new int[sequenceLength]; //Assigning length to the array

        for (int i = 0; i < sequenceLength; i++) //Loop to assign values to the array
        {
            Console.Write("Please enter number {0}", i);
            numbersToCheck[i] = ValidateInputInteger(""); //Using method "ValidateInputInteger(string textToDisplay)"
        }

        minimal = numbersToCheck[0];
        maximal = numbersToCheck[0];

        for (int i = 0; i < sequenceLength - 1; i++) //Loop to check for maximal and minimal numbers
        {
            if (numbersToCheck[i + 1] < minimal)
            {
                minimal = numbersToCheck[i + 1];
            }

            if (numbersToCheck[i + 1] > maximal)
            {
                maximal = numbersToCheck[i + 1];
            }
        }

        Console.WriteLine(new string('=', 30));
        Console.WriteLine("minimal: {0}\nmaximal: {1}", minimal, maximal);
    }
}