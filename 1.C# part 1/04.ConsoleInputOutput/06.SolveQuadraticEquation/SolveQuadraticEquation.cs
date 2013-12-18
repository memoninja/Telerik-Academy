// 6. Write a program that reads the coefficients a, b and c of a quadratic equation ax2+bx+c=0 and solves it (prints its real roots).

using System;

class SolveQuadraticEquation
{
    //This method parse input data from the user to double
    private static double parseDoubleNumber(string textToDisplay)
    {
        double inputNumber;

        Console.WriteLine(new string('-', 40));
        Console.WriteLine(textToDisplay);
        
        //Trying to parse until a correct number is entered
        while (!double.TryParse(Console.ReadLine(), out inputNumber))
        {
            Console.WriteLine("Please enter correct number!");
        }
        //This method return "inputNumber"
        return inputNumber;
    }

    static void Main()
    {
        double coeffA;
        double coeffB;
        double coeffC;
        double square1;
        double square2;
        double discriminant;

        Console.WriteLine("This program solves a quadratic equation.");

        //Using method "parseDoubleNumber(string textToDisplay)" to validate the input data
        coeffA = parseDoubleNumber("Please enter coefficient A");
        coeffB = parseDoubleNumber("Please enter coefficient B");
        coeffC = parseDoubleNumber("Please enter coefficient C");

        //Calculate discriminant by the formula: D = b*b - 4ac
        discriminant = (coeffB * coeffB) - (4 * coeffA * coeffC);

        //Check if discriminant is lower than 0
        if (discriminant < 0)
        {
            Console.WriteLine(new string('=', 40));
            Console.WriteLine("The equation has no square. It is linear equation!");
        }
        //Check if discriminant equals 0
        else if (discriminant == 0)
        {
            //Calculate the square by the formula x=-b/(2*a)
            square1 = -coeffB / (2 * coeffA);

            Console.WriteLine(new string('=', 40));
            Console.WriteLine("The equation has one square : {0}", square1);
        }
        //If discriminant is greather than 0, the equation has two answers(squares)
        else
        {
            //Calculate the both squares of the equation
            square1 = (-coeffB + Math.Sqrt(discriminant)) / (2 * coeffA);
            square2 = (-coeffB - Math.Sqrt(discriminant)) / (2 * coeffA);

            Console.WriteLine(new string('=', 40));
            Console.WriteLine("Square 1 is : {0}", square1);
            Console.WriteLine("Square 2 is : {0}\n", square2);
        }
    }
}