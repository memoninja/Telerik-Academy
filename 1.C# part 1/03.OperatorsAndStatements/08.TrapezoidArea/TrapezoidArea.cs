// 8. Write an expression that calculates trapezoid's area by given sides a and b and height h.

using System;

class TrapezoidArea
{
    //This method validate the entered double number from the user
    static double ValidateEnteredDoubleNumber(string textToDisplay)
    {
        double inputDoubleNumber;

        Console.WriteLine(textToDisplay);

        //Trying to parse until a correct number is entered
        while (!double.TryParse(Console.ReadLine(), out inputDoubleNumber))
        {
            Console.WriteLine("Please enter correct number!");
        }
        // inputDoubleNumber is being returned from the method
        return inputDoubleNumber;
    }

    static void Main()
    {
        double baseA;
        double baseB;
        double height;
        double trapezoidArea;

        //Using method "ValidateEnteredDoubleNumber(string textToDisplay)" to validate the entered number from the user
        baseA = ValidateEnteredDoubleNumber("Please enter base A of the trapezoid.");
        baseB = ValidateEnteredDoubleNumber("Please enter base B of the trapezoid.");
        height = ValidateEnteredDoubleNumber("Please enter height of the trapezoid.");

        //Calculate the trapezoid's area via the formula: (a + b) / 2 * height
        trapezoidArea = (baseA + baseB) / 2 * height;

        Console.WriteLine("{0}\nThe trapezoid's are is: {1}\n", new string('-', 37), trapezoidArea);
    }
}