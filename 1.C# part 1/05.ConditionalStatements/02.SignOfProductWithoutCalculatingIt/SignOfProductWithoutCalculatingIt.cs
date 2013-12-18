// 2. Write a program that shows the sign (+ or -) of the product of three real numbers without calculating it.
// Use a sequence of if statements.

using System;

class SignOfProductWithoutCalculatingIt
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

    //This method check if given number is lower than zero and if so, it returns 1
    static byte IsLowerThanZero(double inputNumber)
    {
        if (inputNumber < 0)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }

    static void Main()
    {
        double firstNumber;
        double secondNumber;
        double thirdNumber;
        byte counter = 0;

        //Using method "ValidateInputDouble(string textToDisplay)" to get validated double from the user
        firstNumber = ValidateInputDouble("Please enter first real number!");
        secondNumber = ValidateInputDouble("Please enter second real number!");
        thirdNumber = ValidateInputDouble("Please enter third real number!");

        //Check if one of the numbers is zero. Zero is neither positive nor negative number!
        if (firstNumber == 0 || secondNumber == 0 || thirdNumber == 0)
        {
            Console.WriteLine(new string('=', 40));
            Console.WriteLine("The product of the three numbers is neither positive nor negative: 0");
            return;
        }

        //Using method "static byte IsLowerThanZero(double inputNumber)" to check if numnber is lower than zero and return 1 if so
        counter += IsLowerThanZero(firstNumber);
        counter += IsLowerThanZero(secondNumber);
        counter += IsLowerThanZero(thirdNumber);

        Console.WriteLine(new string('=', 40));

        //If the negative numbers count is 1 or 3, their produc will be negative
        if (counter == 1 || counter == 3)
        {
            Console.WriteLine("The product is negative number!");
        }
        else
        {
            Console.WriteLine("The product is positive number!");
        }
    }
}