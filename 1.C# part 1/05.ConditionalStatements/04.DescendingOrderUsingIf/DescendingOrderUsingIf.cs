// 4. Sort 3 real values in descending order using nested if statements.

using System;

class DescendingOrderUsingIf
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
        //------------------------------------------------------------------------------------------
        //This program can be made much better, but the description says "using nested if statements.
        //------------------------------------------------------------------------------------------

        double firstNumber;
        double secondNumber;
        double thirdNumber;
        double smallNumber = 0;
        double middleNumber = 0;
        double bigNumber = 0;

        //Using method "ValidateInputDouble(string textToDisplay)" to get validated double from the user
        firstNumber = ValidateInputDouble("Please enter first real number!");
        secondNumber = ValidateInputDouble("Please enter second real number!");
        thirdNumber = ValidateInputDouble("Please enter third real number!");

        Console.WriteLine(new string('=', 35));

        // If some of the numbers are equal the program is terminated
        if (firstNumber == secondNumber || secondNumber == thirdNumber || firstNumber == thirdNumber)
        {
            Console.WriteLine("Please enter different numbers!");
            return;
        }

        if (firstNumber > secondNumber && firstNumber > thirdNumber )
        {
            bigNumber = firstNumber;

            if (secondNumber > thirdNumber)
            {
                middleNumber = secondNumber;
                smallNumber = thirdNumber;
            }
            else // secondNumber < thirdNumber
            {
                middleNumber = thirdNumber;
                smallNumber = secondNumber;
            }
        }
        else if (secondNumber > firstNumber && secondNumber > thirdNumber)
        {
            bigNumber = secondNumber;

            if (firstNumber > thirdNumber)
            {
                middleNumber = firstNumber;
                smallNumber = thirdNumber;
            }
            else // firstNumber < thirdNumber
            {
                middleNumber = thirdNumber;
                smallNumber = firstNumber;
            }
        }
        else // (thirdNumber > firstNumber && thirdNumber > secondNumber)
        {
            bigNumber = thirdNumber;

            if (firstNumber > secondNumber)
            {
                middleNumber = firstNumber;
                smallNumber = secondNumber;
            }
            else // firstNumber < secondNumber
            {
                middleNumber = secondNumber;
                smallNumber = firstNumber;
            }
        }

        Console.WriteLine("   big: {0}", bigNumber);
        Console.WriteLine("middle: {0}", middleNumber);
        Console.WriteLine(" small: {0}", smallNumber);
    }
}