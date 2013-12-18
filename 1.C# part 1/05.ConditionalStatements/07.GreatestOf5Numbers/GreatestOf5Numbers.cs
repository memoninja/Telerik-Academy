// 7.Write a program that finds the greatest of given 5 variables.

using System;

class GreatestOf5Numbers
{
    //This method validate the number entered by the user
    static double ValidateInputDouble(string textToDisplay)
    {
        double inputNumber;

        Console.WriteLine(textToDisplay);

        //Try to parse double until a correct number is entered by the user
        while (!double.TryParse(Console.ReadLine(), out inputNumber))
        {
            Console.WriteLine("Please enter a correct double!");
        }
        //The method returns "inputNumber"
        return inputNumber;
    }

    static void Main()
    {
        double[] numbersToCompare = new double[5]; //Using array of doubles
        double greatestNumber;

        for (int i = 0; i < numbersToCompare.Length; i++) //Using loop for assigning a values to the array
        {
            Console.Write("Please enter number {0}", i + 1);
            numbersToCompare[i] = ValidateInputDouble("");
        }

        greatestNumber = numbersToCompare[0];

        for (int i = 0; i < numbersToCompare.Length - 1; i++) //Using loop to compare the input number int the array
        {
            if (numbersToCompare[i + 1] > greatestNumber)
            {
                greatestNumber = numbersToCompare[i + 1];
            }
        }

        Console.WriteLine(new string('=', 30));
        Console.WriteLine("Greatest number is: {0}", greatestNumber);
    }
}